using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsApp
{
    class LineItem
    {
        private int _id;
        private string _name;
        private int _quantity;
        private double _price;

        public LineItem(int id,string name,int quantity,double price)
        {
            _id = id;
            _name = name;
            _quantity = quantity;
            _price = price;
        }

        public Double TotalCost()
        {
            return _price * _quantity;
        }
    }
}
