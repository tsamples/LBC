using System;
using System.Collections.Generic;

namespace LBC.Models
{
    public class Item
    {
        public string Label { get; set; }
        public string ImageURL { get; set; }
        public string ContentId { get; set; }
        public List<Item> Menu { get; set; }
    }
}