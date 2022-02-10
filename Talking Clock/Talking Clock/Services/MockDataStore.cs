using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Talking_Clock.Models;
using Xamarin.Essentials;

namespace Talking_Clock.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;
        public MockDataStore()
        {
            items = new List<Item>()
            {

                new Item { Id = Guid.NewGuid().ToString(), LangCC = "HK", LangCCDesc="Hong Kong", UseMsg = Preferences.Get("Use_Notification",false), UseSpeech = Preferences.Get("Use_Speech",true) , isMon=true, isTue = true, isWed = true, isThur=true,isFri=true, isSat=false, isSun=false, isHr00=false },
                // new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="Template 2", UseMsg = true, UseSpeech = true,DayRange ="0111110", TimeRange = "000000000000000000011110" },
                // new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="Template 3", UseMsg = true, UseSpeech = true,DayRange ="0111110", TimeRange = "000000000000000000011110" },
                // new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="Template 4", UseMsg = true, UseSpeech = true,DayRange ="0111110", TimeRange = "000000000000000000011110" },
                // new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description.", UseMsg = true, UseSpeech = true,DayRange ="0111110", TimeRange = "000000000000000000011110" },
                // new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description.", UseMsg = true, UseSpeech = true,DayRange ="0111110", TimeRange = "000000000000000000011110" }

            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);
            Preferences.Set("Use_Notification", item.UseMsg);
            Preferences.Set("Use_Speech", item.UseSpeech);
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}