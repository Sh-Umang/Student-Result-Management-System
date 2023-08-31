namespace StudentResultManagementSystem
{
    partial class SubjectForm
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
            this.txtIDSubF = new System.Windows.Forms.TextBox();
            this.btnAddSubF = new System.Windows.Forms.Button();
            this.gridViewSubF = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameSubF = new System.Windows.Forms.TextBox();
            this.btnUpdateSubF = new System.Windows.Forms.Button();
            this.btnDelSubF = new System.Windows.Forms.Button();
            this.btnResetSubF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSubF)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject ID:";
            // 
            // txtIDSubF
            // 
            this.txtIDSubF.Location = new System.Drawing.Point(108, 21);
            this.txtIDSubF.Name = "txtIDSubF";
            this.txtIDSubF.Size = new System.Drawing.Size(100, 22);
            this.txtIDSubF.TabIndex = 1;
            // 
            // btnAddSubF
            // 
            this.btnAddSubF.Location = new System.Drawing.Point(34, 96);
            this.btnAddSubF.Name = "btnAddSubF";
            this.btnAddSubF.Size = new System.Drawing.Size(75, 23);
            this.btnAddSubF.TabIndex = 2;
            this.btnAddSubF.Text = "Add";
            this.btnAddSubF.UseVisualStyleBackColor = true;
            this.btnAddSubF.Click += new System.EventHandler(this.btnAddSubF_Click);
            // 
            // gridViewSubF
            // 
            this.gridViewSubF.AllowUserToAddRows = false;
            this.gridViewSubF.AllowUserToDeleteRows = false;
            this.gridViewSubF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewSubF.Location = new System.Drawing.Point(32, 170);
            this.gridViewSubF.Name = "gridViewSubF";
            this.gridViewSubF.ReadOnly = true;
            this.gridViewSubF.RowHeadersWidth = 51;
            this.gridViewSubF.RowTemplate.Height = 24;
            this.gridViewSubF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewSubF.Size = new System.Drawing.Size(736, 245);
            this.gridViewSubF.TabIndex = 3;
            this.gridViewSubF.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewSubF_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Subject Name:";
            // 
            // txtNameSubF
            // 
            this.txtNameSubF.Location = new System.Drawing.Point(352, 21);
            this.txtNameSubF.Name = "txtNameSubF";
            this.txtNameSubF.Size = new System.Drawing.Size(197, 22);
            this.txtNameSubF.TabIndex = 1;
            // 
            // btnUpdateSubF
            // 
            this.btnUpdateSubF.Location = new System.Drawing.Point(133, 96);
            this.btnUpdateSubF.Name = "btnUpdateSubF";
            this.btnUpdateSubF.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSubF.TabIndex = 2;
            this.btnUpdateSubF.Text = "Update";
            this.btnUpdateSubF.UseVisualStyleBackColor = true;
            this.btnUpdateSubF.Click += new System.EventHandler(this.btnUpdateSubF_Click);
            // 
            // btnDelSubF
            // 
            this.btnDelSubF.Location = new System.Drawing.Point(233, 96);
            this.btnDelSubF.Name = "btnDelSubF";
            this.btnDelSubF.Size = new System.Drawing.Size(75, 23);
            this.btnDelSubF.TabIndex = 2;
            this.btnDelSubF.Text = "Delete";
            this.btnDelSubF.UseVisualStyleBackColor = true;
            this.btnDelSubF.Click += new System.EventHandler(this.btnDelSubF_Click);
            // 
            // btnResetSubF
            // 
            this.btnResetSubF.Location = new System.Drawing.Point(693, 96);
            this.btnResetSubF.Name = "btnResetSubF";
            this.btnResetSubF.Size = new System.Drawing.Size(75, 23);
            this.btnResetSubF.TabIndex = 2;
            this.btnResetSubF.Text = "Reset";
            this.btnResetSubF.UseVisualStyleBackColor = true;
            this.btnResetSubF.Click += new System.EventHandler(this.btnResetSubF_Click);
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridViewSubF);
            this.Controls.Add(this.btnResetSubF);
            this.Controls.Add(this.btnDelSubF);
            this.Controls.Add(this.btnUpdateSubF);
            this.Controls.Add(this.btnAddSubF);
            this.Controls.Add(this.txtNameSubF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDSubF);
            this.Controls.Add(this.label1);
            this.Name = "SubjectForm";
            this.Text = "Subject Form";
            this.Load += new System.EventHandler(this.SubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSubF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDSubF;
        private System.Windows.Forms.Button btnAddSubF;
        private System.Windows.Forms.DataGridView gridViewSubF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameSubF;
        private System.Windows.Forms.Button btnUpdateSubF;
        private System.Windows.Forms.Button btnDelSubF;
        private System.Windows.Forms.Button btnResetSubF;
    }
}