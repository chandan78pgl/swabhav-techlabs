namespace WinForm2App
{
    partial class FormTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTask = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.listTask = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(39, 54);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(31, 13);
            this.labelTask.TabIndex = 0;
            this.labelTask.Text = "Task";
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(80, 51);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(120, 20);
            this.txtTask.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(206, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 26);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ShowTask);
            // 
            // labelDisplay
            // 
            this.labelDisplay.AutoSize = true;
            this.labelDisplay.Location = new System.Drawing.Point(83, 87);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(68, 13);
            this.labelDisplay.TabIndex = 3;
            this.labelDisplay.Text = "Display Task";
            this.labelDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listTask
            // 
            this.listTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listTask.FormattingEnabled = true;
            this.listTask.Location = new System.Drawing.Point(80, 115);
            this.listTask.Name = "listTask";
            this.listTask.Size = new System.Drawing.Size(120, 95);
            this.listTask.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(80, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Task";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.DeleteTask);
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listTask);
            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.labelTask);
            this.Name = "FormTask";
            this.Text = "Task Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCloseEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelDisplay;
        private System.Windows.Forms.ListBox listTask;
        private System.Windows.Forms.Button btnDelete;
    }
}