namespace WookieTablas
{
    partial class Species
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
            this.sdstxtDescSpecie = new SdsTexBox.SdsTexBox();
            this.sdstxtCodeSpecie = new SdsTexBox.SdsTexBox();
            this.labDescSpecie = new System.Windows.Forms.Label();
            this.labCodeSpecie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(154, 401);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(65, 401);
            // 
            // sdstxtDescSpecie
            // 
            this.sdstxtDescSpecie.BackColor = System.Drawing.Color.LightGreen;
            this.sdstxtDescSpecie.CodeSector = null;
            this.sdstxtDescSpecie.ColumnName = "DescSpecie";
            this.sdstxtDescSpecie.DescCodi = null;
            this.sdstxtDescSpecie.Location = new System.Drawing.Point(154, 263);
            this.sdstxtDescSpecie.Name = "sdstxtDescSpecie";
            this.sdstxtDescSpecie.Nom = null;
            this.sdstxtDescSpecie.NomBBDD = "SecureCore";
            this.sdstxtDescSpecie.NomCamp = null;
            this.sdstxtDescSpecie.NomControl = null;
            this.sdstxtDescSpecie.NomTaula = "Species";
            this.sdstxtDescSpecie.Requerit = false;
            this.sdstxtDescSpecie.SiEsForana = false;
            this.sdstxtDescSpecie.Size = new System.Drawing.Size(100, 20);
            this.sdstxtDescSpecie.TabIndex = 41;
            // 
            // sdstxtCodeSpecie
            // 
            this.sdstxtCodeSpecie.BackColor = System.Drawing.Color.LightGreen;
            this.sdstxtCodeSpecie.CodeSector = null;
            this.sdstxtCodeSpecie.ColumnName = "CodeSpecie";
            this.sdstxtCodeSpecie.DescCodi = null;
            this.sdstxtCodeSpecie.Location = new System.Drawing.Point(154, 211);
            this.sdstxtCodeSpecie.Name = "sdstxtCodeSpecie";
            this.sdstxtCodeSpecie.Nom = null;
            this.sdstxtCodeSpecie.NomBBDD = "SecureCore";
            this.sdstxtCodeSpecie.NomCamp = null;
            this.sdstxtCodeSpecie.NomControl = null;
            this.sdstxtCodeSpecie.NomTaula = "Species";
            this.sdstxtCodeSpecie.Requerit = false;
            this.sdstxtCodeSpecie.SiEsForana = false;
            this.sdstxtCodeSpecie.Size = new System.Drawing.Size(100, 20);
            this.sdstxtCodeSpecie.TabIndex = 42;
            // 
            // labDescSpecie
            // 
            this.labDescSpecie.AutoSize = true;
            this.labDescSpecie.Location = new System.Drawing.Point(65, 266);
            this.labDescSpecie.Name = "labDescSpecie";
            this.labDescSpecie.Size = new System.Drawing.Size(65, 13);
            this.labDescSpecie.TabIndex = 44;
            this.labDescSpecie.Text = "DescSpecie";
            // 
            // labCodeSpecie
            // 
            this.labCodeSpecie.AutoSize = true;
            this.labCodeSpecie.Location = new System.Drawing.Point(65, 214);
            this.labCodeSpecie.Name = "labCodeSpecie";
            this.labCodeSpecie.Size = new System.Drawing.Size(65, 13);
            this.labCodeSpecie.TabIndex = 43;
            this.labCodeSpecie.Text = "CodeSpecie";
            // 
            // Species
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 532);
            this.Controls.Add(this.sdstxtDescSpecie);
            this.Controls.Add(this.sdstxtCodeSpecie);
            this.Controls.Add(this.labDescSpecie);
            this.Controls.Add(this.labCodeSpecie);
            this.Name = "Species";
            this.Text = "Species";
            this.Load += new System.EventHandler(this.Species_Load);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.labCodeSpecie, 0);
            this.Controls.SetChildIndex(this.labDescSpecie, 0);
            this.Controls.SetChildIndex(this.sdstxtCodeSpecie, 0);
            this.Controls.SetChildIndex(this.sdstxtDescSpecie, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private SdsTexBox.SdsTexBox sdstxtDescSpecie;
        private SdsTexBox.SdsTexBox sdstxtCodeSpecie;
        private System.Windows.Forms.Label labDescSpecie;
        private System.Windows.Forms.Label labCodeSpecie;
    }
}