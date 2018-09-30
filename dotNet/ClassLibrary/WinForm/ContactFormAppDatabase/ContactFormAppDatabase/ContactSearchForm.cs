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
    public partial class ContactSearchForm : Form
    {
        private ContactManager _contactManager;
        public ContactSearchForm(ContactManager contactManager)
        {
            InitializeComponent();
            _contactManager = contactManager;
        }

        private void SearchResult(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
                contactSearchView.Rows.Add(contact.Name, contact.Number);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            contactSearchView.Rows.Clear();
            SearchResult(_contactManager.SearchContact(txtSearch.Text));
        }
    }
}
