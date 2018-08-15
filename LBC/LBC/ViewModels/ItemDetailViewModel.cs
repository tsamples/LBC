using System;

using LBC.Models;

namespace LBC.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public string Html { get; set; }
        public ItemDetailViewModel(Item item = null)
        {

            this.Item = item;
            this.Title = restDataStore.GetDataFromLocalConfig().Title;
            this.Html = restDataStore.getPageContent(this.Item.ContentId).Result;
        }
    }
}
