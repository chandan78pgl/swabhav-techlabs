using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm2App
{
    public partial class MenuParent : Form
    {
        public static int counter = 0;
        public static int formCount = 0;
        public MenuParent()
        {
            InitializeComponent();
        }

        private void taskFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                formCount = 0;
            }

            counter++;
            formCount++;
            FormTask formTask = new FormTask();
            formTask.MdiParent = this;

            formTask.Text = "TaskForm - " + formCount;
            Text = "MenuParent - " + counter;
            
            formTask.Show();
        }
    }
}
