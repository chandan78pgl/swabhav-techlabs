using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace RectangleApp.TestReflection
{
    class RectangleReflection
    {
        static void Main(string[] args)
        {
            Type type = typeof(Rectangle);

            Console.WriteLine("Class: {0}",type.Name);
            Console.WriteLine("Class: {0}", type.Namespace);

            PropertyInfo[] propertyInfo = type.GetProperties();

            Console.WriteLine("list Of properties are: ");

            foreach(PropertyInfo pInfo in propertyInfo)
            {
                Console.WriteLine(pInfo.Name);
            }

            ConstructorInfo[] constructorInfo = type.GetConstructors();

            Console.WriteLine("List of Constructors are: ");

            foreach(ConstructorInfo cInfo in constructorInfo)
            {
                Console.WriteLine(cInfo.ReflectedType);
            }

            MethodInfo[] methodInfo = type.GetMethods();

            Console.WriteLine("List of Methods are: ");

            foreach (MethodInfo mInfo in methodInfo)
            {
                Console.WriteLine(mInfo.Name);
            }
        }
    }
}
