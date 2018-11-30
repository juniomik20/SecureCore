namespace WookieTablas
{
    partial class Regions
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
            this.labCodeRegion = new System.Windows.Forms.Label();
            this.labDescRegion = new System.Windows.Forms.Label();
            this.sdstxtCodeRegion = new MantenimientoTest.SdsTextBox();
            this.sdstxtDescRegion = new MantenimientoTest.SdsTextBox();
            this.SuspendLayout();
            // 
            // labCodeRegion
            // 
            this.labCodeRegion.AutoSize = true;
            this.labCodeRegion.Location = new System.Drawing.Point(94, 174);
            this.labCodeRegion.Name = "labCodeRegion";
            this.labCodeRegion.Size = new System.Drawing.Size(66, 13);
            this.labCodeRegion.TabIndex = 24;
            this.labCodeRegion.Text = "CodeRegion";
            // 
            // labDescRegion
            // 
            this.labDescRegion.AutoSize = true;
            this.labDescRegion.Location = new System.Drawing.Point(94, 210);
            this.labDescRegion.Name = "labDescRegion";
            this.labDescRegion.Size = new System.Drawing.Size(66, 13);
            this.labDescRegion.TabIndex = 26;
            this.labDescRegion.Text = "DescRegion";
            // 
            // sdstxtCodeRegion
            // 
            this.sdstxtCodeRegion.BackColor = System.Drawing.Color.LightGreen;
            this.sdstxtCodeRegion.CodeSector = null;
            this.sdstxtCodeRegion.ColumnName = "CodeRegion";
            this.sdstxtCodeRegion.DescCodi = null;
            this.sdstxtCodeRegion.Location = new System.Drawing.Point(166, 171);
            this.sdstxtCodeRegion.Name = "sdstxtCodeRegion";
            this.sdstxtCodeRegion.Nom = null;
            this.sdstxtCodeRegion.NomBBDD = "SecureCore";
            this.sdstxtCodeRegion.NomCamp = null;
            this.sdstxtCodeRegion.NomControl = null;
            this.sdstxtCodeRegion.NomTaula = "Regions";
            this.sdstxtCodeRegion.Requerit = false;
            this.sdstxtCodeRegion.SiEsForana = false;
            this.sdstxtCodeRegion.Size = new System.Drawing.Size(100, 20);
            this.sdstxtCodeRegion.TabIndex = 28;
            // 
            // sdstxtDescRegion
            // 
            this.sdstxtDescRegion.BackColor = System.Drawing.Color.LightGreen;
            this.sdstxtDescRegion.CodeSector = null;
            this.sdstxtDescRegion.ColumnName = "DescRegion";
            this.sdstxtDescRegion.DescCodi = null;
            this.sdstxtDescRegion.Location = new System.Drawing.Point(166, 210);
            this.sdstxtDescRegion.Name = "sdstxtDescRegion";
            this.sdstxtDescRegion.Nom = null;
            this.sdstxtDescRegion.NomBBDD = "SecureCore";
            this.sdstxtDescRegion.NomCamp = null;
            this.sdstxtDescRegion.NomControl = null;
            this.sdstxtDescRegion.NomTaula = "Regions";
            this.sdstxtDescRegion.Requerit = false;
            this.sdstxtDescRegion.SiEsForana = false;
            this.sdstxtDescRegion.Size = new System.Drawing.Size(100, 20);
            this.sdstxtDescRegion.TabIndex = 29;
            // 
            // Regions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sdstxtDescRegion);
            this.Controls.Add(this.sdstxtCodeRegion);
            this.Controls.Add(this.labDescRegion);
            this.Controls.Add(this.labCodeRegion);
            this.Name = "Regions";
            this.Text = "Regions";
            this.Load += new System.EventHandler(this.Regions_Load);
            this.Controls.SetChildIndex(this.labCodeRegion, 0);
            this.Controls.SetChildIndex(this.labDescRegion, 0);
            this.Controls.SetChildIndex(this.sdstxtCodeRegion, 0);
            this.Controls.SetChildIndex(this.sdstxtDescRegion, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCodeRegion;
        private System.Windows.Forms.Label labDescRegion;
        private MantenimientoTest.SdsTextBox sdstxtCodeRegion;
        private MantenimientoTest.SdsTextBox sdstxtDescRegion;
    }
}