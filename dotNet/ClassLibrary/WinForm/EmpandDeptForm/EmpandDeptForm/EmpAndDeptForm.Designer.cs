namespace EmpandDeptForm
{
    partial class EmpAndDeptForm
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
            this.btnEmpShow = new System.Windows.Forms.Button();
            this.btnDeptShow = new System.Windows.Forms.Button();
            this.empDataGridView = new System.Windows.Forms.DataGridView();
            this.deptDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.empDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmpShow
            // 
            this.btnEmpShow.Location = new System.Drawing.Point(122, 30);
            this.btnEmpShow.Name = "btnEmpShow";
            this.btnEmpShow.Size = new System.Drawing.Size(75, 23);
            this.btnEmpShow.TabIndex = 0;
            this.btnEmpShow.Text = "Display Emp";
            this.btnEmpShow.UseVisualStyleBackColor = true;
            this.btnEmpShow.Click += new System.EventHandler(this.btnEmpShow_Click);
            // 
            // btnDeptShow
            // 
            this.btnDeptShow.Location = new System.Drawing.Point(460, 30);
            this.btnDeptShow.Name = "btnDeptShow";
            this.btnDeptShow.Size = new System.Drawing.Size(75, 23);
            this.btnDeptShow.TabIndex = 1;
            this.btnDeptShow.Text = "Display Dept";
            this.btnDeptShow.UseVisualStyleBackColor = true;
            this.btnDeptShow.Click += new System.EventHandler(this.btnDeptShow_Click);
            // 
            // empDataGridView
            // 
            this.empDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empDataGridView.Location = new System.Drawing.Point(42, 70);
            this.empDataGridView.Name = "empDataGridView";
            this.empDataGridView.Size = new System.Drawing.Size(240, 150);
            this.empDataGridView.TabIndex = 2;
            // 
            // deptDataGridView
            // 
            this.deptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deptDataGridView.Location = new System.Drawing.Point(373, 70);
            this.deptDataGridView.Name = "deptDataGridView";
            this.deptDataGridView.Size = new System.Drawing.Size(240, 150);
            this.deptDataGridView.TabIndex = 3;
            // 
            // EmpAndDeptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 261);
            this.Controls.Add(this.deptDataGridView);
            this.Controls.Add(this.empDataGridView);
            this.Controls.Add(this.btnDeptShow);
            this.Controls.Add(this.btnEmpShow);
            this.Name = "EmpAndDeptForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.empDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpShow;
        private System.Windows.Forms.Button btnDeptShow;
        private System.Windows.Forms.DataGridView empDataGridView;
        private System.Windows.Forms.DataGridView deptDataGridView;
    }
}

