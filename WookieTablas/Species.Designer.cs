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
            this.sdsTextBoxCodeSpecie = new MantenimientoTest.SdsTextBox();
            this.sdsTextBoxDescSpecie = new MantenimientoTest.SdsTextBox();
            this.lblDescSpecie = new System.Windows.Forms.Label();
            this.lblCodeSpecie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sdsTextBoxCodeSpecie
            // 
            this.sdsTextBoxCodeSpecie.CodeSector = null;
            this.sdsTextBoxCodeSpecie.ColumnName = "CodeSpecie";
            this.sdsTextBoxCodeSpecie.DescCodi = null;
            this.sdsTextBoxCodeSpecie.Location = new System.Drawing.Point(192, 164);
            this.sdsTextBoxCodeSpecie.Name = "sdsTextBoxCodeSpecie";
            this.sdsTextBoxCodeSpecie.Nom = null;
            this.sdsTextBoxCodeSpecie.NomBBDD = "SecureCore";
            this.sdsTextBoxCodeSpecie.NomCamp = null;
            this.sdsTextBoxCodeSpecie.NomControl = null;
            this.sdsTextBoxCodeSpecie.NomTaula = "Species";
            this.sdsTextBoxCodeSpecie.Requerit = false;
            this.sdsTextBoxCodeSpecie.SiEsForana = false;
            this.sdsTextBoxCodeSpecie.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBoxCodeSpecie.TabIndex = 9;
            // 
            // sdsTextBoxDescSpecie
            // 
            this.sdsTextBoxDescSpecie.CodeSector = null;
            this.sdsTextBoxDescSpecie.ColumnName = "DescSpecie";
            this.sdsTextBoxDescSpecie.DescCodi = null;
            this.sdsTextBoxDescSpecie.Location = new System.Drawing.Point(192, 220);
            this.sdsTextBoxDescSpecie.Name = "sdsTextBoxDescSpecie";
            this.sdsTextBoxDescSpecie.Nom = null;
            this.sdsTextBoxDescSpecie.NomBBDD = "SecureCore";
            this.sdsTextBoxDescSpecie.NomCamp = null;
            this.sdsTextBoxDescSpecie.NomControl = null;
            this.sdsTextBoxDescSpecie.NomTaula = "Species";
            this.sdsTextBoxDescSpecie.Requerit = false;
            this.sdsTextBoxDescSpecie.SiEsForana = false;
            this.sdsTextBoxDescSpecie.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBoxDescSpecie.TabIndex = 10;
            // 
            // lblDescSpecie
            // 
            this.lblDescSpecie.AutoSize = true;
            this.lblDescSpecie.Location = new System.Drawing.Point(99, 163);
            this.lblDescSpecie.Name = "lblDescSpecie";
            this.lblDescSpecie.Size = new System.Drawing.Size(68, 13);
            this.lblDescSpecie.TabIndex = 11;
            this.lblDescSpecie.Text = "DescSpecie:";
            // 
            // lblCodeSpecie
            // 
            this.lblCodeSpecie.AutoSize = true;
            this.lblCodeSpecie.Location = new System.Drawing.Point(99, 223);
            this.lblCodeSpecie.Name = "lblCodeSpecie";
            this.lblCodeSpecie.Size = new System.Drawing.Size(68, 13);
            this.lblCodeSpecie.TabIndex = 12;
            this.lblCodeSpecie.Text = "CodeSpecie:";
            // 
            // Species
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCodeSpecie);
            this.Controls.Add(this.lblDescSpecie);
            this.Controls.Add(this.sdsTextBoxDescSpecie);
            this.Controls.Add(this.sdsTextBoxCodeSpecie);
            this.Name = "Species";
            this.Text = "Species";
            this.Load += new System.EventHandler(this.Species_Load);
            this.Controls.SetChildIndex(this.sdsTextBoxCodeSpecie, 0);
            this.Controls.SetChildIndex(this.sdsTextBoxDescSpecie, 0);
            this.Controls.SetChildIndex(this.lblDescSpecie, 0);
            this.Controls.SetChildIndex(this.lblCodeSpecie, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MantenimientoTest.SdsTextBox sdsTextBoxCodeSpecie;
        private MantenimientoTest.SdsTextBox sdsTextBoxDescSpecie;
        private System.Windows.Forms.Label lblDescSpecie;
        private System.Windows.Forms.Label lblCodeSpecie;
    }
}