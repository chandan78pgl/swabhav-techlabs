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
    public partial class FormTask : Form
    {
        public int index = 0;
        public FormTask()
        {
            InitializeComponent();
        }

        private void ShowTask(Object obj, EventArgs e)
        {
            if ((obj as Button).Name == "btnAdd")
            {
                string task = txtTask.Text;
                labelDisplay.Text = "Your task is " + task;
                listTask.Items.Add(task);
            }
        }

        private void DeleteTask(Object obj, EventArgs e)
        {
            listTask.Items.Remove(listTask.SelectedItem);
        }

        private void FormCloseEvent(object sender, FormClosedEventArgs e)
        {
            MenuParent.counter--;   
            MdiParent.Text="MenuParent - "+MenuParent.counter;
        }
    }
}
