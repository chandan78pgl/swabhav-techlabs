using System;
using System.Collections.Generic;
using System.Text;

namespace CircleApp
{
    class Circle
    {
        private float _radius;
        private BorderType _borderStyle;

        public Circle(float radius,BorderType borderStyle)
        {
            this._radius = radius;
            this._borderStyle = borderStyle;
        }

        public float Radius
        {
            get
            {
                return _radius;
            }
        }

        public BorderType BorderStyle
        {
            get
            {
                return _borderStyle;
            }
        }

        public float Area()
        {
            return (float)(2 * Math.PI * Radius * Radius);
        }

        public override string ToString()
        {
            return "Area: "+Area()
                +"\nStyle: "+BorderStyle;
        }
    }
}
