namespace WookieTablas
{
    partial class UserRanks
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
            this.sdstxtDescRank = new SdsTexBox.SdsTexBox();
            this.sdstxtCodeRank = new SdsTexBox.SdsTexBox();
            this.labDescRank = new System.Windows.Forms.Label();
            this.labCodeRank = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sdstxtDescRank
            // 
            this.sdstxtDescRank.BackColor = System.Drawing.Color.LightGreen;
            this.sdstxtDescRank.CodeSector = null;
            this.sdstxtDescRank.ColumnName = "DescRank";
            this.sdstxtDescRank.DescCodi = null;
            this.sdstxtDescRank.Location = new System.Drawing.Point(150, 224);
            this.sdstxtDescRank.Name = "sdstxtDescRank";
            this.sdstxtDescRank.Nom = null;
            this.sdstxtDescRank.NomBBDD = "SecureCore";
            this.sdstxtDescRank.NomCamp = null;
            this.sdstxtDescRank.NomControl = null;
            this.sdstxtDescRank.NomTaula = "UserRanks";
            this.sdstxtDescRank.Requerit = false;
            this.sdstxtDescRank.SiEsForana = false;
            this.sdstxtDescRank.Size = new System.Drawing.Size(100, 20);
            this.sdstxtDescRank.TabIndex = 33;
            // 
            // sdstxtCodeRank
            // 
            this.sdstxtCodeRank.BackColor = System.Drawing.Color.LightGreen;
            this.sdstxtCodeRank.CodeSector = null;
            this.sdstxtCodeRank.ColumnName = "CodeRank";
            this.sdstxtCodeRank.DescCodi = null;
            this.sdstxtCodeRank.Location = new System.Drawing.Point(150, 185);
            this.sdstxtCodeRank.Name = "sdstxtCodeRank";
            this.sdstxtCodeRank.Nom = null;
            this.sdstxtCodeRank.NomBBDD = "SecureCore";
            this.sdstxtCodeRank.NomCamp = null;
            this.sdstxtCodeRank.NomControl = null;
            this.sdstxtCodeRank.NomTaula = "UserRanks";
            this.sdstxtCodeRank.Requerit = false;
            this.sdstxtCodeRank.SiEsForana = false;
            this.sdstxtCodeRank.Size = new System.Drawing.Size(100, 20);
            this.sdstxtCodeRank.TabIndex = 32;
            // 
            // labDescRank
            // 
            this.labDescRank.AutoSize = true;
            this.labDescRank.Location = new System.Drawing.Point(78, 224);
            this.labDescRank.Name = "labDescRank";
            this.labDescRank.Size = new System.Drawing.Size(58, 13);
            this.labDescRank.TabIndex = 31;
            this.labDescRank.Text = "DescRank";
            // 
            // labCodeRank
            // 
            this.labCodeRank.AutoSize = true;
            this.labCodeRank.Location = new System.Drawing.Point(78, 188);
            this.labCodeRank.Name = "labCodeRank";
            this.labCodeRank.Size = new System.Drawing.Size(58, 13);
            this.labCodeRank.TabIndex = 30;
            this.labCodeRank.Text = "CodeRank";
            // 
            // UserRanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sdstxtDescRank);
            this.Controls.Add(this.sdstxtCodeRank);
            this.Controls.Add(this.labDescRank);
            this.Controls.Add(this.labCodeRank);
            this.Name = "UserRanks";
            this.Text = "UserRanks";
            this.Load += new System.EventHandler(this.UserRanks_Load);
            this.Controls.SetChildIndex(this.labCodeRank, 0);
            this.Controls.SetChildIndex(this.labDescRank, 0);
            this.Controls.SetChildIndex(this.sdstxtCodeRank, 0);
            this.Controls.SetChildIndex(this.sdstxtDescRank, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SdsTexBox.SdsTexBox sdstxtDescRank;
        private SdsTexBox.SdsTexBox sdstxtCodeRank;
        private System.Windows.Forms.Label labDescRank;
        private System.Windows.Forms.Label labCodeRank;
    }
}