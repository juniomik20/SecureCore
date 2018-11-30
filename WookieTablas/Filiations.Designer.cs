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
            this.label1 = new System.Windows.Forms.Label();
            this.sdsTextBox1 = new MantenimientoTest.SdsTextBox();
            this.sdsTextBox3 = new MantenimientoTest.SdsTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(46, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "CodeFiliationType:";
            // 
            // sdsTextBox1
            // 
            this.sdsTextBox1.BackColor = System.Drawing.Color.LightGreen;
            this.sdsTextBox1.CodeSector = null;
            this.sdsTextBox1.ColumnName = "CodeFiliation";
            this.sdsTextBox1.DescCodi = null;
            this.sdsTextBox1.Location = new System.Drawing.Point(150, 125);
            this.sdsTextBox1.Name = "sdsTextBox1";
            this.sdsTextBox1.Nom = null;
            this.sdsTextBox1.NomBBDD = "SecureCore";
            this.sdsTextBox1.NomCamp = null;
            this.sdsTextBox1.NomControl = null;
            this.sdsTextBox1.NomTaula = "Filiations";
            this.sdsTextBox1.Requerit = false;
            this.sdsTextBox1.SiEsForana = false;
            this.sdsTextBox1.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBox1.TabIndex = 9;
            // 
            // sdsTextBox3
            // 
            this.sdsTextBox3.BackColor = System.Drawing.Color.LightGreen;
            this.sdsTextBox3.CodeSector = null;
            this.sdsTextBox3.ColumnName = "DescFiliations";
            this.sdsTextBox3.DescCodi = null;
            this.sdsTextBox3.Location = new System.Drawing.Point(148, 163);
            this.sdsTextBox3.Name = "sdsTextBox3";
            this.sdsTextBox3.Nom = null;
            this.sdsTextBox3.NomBBDD = "SecureCore";
            this.sdsTextBox3.NomCamp = null;
            this.sdsTextBox3.NomControl = null;
            this.sdsTextBox3.NomTaula = "Filiations";
            this.sdsTextBox3.Requerit = false;
            this.sdsTextBox3.SiEsForana = false;
            this.sdsTextBox3.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBox3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(46, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "DescFiliationsType:";
            // 
            // Filiations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sdsTextBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sdsTextBox1);
            this.Name = "Filiations";
            this.Text = "Filiations";
            this.Load += new System.EventHandler(this.Filiations_Load);
            this.Controls.SetChildIndex(this.sdsTextBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.sdsTextBox3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MantenimientoTest.SdsTextBox sdsTextBox1;
        private MantenimientoTest.SdsTextBox sdsTextBox3;
        private System.Windows.Forms.Label label2;
    }
}