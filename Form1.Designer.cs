
namespace CSharp_CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IDLabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Numberlabel = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.Newbtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Consultbtn = new System.Windows.Forms.Button();
            this.Displaybtn = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.Location = new System.Drawing.Point(134, 49);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(37, 25);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID:";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Namelabel.Location = new System.Drawing.Point(102, 88);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Namelabel.Size = new System.Drawing.Size(69, 25);
            this.Namelabel.TabIndex = 1;
            this.Namelabel.Text = "Name:";
            // 
            // Numberlabel
            // 
            this.Numberlabel.AutoSize = true;
            this.Numberlabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Numberlabel.Location = new System.Drawing.Point(79, 128);
            this.Numberlabel.Name = "Numberlabel";
            this.Numberlabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Numberlabel.Size = new System.Drawing.Size(92, 25);
            this.Numberlabel.TabIndex = 2;
            this.Numberlabel.Text = "Number:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(173, 46);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(202, 32);
            this.txtID.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(173, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 32);
            this.txtName.TabIndex = 4;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumber.Location = new System.Drawing.Point(173, 125);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(202, 32);
            this.txtNumber.TabIndex = 5;
            // 
            // Newbtn
            // 
            this.Newbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Newbtn.Location = new System.Drawing.Point(173, 173);
            this.Newbtn.Name = "Newbtn";
            this.Newbtn.Size = new System.Drawing.Size(115, 39);
            this.Newbtn.TabIndex = 6;
            this.Newbtn.Text = "New";
            this.Newbtn.UseVisualStyleBackColor = true;
            this.Newbtn.Click += new System.EventHandler(this.Newbtn_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Editbtn.Location = new System.Drawing.Point(305, 173);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(115, 39);
            this.Editbtn.TabIndex = 7;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = true;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Deletebtn.Location = new System.Drawing.Point(437, 173);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(115, 39);
            this.Deletebtn.TabIndex = 8;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Consultbtn
            // 
            this.Consultbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Consultbtn.Location = new System.Drawing.Point(569, 173);
            this.Consultbtn.Name = "Consultbtn";
            this.Consultbtn.Size = new System.Drawing.Size(115, 39);
            this.Consultbtn.TabIndex = 9;
            this.Consultbtn.Text = "Consult";
            this.Consultbtn.UseVisualStyleBackColor = true;
            this.Consultbtn.Click += new System.EventHandler(this.Consultbtn_Click);
            // 
            // Displaybtn
            // 
            this.Displaybtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Displaybtn.Location = new System.Drawing.Point(702, 173);
            this.Displaybtn.Name = "Displaybtn";
            this.Displaybtn.Size = new System.Drawing.Size(115, 39);
            this.Displaybtn.TabIndex = 10;
            this.Displaybtn.Text = "Display";
            this.Displaybtn.UseVisualStyleBackColor = true;
            this.Displaybtn.Click += new System.EventHandler(this.Displaybtn_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(173, 228);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.Size = new System.Drawing.Size(644, 280);
            this.dgvData.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 590);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.Displaybtn);
            this.Controls.Add(this.Consultbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.Newbtn);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Numberlabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.IDLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Numberlabel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button Newbtn;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Consultbtn;
        private System.Windows.Forms.Button Displaybtn;
        private System.Windows.Forms.DataGridView dgvData;
    }
}

