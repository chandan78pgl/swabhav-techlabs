using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleApp
{
    public class Rectangle
    {
        private int _height = 1;
        private int _width = 1;
        private string _color = "No_Color";

        public Rectangle()
        {
            Console.WriteLine("Object Created.");
        }

        public Int32 Height
        {
            get
            {
                return this._height;
            }

            set
            {
                this._height = Validate(value);
            }
        }

        public Int32 Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = Validate(value);
            }
        }

        public Int32 CalculateArea()
        {
            return Width * Height;
        }

        public String Color
        {
            get
            {
                return this._color;
            }
            set
            {
                if (value.Equals("red") || value.Equals("blue") || value.Equals("green"))
                {
                    this._color = value;
                }
            }
        }

        private int Validate(int dimension)
        {
            if (dimension<1)
            {
                dimension = 1;
            }
            else if(dimension>100)
            {
                dimension = 100;
            }
            return dimension;
        }

        public override string ToString()
        {
            return "Rectangle Height= "+Height+" Width= "+Width+" Color="+Color;
        }
    }
}