using System;
using System.Diagnostics;
using System.Threading.Tasks;
using LBC.Models;
using Xamarin.Forms;

namespace LBC.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        private string html;
        public Item Item { get; set; }
        public string Html
        {
            get => this.html;
            set => this.SetProperty(ref this.html, value);
        }

        public Command LoadItemCommand { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            LoadItemCommand = new Command(async () => await ExecuteLoadItemCommand());
            this.Item = item;
            this.Title = restDataStore.GetDataFromLocalConfig().Title;
            this.Html = "Loading";
        }
        async Task ExecuteLoadItemCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {


                var html = await restDataStore.getPageContent(this.Item.ContentId);
                this.Html = html;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
