using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Talking_Clock.Models;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Talking_Clock.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        private string PLangCC;
        private string PLangCCDesc;
        private bool PUseSpeech;
        private bool PUseMsg;
        private bool PisMon, PisTue, PisWed, PisThur, PisFri, PisSat, PisSun;
        private bool PisHr00, PisHr01, PisHr02, PisHr03, PisHr04, PisHr05, PisHr06;
        private bool PisHr07, PisHr08, PisHr09, PisHr10, PisHr11, PisHr12, PisHr13;
        private bool PisHr14, PisHr15, PisHr16, PisHr17, PisHr18, PisHr19, PisHr20;
        private bool PisHr21, PisHr22, PisHr23;
        public NewItemViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
            PLangCCDesc = Preferences.Get("LangDesc", "Hong Kong");
            PLangCC = PLangCCDesc == "Hong Kong" ? "HK" : "EN";
            PUseSpeech = Preferences.Get("Use_Speech", true);
            PUseMsg= Preferences.Get("Use_Notification", true );
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

        }

        private bool ValidateSave()
        {
            return true;
        }
        public string LangCC
        {
            get { if (PLangCCDesc == "Hong Kong")  PLangCC = "HK";
                else PLangCC="US";
                return PLangCC;
            }
            set => SetProperty(ref PLangCC, value);
        }

        public string LangCCDesc
        {
            get => PLangCCDesc;
            set => SetProperty(ref PLangCCDesc, value);
        }

        public bool UseSpeech
        {
            get => PUseSpeech;
            set => SetProperty(ref PUseSpeech, value);
            // set => Preferences.Get("Use_Speech", true);
        }

        public bool UseMsg
        {
            get => PUseMsg; 
            set => SetProperty(ref PUseMsg, value);
        }
        public bool isMon
        {
            get => PisMon;
            set => SetProperty(ref PisMon, value);
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

        public bool isHr00
        {
            get => PisHr00;
            set => SetProperty(ref PisHr00, value);
        }
        public bool isHr01
        {
            get => PisHr01;
            set => SetProperty(ref PisHr01, value);
        }
        public bool isHr02
        {
            get => PisHr02;
            set => SetProperty(ref PisHr02, value);
        }
        public bool isHr03
        {
            get => PisHr03;
            set => SetProperty(ref PisHr03, value);
        }
        public bool isHr04
        {
            get => PisHr04;
            set => SetProperty(ref PisHr04, value);
        }
        public bool isHr05
        {
            get => PisHr05;
            set => SetProperty(ref PisHr05, value);
        }
        public bool isHr06
        {
            get => PisHr06;
            set => SetProperty(ref PisHr06, value);
        }

        public bool isHr07
        {
            get => PisHr07;
            set => SetProperty(ref PisHr07, value);
        }
        public bool isHr08
        {
            get => PisHr08;
            set => SetProperty(ref PisHr08, value);
        }
        public bool isHr09
        {
            get => PisHr09;
            set => SetProperty(ref PisHr09, value);
        }
        public bool isHr10
        {
            get => PisHr10;
            set => SetProperty(ref PisHr10, value);
        }
        public bool isHr11
        {
            get => PisHr11;
            set => SetProperty(ref PisHr11, value);
        }
        public bool isHr12
        {
            get => PisHr12;
            set => SetProperty(ref PisHr12, value);
        }
        public bool isHr13
        {
            get => PisHr13;
            set => SetProperty(ref PisHr13, value);
        }
        public bool isHr14
        {
            get => PisHr14;
            set => SetProperty(ref PisHr14, value);
        }
        public bool isHr15
        {
            get => PisHr15;
            set => SetProperty(ref PisHr15, value);
        }
        public bool isHr16
        {
            get => PisHr16;
            set => SetProperty(ref PisHr16, value);
        }
        public bool isHr17
        {
            get => PisHr17;
            set => SetProperty(ref PisHr17, value);
        }
        public bool isHr18
        {
            get => PisHr18;
            set => SetProperty(ref PisHr18, value);
        }
        public bool isHr19
        {
            get => PisHr19;
            set => SetProperty(ref PisHr19, value);
        }
        public bool isHr20
        {
            get => PisHr20;
            set => SetProperty(ref PisHr20, value);
        }
        public bool isHr21
        {
            get => PisHr21;
            set => SetProperty(ref PisHr21, value);
        }
        public bool isHr22
        {
            get => PisHr22;
            set => SetProperty(ref PisHr22, value);
        }
        public bool isHr23
        {
            get => PisHr23;
            set => SetProperty(ref PisHr23, value);
        }
        public Command SaveCommand { get; }
        public Command CancelCommand { get; }


        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            Preferences.Set("LangDesc", PLangCCDesc);
            PLangCC = PLangCCDesc == "Hong Kong" ? "HK" : "EN";
            Preferences.Set("Lang", PLangCC);
            Preferences.Set("Use_Notification", PUseMsg);
            Preferences.Set("Use_Speech", PUseSpeech);
            Preferences.Set("Is_Mon", PisMon);
            Preferences.Set("Is_Tue", PisTue);
            Preferences.Set("Is_Wed", PisWed);
            Preferences.Set("Is_Thur", PisThur);
            Preferences.Set("Is_Fri", PisFri);
            Preferences.Set("Is_Sat", PisSat);
            Preferences.Set("Is_Sun", PisSun);
            Preferences.Set("Hour00", PisHr00);
            Preferences.Set("Hour01", PisHr01);
            Preferences.Set("Hour02", PisHr02);
            Preferences.Set("Hour03", PisHr03);
            Preferences.Set("Hour04", PisHr04);
            Preferences.Set("Hour05", PisHr05);
            Preferences.Set("Hour06", PisHr06);
            Preferences.Set("Hour07", PisHr07);
            Preferences.Set("Hour08", PisHr08);
            Preferences.Set("Hour09", PisHr09);
            Preferences.Set("Hour10", PisHr10);
            Preferences.Set("Hour11", PisHr11);
            Preferences.Set("Hour12", PisHr12);
            Preferences.Set("Hour13", PisHr13);
            Preferences.Set("Hour14", PisHr14);
            Preferences.Set("Hour15", PisHr15);
            Preferences.Set("Hour16", PisHr16);
            Preferences.Set("Hour17", PisHr17);
            Preferences.Set("Hour18", PisHr18);
            Preferences.Set("Hour19", PisHr19);
            Preferences.Set("Hour20", PisHr20);
            Preferences.Set("Hour21", PisHr21);
            Preferences.Set("Hour22", PisHr22);
            Preferences.Set("Hour23", PisHr23);
            //  await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
