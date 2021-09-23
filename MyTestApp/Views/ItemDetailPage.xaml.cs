using System.ComponentModel;
using Xamarin.Forms;
using MyTestApp.ViewModels;

namespace MyTestApp.Views
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
