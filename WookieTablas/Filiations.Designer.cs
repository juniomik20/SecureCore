namespace WookieTablas
{
    partial class Filiations
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sdsTexBox3 = new SdsTexBox.SdsTexBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(150, 401);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(57, 400);
            // 
            // sdsTexBox1
            // 
            this.sdsTexBox1.BackColor = System.Drawing.Color.LightGreen;
            this.sdsTexBox1.CodeSector = null;
            this.sdsTexBox1.ColumnName = "DescFiliations";
            this.sdsTexBox1.DescCodi = null;
            this.sdsTexBox1.Location = new System.Drawing.Point(202, 286);
            this.sdsTexBox1.Name = "sdsTexBox1";
            this.sdsTexBox1.Nom = null;
            this.sdsTexBox1.NomBBDD = "SecureCore";
            this.sdsTexBox1.NomCamp = null;
            this.sdsTexBox1.NomControl = null;
            this.sdsTexBox1.NomTaula = "Filiations";
            this.sdsTexBox1.Requerit = false;
            this.sdsTexBox1.SiEsForana = false;
            this.sdsTexBox1.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox1.TabIndex = 41;
            // 
            // sdsTexBox2
            // 
            this.sdsTexBox2.BackColor = System.Drawing.Color.LightGreen;
            this.sdsTexBox2.CodeSector = null;
            this.sdsTexBox2.ColumnName = "CodeFiliation";
            this.sdsTexBox2.DescCodi = null;
            this.sdsTexBox2.Location = new System.Drawing.Point(188, 208);
            this.sdsTexBox2.Name = "sdsTexBox2";
            this.sdsTexBox2.Nom = null;
            this.sdsTexBox2.NomBBDD = "SecureCore";
            this.sdsTexBox2.NomCamp = null;
            this.sdsTexBox2.NomControl = null;
            this.sdsTexBox2.NomTaula = "Filiations";
            this.sdsTexBox2.Requerit = false;
            this.sdsTexBox2.SiEsForana = false;
            this.sdsTexBox2.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox2.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "DescFiliations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "CodeFiliation";
            // 
            // sdsTexBox3
            // 
            this.sdsTexBox3.BackColor = System.Drawing.Color.LightGreen;
            this.sdsTexBox3.CodeSector = null;
            this.sdsTexBox3.ColumnName = "DescFiliations";
            this.sdsTexBox3.DescCodi = null;
            this.sdsTexBox3.Location = new System.Drawing.Point(202, 324);
            this.sdsTexBox3.Name = "sdsTexBox3";
            this.sdsTexBox3.Nom = null;
            this.sdsTexBox3.NomBBDD = "SecureCore";
            this.sdsTexBox3.NomCamp = null;
            this.sdsTexBox3.NomControl = null;
            this.sdsTexBox3.NomTaula = "Filiations";
            this.sdsTexBox3.Requerit = false;
            this.sdsTexBox3.SiEsForana = false;
            this.sdsTexBox3.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox3.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "DescFiliations";
            // 
            // Filiations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 520);
            this.Controls.Add(this.sdsTexBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sdsTexBox1);
            this.Controls.Add(this.sdsTexBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Filiations";
            this.Text = "Filiations";
            this.Load += new System.EventHandler(this.Filiations_Load);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.sdsTexBox2, 0);
            this.Controls.SetChildIndex(this.sdsTexBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.sdsTexBox3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SdsTexBox.SdsTexBox sdsTexBox1;
        private SdsTexBox.SdsTexBox sdsTexBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private SdsTexBox.SdsTexBox sdsTexBox3;
        private System.Windows.Forms.Label label3;
    }
}