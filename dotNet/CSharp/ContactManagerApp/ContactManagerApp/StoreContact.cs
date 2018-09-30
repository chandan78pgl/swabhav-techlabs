using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ContactManagerApp
{
    public abstract class StoreContact
    {
        public static void saveObjectToFile(List<Contact> contacts)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("D:\\local_repository\\dotNet\\CSharp\\ContactManagerApp\\ContactManagerApp\\Resources\\contacts.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, contacts);
            stream.Close();
        }

        public static List<Contact> getObjectFromFile()
        {
            List<Contact> contacts = new List<Contact>();

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("D:\\local_repository\\dotNet\\CSharp\\ContactManagerApp\\ContactManagerApp\\Resources\\contacts.txt", FileMode.Open, FileAccess.Read);

            contacts = (List<Contact>)formatter.Deserialize(stream);
            stream.Close();

            return contacts;
        }
    }
}
