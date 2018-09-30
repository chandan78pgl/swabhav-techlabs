using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace ConsoleWinFormApp
{
    public class WelcomeForm:Form
    {
        public WelcomeForm()
        {  
            this.Text = "Welcome Form";
            this.Size=new System.Drawing.Size(1024,768);

            Button RedButton = new Button();
            RedButton.Text = "Click Here for Red Color";
            RedButton.Size = new System.Drawing.Size(100, 100);
            RedButton.Location = new System.Drawing.Point((this.Width - RedButton.Width) / 2);
            RedButton.Name = "red";
            RedButton.Click += new EventHandler(ChangeColor);

            Button BlueButton = new Button();
            BlueButton.Text = "Click Here for Blue Color";
            BlueButton.Size = new System.Drawing.Size(100, 100);
            BlueButton.Location = new System.Drawing.Point((this.Width-BlueButton.Width)/2,100);
            BlueButton.Name = "blue";
            BlueButton.Click += new EventHandler(ChangeColor);
            

            this.Controls.Add(RedButton);
            this.Controls.Add(BlueButton);

            Console.WriteLine(RedButton.Name);
        }

        public void ChangeToRedColor(Object obj,EventArgs e)
        {
            this.BackColor=System.Drawing.Color.Red;
        }

        public void ChangeToBlueColor(Object obj,EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Blue;
        }

        public void ChangeColor(Object obj, EventArgs e)
        {
            if((obj as Button).Name == "red")
            {
                this.BackColor = System.Drawing.Color.Red;
            }
            else if((obj as Button).Name == "blue")
            {
                this.BackColor = System.Drawing.Color.Blue;
            }
        }

    }
}
