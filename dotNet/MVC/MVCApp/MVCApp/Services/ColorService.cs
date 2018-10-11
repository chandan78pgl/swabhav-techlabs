using MVCApp.Models.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Services
{
    public class ColorService
    {
        private List<ProColor> _proColors;

        public ColorService()
        {
            _proColors = new List<ProColor>();
            _proColors.Add(new ProColor { Name = "RED", HexCode = "#FF0000" });
            _proColors.Add(new ProColor { Name = "BLUE", HexCode = "#0000FF" });
            _proColors.Add(new ProColor { Name = "GREEN", HexCode = "#00FF00" });
        }

        public List<ProColor> Colors
        {
            get
            {
                return _proColors;
            }
        }

        public Int32 Count
        {
            get
            {
                return _proColors.Count;
            }
        }

        public ProColor SearchColor(string colorCode)
        {
            foreach (ProColor color in _proColors)
            {
                if (color.HexCode==colorCode)
                {
                    return color;
                }
            }
            return null;
        }
    }
}