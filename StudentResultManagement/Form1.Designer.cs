namespace StudentResultManagementSystem
{
    partial class Form1
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
            this.gridViewMain = new System.Windows.Forms.DataGridView();
            this.btnStdMF = new System.Windows.Forms.Button();
            this.btnSubMF = new System.Windows.Forms.Button();
            this.btnResultMF = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewMain
            // 
            this.gridViewMain.AllowUserToAddRows = false;
            this.gridViewMain.AllowUserToDeleteRows = false;
            this.gridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewMain.Location = new System.Drawing.Point(68, 168);
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.ReadOnly = true;
            this.gridViewMain.RowHeadersWidth = 51;
            this.gridViewMain.RowTemplate.Height = 24;
            this.gridViewMain.Size = new System.Drawing.Size(851, 308);
            this.gridViewMain.TabIndex = 0;
            this.gridViewMain.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridViewMain_ColumnHeaderMouseDoubleClick);
            // 
            // btnStdMF
            // 
            this.btnStdMF.Location = new System.Drawing.Point(68, 94);
            this.btnStdMF.Name = "btnStdMF";
            this.btnStdMF.Size = new System.Drawing.Size(140, 23);
            this.btnStdMF.TabIndex = 1;
            this.btnStdMF.Text = "Modify Student";
            this.btnStdMF.UseVisualStyleBackColor = true;
            this.btnStdMF.Click += new System.EventHandler(this.btnStdMF_Click);
            // 
            // btnSubMF
            // 
            this.btnSubMF.Location = new System.Drawing.Point(236, 94);
            this.btnSubMF.Name = "btnSubMF";
            this.btnSubMF.Size = new System.Drawing.Size(140, 23);
            this.btnSubMF.TabIndex = 1;
            this.btnSubMF.Text = "Modify Subject";
            this.btnSubMF.UseVisualStyleBackColor = true;
            this.btnSubMF.Click += new System.EventHandler(this.btnSubMF_Click);
            // 
            // btnResultMF
            // 
            this.btnResultMF.Location = new System.Drawing.Point(404, 94);
            this.btnResultMF.Name = "btnResultMF";
            this.btnResultMF.Size = new System.Drawing.Size(140, 23);
            this.btnResultMF.TabIndex = 1;
            this.btnResultMF.Text = "Modify Result";
            this.btnResultMF.UseVisualStyleBackColor = true;
            this.btnResultMF.Click += new System.EventHandler(this.btnResultMF_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(844, 94);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 2;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 533);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.btnResultMF);
            this.Controls.Add(this.btnSubMF);
            this.Controls.Add(this.btnStdMF);
            this.Controls.Add(this.gridViewMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewMain;
        private System.Windows.Forms.Button btnStdMF;
        private System.Windows.Forms.Button btnSubMF;
        private System.Windows.Forms.Button btnResultMF;
        private System.Windows.Forms.Button Refresh;
    }
}

