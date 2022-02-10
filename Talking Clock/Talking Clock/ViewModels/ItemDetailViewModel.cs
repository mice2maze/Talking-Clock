using System;
using System.Diagnostics;
using Xamarin.Forms;


namespace Talking_Clock.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private bool isMsg;
        private bool isSpk;
        private string PLangCC;
        private string PLangCCDesc;
        private bool PisMon, PisTue, PisWed, PisThur, PisFri, PisSat, PisSun;
        private bool PisHr00, PisHr01, PisHr02, PisHr03, PisHr04, PisHr05, PisHr06;
        private bool PisHr07, PisHr08, PisHr09, PisHr10, PisHr11, PisHr12, PisHr13;
        private bool PisHr14, PisHr15, PisHr16, PisHr17, PisHr18, PisHr19, PisHr20;
        private bool PisHr21, PisHr22, PisHr23;

        public string Id { get; set; }

        public string LangCC
        {
            get => PLangCC;
            set => SetProperty(ref PLangCC, value);
        }

        public string LangCCDesc
        {
            get => PLangCCDesc;
            set => SetProperty(ref PLangCCDesc, value);
        }

        public bool UseSpeech
        {
            get => isSpk;
            set => SetProperty(ref isSpk, value);
        }

        public bool UseMsg
        {
            get => isMsg;
            set => SetProperty(ref isMsg, value);  
        }
        public bool isMon
        {
            get => PisMon;
            set => SetProperty(ref PisMon, value );
        }
        public bool isTue
        {
            get => PisTue;
            set => SetProperty(ref PisTue, value);
        }

        public bool isWed
        { 
            get => PisWed;
            set => SetProperty(ref PisWed, value);
        }


        public bool isThur
        {
            get => PisThur;
            set => SetProperty(ref PisThur, value);
        }


        public bool isFri
        {
            get => PisFri;
            set => SetProperty(ref PisFri, value);
        }
        public bool isSat
        {
            get => PisSat;
            set => SetProperty(ref PisSat, value);
        }
        public bool isSun
        {
            get => PisSun;
            set => SetProperty(ref PisSun, value);
        }
        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                LangCC = item.LangCC;
                UseSpeech = item.UseSpeech;
                UseMsg = item.UseMsg;
                LangCCDesc = item.LangCCDesc;
     
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }

}
