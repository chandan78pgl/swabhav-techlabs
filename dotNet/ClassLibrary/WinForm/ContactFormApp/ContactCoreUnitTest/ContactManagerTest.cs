using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContactCore;
using System.IO;
using System.Collections.Generic;

namespace ContactCoreUnitTest
{
    [TestClass]
    public class ContactManagerTest
    {
        ContactManager contactmanager = new ContactManager();

        [TestMethod]
        public void TestAddContactMethod()
        {
            contactmanager.AddContact("Foo", "8520963");
        }

        [TestMethod]
        public void TestContactsProperty()
        {
            Assert.AreNotEqual(0,contactmanager.Contacts.Count) ;
        }
    }
}
