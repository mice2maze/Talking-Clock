
using System;
using System.Linq;
using System.ComponentModel;
using System.Windows.Input;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using Talking_Clock.Models;
using Talking_Clock.Views;

namespace Talking_Clock.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Cuckoo Clock";
            ButtonLabel = "Start Hour Count Down";
            // OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            // OpenWebCommand = new Command(async () => await SpeakNowDefaultSettings;
            AddItemCommand = new Command(OnAddItem);
            AddHoursCommand = new Command(AddHours);
        }

        // public ICommand OpenWebCommand { get; }
        public Command AddItemCommand { get; }
        public ICommand AddHoursCommand { get; }
        private void AddHours()
        {
            DateTime dateTime;
            dateTime = DateTime.Now;
            App.gCountDown = App.gCountDown ? false : true;

            // App.gCountDown = true;
            // App.gHour = App.gHour > 3 ? App.gHour : App.gHour + 1;
            // App.gMin = dateTime.Minute;
            // App.gSec = dateTime.Second;
            // ButtonLabel = App.gHour > 1 ? App.gHour + " Hours Count Down" : App.gHour + " Hour Count Down";
            ButtonLabel = App.gCountDown? "Hour count down starting (Click to stop)": "Start Hour Count Down";
            Console.WriteLine("Count Down - "+App.gCountDown);
        }
        private async void OnAddItem(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewItemPage));
        }


    }
    public class ClockViewModel : INotifyPropertyChanged
    {
        DateTime dateTime;
        private string PLangCC, PLangCCDesc;
        private bool PUseSpeech;
        private bool PUseMsg;
        private bool PisMon, PisTue, PisWed, PisThur, PisFri, PisSat, PisSun;
        private bool PisHr00, PisHr01, PisHr02, PisHr03, PisHr04, PisHr05, PisHr06;
        private bool PisHr07, PisHr08, PisHr09, PisHr10, PisHr11, PisHr12, PisHr13;
        private bool PisHr14, PisHr15, PisHr16, PisHr17, PisHr18, PisHr19, PisHr20;
        private bool PisHr21, PisHr22, PisHr23;
        public Task task;
        public event PropertyChangedEventHandler PropertyChanged;
        public ClockViewModel()
        {
            bool spkTime = false;
            this.DateTime = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(1),  () => {
                this.DateTime = DateTime.Now;
                int ChkMins = 0;
                int spCode = 0;
                int hour_only = this.DateTime.Hour;
                int minute_only = this.DateTime.Minute;
                int second_only = this.DateTime.Second;
                int week_day = (int) this.DateTime.DayOfWeek;
                PLangCC = Preferences.Get("Lang", "HK");
                PLangCCDesc = Preferences.Get("LangDesc", "Hong Kong");
                PUseSpeech = Preferences.Get("Use_Speech", true);
                PUseMsg = Preferences.Get("Use_Notification", true);
                PisMon = Preferences.Get("Is_Mon", false);
                PisTue = Preferences.Get("Is_Tue", false);
                PisWed = Preferences.Get("Is_Wed", false);
                PisThur = Preferences.Get("Is_Thur", false);
                PisFri = Preferences.Get("Is_Fri", false);
                PisSat = Preferences.Get("Is_Sat", false);
                PisSun = Preferences.Get("Is_Sun", false);
                PisHr00 = Preferences.Get("Hour00", false);
                PisHr01 = Preferences.Get("Hour01", false);
                PisHr02 = Preferences.Get("Hour02", false);
                PisHr03 = Preferences.Get("Hour03", false);
                PisHr04 = Preferences.Get("Hour04", false);
                PisHr05 = Preferences.Get("Hour05", false);
                PisHr06 = Preferences.Get("Hour06", false);
                PisHr07 = Preferences.Get("Hour07", false);
                PisHr08 = Preferences.Get("Hour08", false);
                PisHr09 = Preferences.Get("Hour09", false);
                PisHr10 = Preferences.Get("Hour10", false);
                PisHr11 = Preferences.Get("Hour11", false);
                PisHr12 = Preferences.Get("Hour12", false);
                PisHr13 = Preferences.Get("Hour13", false);
                PisHr14 = Preferences.Get("Hour14", false);
                PisHr15 = Preferences.Get("Hour15", false);
                PisHr16 = Preferences.Get("Hour16", false);
                PisHr17 = Preferences.Get("Hour17", false);
                PisHr18 = Preferences.Get("Hour18", false);
                PisHr19 = Preferences.Get("Hour19", false);
                PisHr20 = Preferences.Get("Hour20", false);
                PisHr21 = Preferences.Get("Hour21", false);
                PisHr22 = Preferences.Get("Hour22", false);
                PisHr23 = Preferences.Get("Hour23", false);

                if ((PisMon && week_day == 1) || (PisTue && week_day == 2) || (PisWed && week_day == 3) || (PisThur && week_day == 4) ||
                    (PisFri && week_day == 5) || (PisSat && week_day == 6) || (PisSun && week_day == 7) || App.gCountDown)
                {
                    if ((PisHr00 && hour_only == 0 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr01 && hour_only == 1 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr02 && hour_only == 2 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr03 && hour_only == 3 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr04 && hour_only == 4 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr05 && hour_only == 5 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr06 && hour_only == 6 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr07 && hour_only == 7 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr08 && hour_only == 8 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr09 && hour_only == 9 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr10 && hour_only == 10 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr11 && hour_only == 11 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr12 && hour_only == 12 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr13 && hour_only == 13 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr14 && hour_only == 14 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr15 && hour_only == 15 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr16 && hour_only == 16 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr17 && hour_only == 17 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr18 && hour_only == 18 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr19 && hour_only == 19 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr20 && hour_only == 20 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr21 && hour_only == 21 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr22 && hour_only == 22 && minute_only == ChkMins && second_only == 0) ||
                        (PisHr23 && hour_only == 23 && minute_only == ChkMins && second_only == 0) ||
                        (App.gCountDown && minute_only == ChkMins && second_only == 0))
                    {
                        spkTime = true;
                    }
                }
//                if (App.gMin == minute_only && App.gSec == second_only )
//                {                        
//                    if (App.gHour > 0)
//                    {
//                        App.gHour--;
//                    } else 
//                    { 
//                        spkTime = true; 
//                    }
//                }
            
                if (spkTime)
                {
                    SpeechOptions settings = new SpeechOptions()
                    {
                        Volume = 1.00f,
                        Pitch = 0.75f,
                        Locale = App.gLocale
                    };
                    spkTime = false;
                    spCode = App.gLangID;
                    task = TextToSpeech.SpeakAsync(App.LangSpeech[spCode] + hour_only + App.LangSpeech[spCode + 1], settings).ContinueWith((t) =>
                    {
                        // Logic that will run after utterance finishes.
                        Console.WriteLine(App.LangSpeech[spCode] + hour_only + App.LangSpeech[spCode + 1] + " " + minute_only + ":" + second_only + " On : " + week_day + "; ");
                        Console.WriteLine("SpkTime = " + spkTime);
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                
                }
                return true;
            }
            );
        }

        public DateTime DateTime
        {
            set
            {
                if (dateTime != value)
                {
                    dateTime = value;
                    
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("DateTime"));
                    }
                }
            }
            get
            {
                return dateTime;
            }
        }
    }

}