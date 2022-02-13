using System;
using Talking_Clock.Services;
using Talking_Clock.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Talking_Clock
{
    public partial class App : Application
    {
        public static Locale gLocale;
        public static int gLangID;
        //public static int gHour= 0;
        //public static int gMin = 0;
        //public static int gSec = 0;
        public static string gButtonLabel = "Start Hour Count Down";
        public static bool gCountDown=false;
        public static string[] LangSpeech = { "依家係", "點", "It's", "O'clock" };
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
