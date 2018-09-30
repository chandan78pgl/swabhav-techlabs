namespace ContactFormAppDatabase
{
    partial class ContactAddForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(30, 59);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(109, 31);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name - ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(168, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(278, 30);
            this.txtName.TabIndex = 1;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.Location = new System.Drawing.Point(30, 112);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(133, 31);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "Number - ";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(90, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(281, 47);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Contact";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(168, 115);
            this.txtNumber.Mask = "0000000000";
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(278, 30);
            this.txtNumber.TabIndex = 4;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(182, 25);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(91, 13);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Add New Contact";
            // 
            // ContactAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 261);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelName);
            this.Name = "ContactAddForm";
            this.Text = "ContactAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox txtNumber;
        private System.Windows.Forms.Label labelStatus;
    }
}