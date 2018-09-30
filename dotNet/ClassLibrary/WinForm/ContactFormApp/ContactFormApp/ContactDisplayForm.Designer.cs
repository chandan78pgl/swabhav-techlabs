namespace ContactFormApp
{
    partial class ContactDisplayForm
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
            this.contactGridView = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contactGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contactGridView
            // 
            this.contactGridView.AllowUserToAddRows = false;
            this.contactGridView.AllowUserToDeleteRows = false;
            this.contactGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnNumber});
            this.contactGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactGridView.Location = new System.Drawing.Point(0, 0);
            this.contactGridView.Name = "contactGridView";
            this.contactGridView.ReadOnly = true;
            this.contactGridView.Size = new System.Drawing.Size(284, 261);
            this.contactGridView.TabIndex = 0;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnNumber
            // 
            this.columnNumber.HeaderText = "Number";
            this.columnNumber.Name = "columnNumber";
            this.columnNumber.ReadOnly = true;
            // 
            // ContactDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.contactGridView);
            this.Name = "ContactDisplayForm";
            this.Text = "ContactDisplayForm";
            ((System.ComponentModel.ISupportInitialize)(this.contactGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView contactGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumber;
    }
}