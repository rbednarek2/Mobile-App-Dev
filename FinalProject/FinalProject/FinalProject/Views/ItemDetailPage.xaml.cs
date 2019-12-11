using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamarin.Essentials;
using FinalProject.Models;
using FinalProject.ViewModels;

namespace FinalProject.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Restaurant",
                Description = "Phone Number"
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        async void Call(object sender, EventArgs args)
        {
            var phoneNumber = viewModel.Item.Description;

            try
            {
                PhoneDialer.Open(phoneNumber);
            }
            catch (ArgumentNullException anEx)
            {
                // Number was null or white space
            }
            catch (FeatureNotSupportedException ex)
            {
                // Phone Dialer is not supported on this device.
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }
    }
}