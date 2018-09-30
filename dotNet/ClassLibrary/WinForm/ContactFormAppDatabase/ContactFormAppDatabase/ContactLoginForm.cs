using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using ContactCore;

namespace ContactFormAppDatabase
{
    public partial class ContactLoginForm : Form
    {
        private string _username;
        private string _password;
        private Form _parentForm;

        public ContactLoginForm(Form parent)
        {
            InitializeComponent();
            _parentForm = parent;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginService loginService = new LoginService();

            if (loginService.AuthenticateUser(txtUsername.Text,txtPassword.Text))
            {
                MenuStrip menuStrip = (MenuStrip)MdiParent.Controls["menuStrip1"];
                ToolStripMenuItem fileMenuItems = (ToolStripMenuItem)menuStrip.Items["fileToolStripMenuItem"];


                foreach (ToolStripItem item in fileMenuItems.DropDownItems)
                {
                    item.Enabled = true;
                }

                
                DialogResult result = MessageBox.Show("Login SuccessFull");
                if (result==DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Credentials");
            }
        }
    }
}
