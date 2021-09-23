using System;
using System.Windows.Input;
using MyTestApp.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MyTestApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Shell.Current.GoToAsync($"{nameof(ItemsPage)}"));
        }

        public ICommand OpenWebCommand { get; }
    }
}
