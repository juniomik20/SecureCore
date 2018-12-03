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
            this.labDescRegion = new System.Windows.Forms.Label();
            this.labCodeRegion = new System.Windows.Forms.Label();
            this.sdstxtCodeRegion = new SdsTexBox.SdsTexBox();
            this.sdstxtDescRegion = new SdsTexBox.SdsTexBox();
            this.sdstxtRemarks = new SdsTexBox.SdsTexBox();
            this.labRemarks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(143, 498);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(48, 498);
            // 
            // labDescRegion
            // 
            this.labDescRegion.AutoSize = true;
            this.labDescRegion.Location = new System.Drawing.Point(54, 238);
            this.labDescRegion.Name = "labDescRegion";
            this.labDescRegion.Size = new System.Drawing.Size(66, 13);
            this.labDescRegion.TabIndex = 28;
            this.labDescRegion.Text = "DescRegion";
            // 
            // labCodeRegion
            // 
            this.labCodeRegion.AutoSize = true;
            this.labCodeRegion.Location = new System.Drawing.Point(54, 186);
            this.labCodeRegion.Name = "labCodeRegion";
            this.labCodeRegion.Size = new System.Drawing.Size(66, 13);
            this.labCodeRegion.TabIndex = 27;
            this.labCodeRegion.Text = "CodeRegion";
            // 
            // sdstxtCodeRegion
            // 
            this.sdstxtCodeRegion.BackColor = System.Drawing.Color.LightGreen;
            this.sdstxtCodeRegion.CodeSector = null;
            this.sdstxtCodeRegion.ColumnName = "CodeRegion";
            this.sdstxtCodeRegion.DescCodi = null;
            this.sdstxtCodeRegion.Location = new System.Drawing.Point(143, 183);
            this.sdstxtCodeRegion.Name = "sdstxtCodeRegion";
            this.sdstxtCodeRegion.Nom = null;
            this.sdstxtCodeRegion.NomBBDD = "SecureCore";
            this.sdstxtCodeRegion.NomCamp = null;
            this.sdstxtCodeRegion.NomControl = null;
            this.sdstxtCodeRegion.NomTaula = "Regions";
            this.sdstxtCodeRegion.Requerit = false;
            this.sdstxtCodeRegion.SiEsForana = false;
            this.sdstxtCodeRegion.Size = new System.Drawing.Size(100, 20);
            this.sdstxtCodeRegion.TabIndex = 0;
            // 
            // sdstxtDescRegion
            // 
            this.sdstxtDescRegion.BackColor = System.Drawing.Color.LightGreen;
            this.sdstxtDescRegion.CodeSector = null;
            this.sdstxtDescRegion.ColumnName = "DescRegion";
            this.sdstxtDescRegion.DescCodi = null;
            this.sdstxtDescRegion.Location = new System.Drawing.Point(143, 235);
            this.sdstxtDescRegion.Name = "sdstxtDescRegion";
            this.sdstxtDescRegion.Nom = null;
            this.sdstxtDescRegion.NomBBDD = "SecureCore";
            this.sdstxtDescRegion.NomCamp = null;
            this.sdstxtDescRegion.NomControl = null;
            this.sdstxtDescRegion.NomTaula = "Regions";
            this.sdstxtDescRegion.Requerit = false;
            this.sdstxtDescRegion.SiEsForana = false;
            this.sdstxtDescRegion.Size = new System.Drawing.Size(100, 20);
            this.sdstxtDescRegion.TabIndex = 0;
            // 
            // sdstxtRemarks
            // 
            this.sdstxtRemarks.BackColor = System.Drawing.Color.LightGreen;
            this.sdstxtRemarks.CodeSector = null;
            this.sdstxtRemarks.ColumnName = "Remarks";
            this.sdstxtRemarks.DescCodi = null;
            this.sdstxtRemarks.Location = new System.Drawing.Point(143, 277);
            this.sdstxtRemarks.Name = "sdstxtRemarks";
            this.sdstxtRemarks.Nom = null;
            this.sdstxtRemarks.NomBBDD = "SecureCore";
            this.sdstxtRemarks.NomCamp = null;
            this.sdstxtRemarks.NomControl = null;
            this.sdstxtRemarks.NomTaula = "Regions";
            this.sdstxtRemarks.Requerit = false;
            this.sdstxtRemarks.SiEsForana = false;
            this.sdstxtRemarks.Size = new System.Drawing.Size(100, 20);
            this.sdstxtRemarks.TabIndex = 29;
            // 
            // labRemarks
            // 
            this.labRemarks.AutoSize = true;
            this.labRemarks.Location = new System.Drawing.Point(54, 280);
            this.labRemarks.Name = "labRemarks";
            this.labRemarks.Size = new System.Drawing.Size(66, 13);
            this.labRemarks.TabIndex = 30;
            this.labRemarks.Text = "DescRegion";
            // 
            // Regions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 553);
            this.Controls.Add(this.labRemarks);
            this.Controls.Add(this.sdstxtRemarks);
            this.Controls.Add(this.sdstxtDescRegion);
            this.Controls.Add(this.sdstxtCodeRegion);
            this.Controls.Add(this.labDescRegion);
            this.Controls.Add(this.labCodeRegion);
            this.Name = "Regions";
            this.Text = "Regions";
            this.Load += new System.EventHandler(this.Regions_Load);
            this.Controls.SetChildIndex(this.labCodeRegion, 0);
            this.Controls.SetChildIndex(this.labDescRegion, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.sdstxtCodeRegion, 0);
            this.Controls.SetChildIndex(this.sdstxtDescRegion, 0);
            this.Controls.SetChildIndex(this.sdstxtRemarks, 0);
            this.Controls.SetChildIndex(this.labRemarks, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label labDescRegion;
        private System.Windows.Forms.Label labCodeRegion;
        private SdsTexBox.SdsTexBox sdstxtCodeRegion;
        private SdsTexBox.SdsTexBox sdstxtDescRegion;
        private SdsTexBox.SdsTexBox sdstxtRemarks;
        private System.Windows.Forms.Label labRemarks;
    }
}