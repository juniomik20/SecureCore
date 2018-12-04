namespace WookieTablas
{
    partial class SpaceShipCategories
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
            this.txtBoxDescSpaceShipCategory = new SdsTexBox.SdsTexBox();
            this.txtBoxCodeSpaceShipCategories = new SdsTexBox.SdsTexBox();
            this.labSpaceShipCategory = new System.Windows.Forms.Label();
            this.labDescSpaceShipCategories = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxDescSpaceShipCategory
            // 
            this.txtBoxDescSpaceShipCategory.CodeSector = null;
            this.txtBoxDescSpaceShipCategory.ColumnName = "DescSpaceShipCategory";
            this.txtBoxDescSpaceShipCategory.DescCodi = null;
            this.txtBoxDescSpaceShipCategory.Location = new System.Drawing.Point(190, 261);
            this.txtBoxDescSpaceShipCategory.Name = "txtBoxDescSpaceShipCategory";
            this.txtBoxDescSpaceShipCategory.Nom = null;
            this.txtBoxDescSpaceShipCategory.NomBBDD = "SecureCore";
            this.txtBoxDescSpaceShipCategory.NomCamp = null;
            this.txtBoxDescSpaceShipCategory.NomControl = null;
            this.txtBoxDescSpaceShipCategory.NomTaula = "SpaceShipCategories";
            this.txtBoxDescSpaceShipCategory.Requerit = false;
            this.txtBoxDescSpaceShipCategory.SiEsForana = false;
            this.txtBoxDescSpaceShipCategory.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDescSpaceShipCategory.TabIndex = 26;
            // 
            // txtBoxCodeSpaceShipCategories
            // 
            this.txtBoxCodeSpaceShipCategories.CodeSector = null;
            this.txtBoxCodeSpaceShipCategories.ColumnName = "CodeSpaceShipCategory";
            this.txtBoxCodeSpaceShipCategories.DescCodi = null;
            this.txtBoxCodeSpaceShipCategories.Location = new System.Drawing.Point(190, 205);
            this.txtBoxCodeSpaceShipCategories.Name = "txtBoxCodeSpaceShipCategories";
            this.txtBoxCodeSpaceShipCategories.Nom = null;
            this.txtBoxCodeSpaceShipCategories.NomBBDD = "SecureCore";
            this.txtBoxCodeSpaceShipCategories.NomCamp = null;
            this.txtBoxCodeSpaceShipCategories.NomControl = null;
            this.txtBoxCodeSpaceShipCategories.NomTaula = "SpaceShipCategories";
            this.txtBoxCodeSpaceShipCategories.Requerit = false;
            this.txtBoxCodeSpaceShipCategories.SiEsForana = false;
            this.txtBoxCodeSpaceShipCategories.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCodeSpaceShipCategories.TabIndex = 27;
            // 
            // labSpaceShipCategory
            // 
            this.labSpaceShipCategory.AutoSize = true;
            this.labSpaceShipCategory.Location = new System.Drawing.Point(58, 208);
            this.labSpaceShipCategory.Name = "labSpaceShipCategory";
            this.labSpaceShipCategory.Size = new System.Drawing.Size(126, 13);
            this.labSpaceShipCategory.TabIndex = 29;
            this.labSpaceShipCategory.Text = "CodeSpaceShipCategory";
            // 
            // labDescSpaceShipCategories
            // 
            this.labDescSpaceShipCategories.AutoSize = true;
            this.labDescSpaceShipCategories.Location = new System.Drawing.Point(58, 261);
            this.labDescSpaceShipCategories.Name = "labDescSpaceShipCategories";
            this.labDescSpaceShipCategories.Size = new System.Drawing.Size(126, 13);
            this.labDescSpaceShipCategories.TabIndex = 30;
            this.labDescSpaceShipCategories.Text = "DescSpaceShipCategory";
            // 
            // SpaceShipCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 483);
            this.Controls.Add(this.labDescSpaceShipCategories);
            this.Controls.Add(this.labSpaceShipCategory);
            this.Controls.Add(this.txtBoxDescSpaceShipCategory);
            this.Controls.Add(this.txtBoxCodeSpaceShipCategories);
            this.Name = "SpaceShipCategories";
            this.Text = "SpaceShipCategories";
            this.Load += new System.EventHandler(this.SpaceShipCategories_Load);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.txtBoxCodeSpaceShipCategories, 0);
            this.Controls.SetChildIndex(this.txtBoxDescSpaceShipCategory, 0);
            this.Controls.SetChildIndex(this.labSpaceShipCategory, 0);
            this.Controls.SetChildIndex(this.labDescSpaceShipCategories, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SdsTexBox.SdsTexBox txtBoxDescSpaceShipCategory;
        private SdsTexBox.SdsTexBox txtBoxCodeSpaceShipCategories;
        private System.Windows.Forms.Label labSpaceShipCategory;
        private System.Windows.Forms.Label labDescSpaceShipCategories;
    }
}