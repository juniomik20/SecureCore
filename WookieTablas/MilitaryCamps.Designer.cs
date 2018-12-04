namespace WookieTablas
{
    partial class MilitaryCamps
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
            this.sdsTexBox1 = new SdsTexBox.SdsTexBox();
            this.sdsTexBox2 = new SdsTexBox.SdsTexBox();
            this.sdsTexBox3 = new SdsTexBox.SdsTexBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(217, 461);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsert.Location = new System.Drawing.Point(95, 461);
            this.btnInsert.Size = new System.Drawing.Size(75, 20);
            // 
            // sdsTexBox1
            // 
            this.sdsTexBox1.CodeSector = null;
            this.sdsTexBox1.ColumnName = null;
            this.sdsTexBox1.DescCodi = null;
            this.sdsTexBox1.Location = new System.Drawing.Point(119, 163);
            this.sdsTexBox1.Name = "sdsTexBox1";
            this.sdsTexBox1.Nom = null;
            this.sdsTexBox1.NomBBDD = null;
            this.sdsTexBox1.NomCamp = null;
            this.sdsTexBox1.NomControl = null;
            this.sdsTexBox1.NomTaula = null;
            this.sdsTexBox1.Requerit = false;
            this.sdsTexBox1.SiEsForana = false;
            this.sdsTexBox1.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox1.TabIndex = 24;
            // 
            // sdsTexBox2
            // 
            this.sdsTexBox2.CodeSector = null;
            this.sdsTexBox2.ColumnName = null;
            this.sdsTexBox2.DescCodi = null;
            this.sdsTexBox2.Location = new System.Drawing.Point(119, 214);
            this.sdsTexBox2.Name = "sdsTexBox2";
            this.sdsTexBox2.Nom = null;
            this.sdsTexBox2.NomBBDD = null;
            this.sdsTexBox2.NomCamp = null;
            this.sdsTexBox2.NomControl = null;
            this.sdsTexBox2.NomTaula = null;
            this.sdsTexBox2.Requerit = false;
            this.sdsTexBox2.SiEsForana = false;
            this.sdsTexBox2.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox2.TabIndex = 25;
            // 
            // sdsTexBox3
            // 
            this.sdsTexBox3.CodeSector = null;
            this.sdsTexBox3.ColumnName = null;
            this.sdsTexBox3.DescCodi = null;
            this.sdsTexBox3.Location = new System.Drawing.Point(119, 267);
            this.sdsTexBox3.Name = "sdsTexBox3";
            this.sdsTexBox3.Nom = null;
            this.sdsTexBox3.NomBBDD = null;
            this.sdsTexBox3.NomCamp = null;
            this.sdsTexBox3.NomControl = null;
            this.sdsTexBox3.NomTaula = null;
            this.sdsTexBox3.Requerit = false;
            this.sdsTexBox3.SiEsForana = false;
            this.sdsTexBox3.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox3.TabIndex = 26;
            // 
            // MilitaryCamps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 558);
            this.Controls.Add(this.sdsTexBox3);
            this.Controls.Add(this.sdsTexBox2);
            this.Controls.Add(this.sdsTexBox1);
            this.Name = "MilitaryCamps";
            this.Text = "MilitaryCamps";
            this.Load += new System.EventHandler(this.MilitaryCamps_Load);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.sdsTexBox1, 0);
            this.Controls.SetChildIndex(this.sdsTexBox2, 0);
            this.Controls.SetChildIndex(this.sdsTexBox3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SdsTexBox.SdsTexBox sdsTexBox1;
        private SdsTexBox.SdsTexBox sdsTexBox2;
        private SdsTexBox.SdsTexBox sdsTexBox3;
    }
}