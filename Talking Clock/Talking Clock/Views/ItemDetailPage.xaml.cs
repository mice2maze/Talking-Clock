using System.ComponentModel;
using Talking_Clock.ViewModels;
using Xamarin.Forms;

namespace Talking_Clock.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}