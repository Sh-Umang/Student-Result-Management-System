namespace StudentResultManagementSystem
{
    partial class StudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSNSF = new System.Windows.Forms.TextBox();
            this.btnAddSF = new System.Windows.Forms.Button();
            this.gridViewSF = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFNSF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLNSF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailSF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddressSF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPNSF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ctxtGenderSF = new System.Windows.Forms.ComboBox();
            this.btnUpdateSF = new System.Windows.Forms.Button();
            this.btnDelSF = new System.Windows.Forms.Button();
            this.btnResetSF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSF)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Symbol No:";
            // 
            // txtSNSF
            // 
            this.txtSNSF.BackColor = System.Drawing.Color.SlateGray;
            this.txtSNSF.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSNSF.Location = new System.Drawing.Point(115, 25);
            this.txtSNSF.Name = "txtSNSF";
            this.txtSNSF.Size = new System.Drawing.Size(136, 22);
            this.txtSNSF.TabIndex = 1;
            // 
            // btnAddSF
            // 
            this.btnAddSF.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAddSF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSF.Location = new System.Drawing.Point(35, 168);
            this.btnAddSF.Name = "btnAddSF";
            this.btnAddSF.Size = new System.Drawing.Size(75, 27);
            this.btnAddSF.TabIndex = 2;
            this.btnAddSF.Text = "Add";
            this.btnAddSF.UseVisualStyleBackColor = false;
            this.btnAddSF.Click += new System.EventHandler(this.btnAddSF_Click);
            // 
            // gridViewSF
            // 
            this.gridViewSF.AllowUserToAddRows = false;
            this.gridViewSF.AllowUserToDeleteRows = false;
            this.gridViewSF.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.gridViewSF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewSF.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridViewSF.Location = new System.Drawing.Point(35, 213);
            this.gridViewSF.Name = "gridViewSF";
            this.gridViewSF.ReadOnly = true;
            this.gridViewSF.RowHeadersWidth = 51;
            this.gridViewSF.RowTemplate.Height = 24;
            this.gridViewSF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewSF.Size = new System.Drawing.Size(812, 273);
            this.gridViewSF.TabIndex = 3;
            this.gridViewSF.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewSF_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name:";
            // 
            // txtFNSF
            // 
            this.txtFNSF.BackColor = System.Drawing.Color.SlateGray;
            this.txtFNSF.ForeColor = System.Drawing.SystemColors.Window;
            this.txtFNSF.Location = new System.Drawing.Point(115, 64);
            this.txtFNSF.Name = "txtFNSF";
            this.txtFNSF.Size = new System.Drawing.Size(182, 22);
            this.txtFNSF.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name:";
            // 
            // txtLNSF
            // 
            this.txtLNSF.BackColor = System.Drawing.Color.SlateGray;
            this.txtLNSF.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLNSF.Location = new System.Drawing.Point(400, 64);
            this.txtLNSF.Name = "txtLNSF";
            this.txtLNSF.Size = new System.Drawing.Size(183, 22);
            this.txtLNSF.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email:";
            // 
            // txtEmailSF
            // 
            this.txtEmailSF.BackColor = System.Drawing.Color.SlateGray;
            this.txtEmailSF.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEmailSF.Location = new System.Drawing.Point(115, 102);
            this.txtEmailSF.Name = "txtEmailSF";
            this.txtEmailSF.Size = new System.Drawing.Size(182, 22);
            this.txtEmailSF.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(607, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address:";
            // 
            // txtAddressSF
            // 
            this.txtAddressSF.BackColor = System.Drawing.Color.SlateGray;
            this.txtAddressSF.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAddressSF.Location = new System.Drawing.Point(671, 102);
            this.txtAddressSF.Name = "txtAddressSF";
            this.txtAddressSF.Size = new System.Drawing.Size(176, 22);
            this.txtAddressSF.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phone No:";
            // 
            // txtPNSF
            // 
            this.txtPNSF.BackColor = System.Drawing.Color.SlateGray;
            this.txtPNSF.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPNSF.Location = new System.Drawing.Point(400, 102);
            this.txtPNSF.Name = "txtPNSF";
            this.txtPNSF.Size = new System.Drawing.Size(183, 22);
            this.txtPNSF.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(607, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gender:";
            // 
            // ctxtGenderSF
            // 
            this.ctxtGenderSF.BackColor = System.Drawing.Color.SlateGray;
            this.ctxtGenderSF.ForeColor = System.Drawing.SystemColors.Window;
            this.ctxtGenderSF.FormattingEnabled = true;
            this.ctxtGenderSF.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ctxtGenderSF.Location = new System.Drawing.Point(671, 64);
            this.ctxtGenderSF.Name = "ctxtGenderSF";
            this.ctxtGenderSF.Size = new System.Drawing.Size(139, 24);
            this.ctxtGenderSF.TabIndex = 4;
            // 
            // btnUpdateSF
            // 
            this.btnUpdateSF.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdateSF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateSF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateSF.Location = new System.Drawing.Point(149, 168);
            this.btnUpdateSF.Name = "btnUpdateSF";
            this.btnUpdateSF.Size = new System.Drawing.Size(75, 27);
            this.btnUpdateSF.TabIndex = 2;
            this.btnUpdateSF.Text = "Update";
            this.btnUpdateSF.UseVisualStyleBackColor = false;
            this.btnUpdateSF.Click += new System.EventHandler(this.btnUpdateSF_Click);
            // 
            // btnDelSF
            // 
            this.btnDelSF.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelSF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelSF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelSF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelSF.Location = new System.Drawing.Point(263, 168);
            this.btnDelSF.Name = "btnDelSF";
            this.btnDelSF.Size = new System.Drawing.Size(75, 27);
            this.btnDelSF.TabIndex = 2;
            this.btnDelSF.Text = "Delete";
            this.btnDelSF.UseVisualStyleBackColor = false;
            this.btnDelSF.Click += new System.EventHandler(this.btnDelSF_Click);
            // 
            // btnResetSF
            // 
            this.btnResetSF.BackColor = System.Drawing.Color.Gray;
            this.btnResetSF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResetSF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSF.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnResetSF.Location = new System.Drawing.Point(772, 168);
            this.btnResetSF.Name = "btnResetSF";
            this.btnResetSF.Size = new System.Drawing.Size(75, 27);
            this.btnResetSF.TabIndex = 2;
            this.btnResetSF.Text = "Reset";
            this.btnResetSF.UseVisualStyleBackColor = false;
            this.btnResetSF.Click += new System.EventHandler(this.btnResetSF_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 519);
            this.Controls.Add(this.ctxtGenderSF);
            this.Controls.Add(this.gridViewSF);
            this.Controls.Add(this.btnResetSF);
            this.Controls.Add(this.btnDelSF);
            this.Controls.Add(this.btnUpdateSF);
            this.Controls.Add(this.btnAddSF);
            this.Controls.Add(this.txtPNSF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLNSF);
            this.Controls.Add(this.txtAddressSF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFNSF);
            this.Controls.Add(this.txtEmailSF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSNSF);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSNSF;
        private System.Windows.Forms.Button btnAddSF;
        private System.Windows.Forms.DataGridView gridViewSF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFNSF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLNSF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailSF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddressSF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPNSF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ctxtGenderSF;
        private System.Windows.Forms.Button btnUpdateSF;
        private System.Windows.Forms.Button btnDelSF;
        private System.Windows.Forms.Button btnResetSF;
    }
}