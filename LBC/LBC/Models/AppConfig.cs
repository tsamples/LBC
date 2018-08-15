using System;
using System.Collections.Generic;
using System.Text;

namespace LBC.Models
{
    public class AppConfig
    {
        public string Title { get; set; }
        public List<Item> Menu { get; set; }

        public List<Item> BottomToolBar { get; set; }
    }
}
