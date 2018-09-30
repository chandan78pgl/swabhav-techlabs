using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanApp
{
    class Human
    {
        private string _name;
        private int _age;
        private float _height = 5.0f;
        private float _weight = 40.0f;
        private GenderType _gender;

        public Human(string name,int age,float height,float weight,GenderType gender):this(name,gender,age)
        {
            _height = height;
            _weight = weight;
        }

        public Human(string name, GenderType gender, int age)
        {
            _name = name;
            _gender = gender;
            _age = age;
        }

        public String Name
        {
            get
            {
                return _name;
            }
        }

        public Int32 Age
        {
            get
            {
                return _age;
            }
        }

        public float Height
        {
            get
            {
                return _height;
            }
        }

        public float Weight
        {
            get
            {
                return _weight;
            }
        }

        public GenderType Gender
        {
            get
            {
                return _gender;
            }
        }

        public void eat()
        {
            _weight += 2f;
        }

        public void workout()
        {
            _height += 0.1f;
            _weight -= 1f;
        }

        private float CalculateBMI()
        {
            float hei = _height * 0.3048f;
            float wei = _weight;
            float bmi = wei / (hei * hei);

            return bmi;
        }

        public String HealthRecommendation()
        {
            float result = CalculateBMI();
            Console.WriteLine("Your BMI is: {0}",result);

            if (result<18.5f)
            {
                return "UNDERWEIGHT";
            }
            else if(result>24.0f)
            {
                return "OVERWEIGHT";
            }

            return "NORMAL";
        }

        public override string ToString()
        {
            return "Name: "+Name
                +"\n Age: "+Age
                + "\n Gender: " + Gender
                + "\n Height: " + Height
                + "\n Weight: " + Weight
                +"\n BMI: "+CalculateBMI()
                + "\n Your Health is - " + HealthRecommendation();
        }
    }
}
