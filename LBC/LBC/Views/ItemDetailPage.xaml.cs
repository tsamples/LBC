using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LBC.Models;
using LBC.ViewModels;
using LBC.Services;

namespace LBC.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemDetailPage : ContentPage
	{
        ItemDetailViewModel viewModel;
        RestDataStore restDataStore = new RestDataStore();

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
                //Text = "Item 1",
                //Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            
        }
    }
}