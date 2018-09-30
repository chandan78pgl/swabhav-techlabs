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

namespace ContactFormApp
{
    public partial class ContactSearchForm : Form
    {
        private ContactManager _contactManager;
        public ContactSearchForm(ContactManager contactManager)
        {
            InitializeComponent();
            _contactManager = contactManager;
        }

        private void SearchResult(string contactName)
        {
            foreach (Contact contact in _contactManager.Contacts)
            {
                if (contact.Name.ToLower().Contains(contactName.ToLower()))
                {
                    contactSearchView.Rows.Add(contact.Name, contact.Number);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            contactSearchView.Rows.Clear();
            SearchResult(txtSearch.Text);
        }
    }
}
