namespace WookieTablas
{
    partial class UserCategories
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
            this.labAccessLevel = new System.Windows.Forms.Label();
            this.sdstxtAccessLevel = new SdsTexBox.SdsTexBox();
            this.sdstxtDescCategory = new SdsTexBox.SdsTexBox();
            this.sdstxtCodeCategory = new SdsTexBox.SdsTexBox();
            this.labDescCategory = new System.Windows.Forms.Label();
            this.labCodeCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(155, 439);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(65, 438);
            // 
            // labAccessLevel
            // 
            this.labAccessLevel.AutoSize = true;
            this.labAccessLevel.Location = new System.Drawing.Point(55, 265);
            this.labAccessLevel.Name = "labAccessLevel";
            this.labAccessLevel.Size = new System.Drawing.Size(68, 13);
            this.labAccessLevel.TabIndex = 36;
            this.labAccessLevel.Text = "AccessLevel";
            // 
            // sdstxtAccessLevel
            // 
            this.sdstxtAccessLevel.BackColor = System.Drawing.Color.LightGreen;
            this.sdstxtAccessLevel.CodeSector = null;
            this.sdstxtAccessLevel.ColumnName = "AccessLevel";
            this.sdstxtAccessLevel.DescCodi = null;
            this.sdstxtAccessLevel.Location = new System.Drawing.Point(144, 262);
            this.sdstxtAccessLevel.Name = "sdstxtAccessLevel";
            this.sdstxtAccessLevel.Nom = null;
            this.sdstxtAccessLevel.NomBBDD = "SecureCore";
            this.sdstxtAccessLevel.NomCamp = null;
            this.sdstxtAccessLevel.NomControl = null;
            this.sdstxtAccessLevel.NomTaula = "UserCategories";
            this.sdstxtAccessLevel.Requerit = false;
            this.sdstxtAccessLevel.SiEsForana = false;
            this.sdstxtAccessLevel.Size = new System.Drawing.Size(100, 20);
            this.sdstxtAccessLevel.TabIndex = 35;
            // 
            // sdstxtDescCategory
            // 
            this.sdstxtDescCategory.BackColor = System.Drawing.Color.LightGreen;
            this.sdstxtDescCategory.CodeSector = null;
            this.sdstxtDescCategory.ColumnName = "DescCategory";
            this.sdstxtDescCategory.DescCodi = null;
            this.sdstxtDescCategory.Location = new System.Drawing.Point(144, 220);
            this.sdstxtDescCategory.Name = "sdstxtDescCategory";
            this.sdstxtDescCategory.Nom = null;
            this.sdstxtDescCategory.NomBBDD = "SecureCore";
            this.sdstxtDescCategory.NomCamp = null;
            this.sdstxtDescCategory.NomControl = null;
            this.sdstxtDescCategory.NomTaula = "UserCategories";
            this.sdstxtDescCategory.Requerit = false;
            this.sdstxtDescCategory.SiEsForana = false;
            this.sdstxtDescCategory.Size = new System.Drawing.Size(100, 20);
            this.sdstxtDescCategory.TabIndex = 31;
            // 
            // sdstxtCodeCategory
            // 
            this.sdstxtCodeCategory.BackColor = System.Drawing.Color.LightGreen;
            this.sdstxtCodeCategory.CodeSector = null;
            this.sdstxtCodeCategory.ColumnName = "CodeCategory";
            this.sdstxtCodeCategory.DescCodi = null;
            this.sdstxtCodeCategory.Location = new System.Drawing.Point(144, 168);
            this.sdstxtCodeCategory.Name = "sdstxtCodeCategory";
            this.sdstxtCodeCategory.Nom = null;
            this.sdstxtCodeCategory.NomBBDD = "SecureCore";
            this.sdstxtCodeCategory.NomCamp = null;
            this.sdstxtCodeCategory.NomControl = null;
            this.sdstxtCodeCategory.NomTaula = "UserCategories";
            this.sdstxtCodeCategory.Requerit = false;
            this.sdstxtCodeCategory.SiEsForana = false;
            this.sdstxtCodeCategory.Size = new System.Drawing.Size(100, 20);
            this.sdstxtCodeCategory.TabIndex = 32;
            // 
            // labDescCategory
            // 
            this.labDescCategory.AutoSize = true;
            this.labDescCategory.Location = new System.Drawing.Point(55, 223);
            this.labDescCategory.Name = "labDescCategory";
            this.labDescCategory.Size = new System.Drawing.Size(74, 13);
            this.labDescCategory.TabIndex = 34;
            this.labDescCategory.Text = "DescCategory";
            // 
            // labCodeCategory
            // 
            this.labCodeCategory.AutoSize = true;
            this.labCodeCategory.Location = new System.Drawing.Point(55, 171);
            this.labCodeCategory.Name = "labCodeCategory";
            this.labCodeCategory.Size = new System.Drawing.Size(74, 13);
            this.labCodeCategory.TabIndex = 33;
            this.labCodeCategory.Text = "CodeCategory";
            // 
            // UserCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.labAccessLevel);
            this.Controls.Add(this.sdstxtAccessLevel);
            this.Controls.Add(this.sdstxtDescCategory);
            this.Controls.Add(this.sdstxtCodeCategory);
            this.Controls.Add(this.labDescCategory);
            this.Controls.Add(this.labCodeCategory);
            this.Name = "UserCategories";
            this.Text = "UserCategories";
            this.Load += new System.EventHandler(this.UserCategories_Load);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.labCodeCategory, 0);
            this.Controls.SetChildIndex(this.labDescCategory, 0);
            this.Controls.SetChildIndex(this.sdstxtCodeCategory, 0);
            this.Controls.SetChildIndex(this.sdstxtDescCategory, 0);
            this.Controls.SetChildIndex(this.sdstxtAccessLevel, 0);
            this.Controls.SetChildIndex(this.labAccessLevel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAccessLevel;
        private SdsTexBox.SdsTexBox sdstxtAccessLevel;
        private SdsTexBox.SdsTexBox sdstxtDescCategory;
        private SdsTexBox.SdsTexBox sdstxtCodeCategory;
        private System.Windows.Forms.Label labDescCategory;
        private System.Windows.Forms.Label labCodeCategory;
    }
}