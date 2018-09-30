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
    public partial class ContactAddForm : Form
    {
        private ContactManager _contactManager;
        public ContactAddForm(ContactManager contactManager)
        {
            InitializeComponent();
            _contactManager = contactManager;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string number = txtNumber.Text;

            if (name != "" && number!="")
            {
                _contactManager.AddContact(name, number);
                labelStatus.Text = "Contact Added Successfully";
            }
            else
            {
                labelStatus.Text = "fill the Fields to add contact";
            }
            txtName.Text = "";
            txtNumber.Text = "";
        }
    }
}
