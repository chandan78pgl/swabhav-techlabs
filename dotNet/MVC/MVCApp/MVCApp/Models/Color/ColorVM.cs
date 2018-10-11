using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models.Color
{
    public class ColorVM
    {
        public Int32 Count { set; get; }
        public List<ProColor> Colors { set; get; }
        public string SelectedColor { set; get; }
    }
}