using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Essentials;
using Talking_Clock.ViewModels;


namespace Talking_Clock.Views
{    public partial class AboutPage : ContentPage
    {
        
        public AboutPage()
        {
            InitializeComponent();
            SetGlobalLocale();
        }

        private async void SetGlobalLocale()
        {
            var locales = await TextToSpeech.GetLocalesAsync();
            string PLangCC = Preferences.Get("Lang", "HK");
            string PLangCCDesc = Preferences.Get("LangDesc", "Hong Kong");
            Console.WriteLine("Global Language:" + PLangCC + " - " + PLangCCDesc);
            App.gLocale = locales.LastOrDefault(y => string.Equals(y.Country, PLangCC));
            App.gLangID = PLangCC == "HK" ? 0:2;
        }
        private async void SpeakTime(object sender, EventArgs e)
        {
            SetGlobalLocale();
            SpeechOptions settings = new SpeechOptions()
            {
                Volume = 1.00f,
                Pitch = 0.75f,
                Locale = App.gLocale 
            };
          
            DateTime dt = DateTime.Now.ToLocalTime();
            int hour_only = dt.Hour;
            int minute_only = dt.Minute;
            int second_only = dt.Second;

            await TextToSpeech.SpeakAsync(App.LangSpeech[App.gLangID] + hour_only + App.LangSpeech[App.gLangID + 1], settings);
            Console.WriteLine("It is " + hour_only + " Hour " + minute_only + " Minute " + second_only + " Second ");
            Console.WriteLine("LangID " + App.gLangID);

        }
    }
 

}