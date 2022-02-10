using System;
using System.Collections.Generic;
using System.ComponentModel;
using Talking_Clock.Models;
using Talking_Clock.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Talking_Clock.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }
        public NewItemPage()
        {
            InitializeComponent();

            BindingContext = new NewItemViewModel();
        }
    }
}