using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ContactCore;

namespace ContactCoreUnitTest
{
    [TestClass]
    public class StoreDataTest
    {
        List<Contact> contactlist = new List<Contact>();
        

        [TestMethod]
        public void TestSaveObjectToFileMethod()
        {
            contactlist.Add(new Contact("Chandan", "850741074"));
            StoreContact.saveObjectToFile(contactlist);
        }

        [TestMethod]
        public void TestGetObjectFromFileMethod()
        {
            StoreContact.getObjectFromFile();
        }
    }
}
