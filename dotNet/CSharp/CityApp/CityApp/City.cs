using System;
using System.Collections.Generic;
using System.Text;

namespace CityApp
{
    class City
    {
        private string _cityCode;
        private string _cityDescription;

        public City(string cityCode,string cityDescription)
        {
            this._cityCode = cityCode;
            this._cityDescription = cityDescription;
        }

        public String CityCode
        {
            get
            {
                return _cityCode;
            }
        }

        public String CityDescription
        {
            get
            {
                return _cityDescription;
            }
        }

        public override string ToString()
        {
            return "CityCode: " + this.CityCode
                +"\nCityDescription: "+this.CityDescription;
        }
    }
}
