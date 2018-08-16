﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LBC.Models;
using LBC.Views;
using LBC.ViewModels;

namespace LBC.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemsPage : ContentPage
	{
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
        }

        public ItemsPage(List<Item> items)
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel(items);
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            if (item.Menu != null && item.Menu.Count > 0)
            {
                await Navigation.PushAsync(new ItemsPage(item.Menu));
                
            } else
            {
                await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));
            }


            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}