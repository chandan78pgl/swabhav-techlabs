using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ContactCore
{
    public class FileStore
    {
        public static void saveObjectToFile(List<Contact> contacts)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("resources\\contacts.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, contacts);
            stream.Close();
        }

        public static List<Contact> getObjectFromFile()
        {
            List<Contact> contacts = new List<Contact>();

            IFormatter formatter = new BinaryFormatter();

            Stream stream=null;

            try
            {
                stream = new FileStream("resources\\contacts.txt", FileMode.Open, FileAccess.Read);
                contacts = (List<Contact>)formatter.Deserialize(stream);
            }
            catch (FileNotFoundException e)
            {
                stream = new FileStream("resources\\contacts.txt", FileMode.Create);
            }
            catch (SerializationException e)
            {
                throw new Exception("There is Nothing in the file");
            }
            finally
            {
                stream.Close();
            }
            return contacts;
        }
    }
}
