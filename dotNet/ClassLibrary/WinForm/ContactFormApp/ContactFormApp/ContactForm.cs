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
    public partial class ContactForm : Form
    {
        private ContactManager _contactManager;
        public ContactForm()
        {
            InitializeComponent();
            _contactManager = new ContactManager();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactAddForm addContactForm = new ContactAddForm(_contactManager);
            addContactForm.MdiParent = this;
            addContactForm.WindowState= FormWindowState.Maximized;
            addContactForm.Show();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactDisplayForm contactDisplayForm = new ContactDisplayForm(_contactManager);
            contactDisplayForm.MdiParent = this;
            contactDisplayForm.DisplayContact();
            contactDisplayForm.WindowState= FormWindowState.Maximized;
            contactDisplayForm.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactSearchForm contactSearchForm = new ContactSearchForm(_contactManager);
            contactSearchForm.MdiParent = this;
            contactSearchForm.WindowState= FormWindowState.Maximized;
            contactSearchForm.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactLoginForm contactLoginForm = new ContactLoginForm(this);
            contactLoginForm.MdiParent = this;
            contactLoginForm.WindowState = FormWindowState.Maximized;
            contactLoginForm.Show();
        }
    }
}
