using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactCore;

namespace ContactFormAppDatabase
{
    public partial class ContactDisplayForm : Form
    {
        private ContactManager _contactManager;
        public ContactDisplayForm(ContactManager contactManager)
        {
            InitializeComponent();
            _contactManager = contactManager;
        }

        public void DisplayContact()
        {
            foreach(Contact contact in _contactManager.Contacts)
            {
                contactGridView.Rows.Add(contact.Name,contact.Number);
            }      
        }
    }
}
