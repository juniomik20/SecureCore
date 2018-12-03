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
            this.sdstxtDescFiliations = new SdsTexBox.SdsTexBox();
            this.sdstxtCodeFiliation = new SdsTexBox.SdsTexBox();
            this.labDescFiliations = new System.Windows.Forms.Label();
            this.labCodeFiliation = new System.Windows.Forms.Label();
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
            // sdstxtDescFiliations
            // 
            this.sdstxtDescFiliations.BackColor = System.Drawing.Color.LightGreen;
            this.sdstxtDescFiliations.CodeSector = null;
            this.sdstxtDescFiliations.ColumnName = "DescFiliations";
            this.sdstxtDescFiliations.DescCodi = null;
            this.sdstxtDescFiliations.Location = new System.Drawing.Point(190, 228);
            this.sdstxtDescFiliations.Name = "sdstxtDescFiliations";
            this.sdstxtDescFiliations.Nom = null;
            this.sdstxtDescFiliations.NomBBDD = "SecureCore";
            this.sdstxtDescFiliations.NomCamp = null;
            this.sdstxtDescFiliations.NomControl = null;
            this.sdstxtDescFiliations.NomTaula = "Filiations";
            this.sdstxtDescFiliations.Requerit = false;
            this.sdstxtDescFiliations.SiEsForana = false;
            this.sdstxtDescFiliations.Size = new System.Drawing.Size(100, 20);
            this.sdstxtDescFiliations.TabIndex = 37;
            // 
            // sdstxtCodeFiliation
            // 
            this.sdstxtCodeFiliation.BackColor = System.Drawing.Color.LightGreen;
            this.sdstxtCodeFiliation.CodeSector = null;
            this.sdstxtCodeFiliation.ColumnName = "CodeFiliation";
            this.sdstxtCodeFiliation.DescCodi = null;
            this.sdstxtCodeFiliation.Location = new System.Drawing.Point(190, 176);
            this.sdstxtCodeFiliation.Name = "sdstxtCodeFiliation";
            this.sdstxtCodeFiliation.Nom = null;
            this.sdstxtCodeFiliation.NomBBDD = "SecureCore";
            this.sdstxtCodeFiliation.NomCamp = null;
            this.sdstxtCodeFiliation.NomControl = null;
            this.sdstxtCodeFiliation.NomTaula = "Filiations";
            this.sdstxtCodeFiliation.Requerit = false;
            this.sdstxtCodeFiliation.SiEsForana = false;
            this.sdstxtCodeFiliation.Size = new System.Drawing.Size(100, 20);
            this.sdstxtCodeFiliation.TabIndex = 38;
            // 
            // labDescFiliations
            // 
            this.labDescFiliations.AutoSize = true;
            this.labDescFiliations.Location = new System.Drawing.Point(101, 231);
            this.labDescFiliations.Name = "labDescFiliations";
            this.labDescFiliations.Size = new System.Drawing.Size(72, 13);
            this.labDescFiliations.TabIndex = 40;
            this.labDescFiliations.Text = "DescFiliations";
            // 
            // labCodeFiliation
            // 
            this.labCodeFiliation.AutoSize = true;
            this.labCodeFiliation.Location = new System.Drawing.Point(101, 179);
            this.labCodeFiliation.Name = "labCodeFiliation";
            this.labCodeFiliation.Size = new System.Drawing.Size(67, 13);
            this.labCodeFiliation.TabIndex = 39;
            this.labCodeFiliation.Text = "CodeFiliation";
            // 
            // Filiations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 520);
            this.Controls.Add(this.sdstxtDescFiliations);
            this.Controls.Add(this.sdstxtCodeFiliation);
            this.Controls.Add(this.labDescFiliations);
            this.Controls.Add(this.labCodeFiliation);
            this.Name = "Filiations";
            this.Text = "Filiations";
            this.Load += new System.EventHandler(this.Filiations_Load);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.labCodeFiliation, 0);
            this.Controls.SetChildIndex(this.labDescFiliations, 0);
            this.Controls.SetChildIndex(this.sdstxtCodeFiliation, 0);
            this.Controls.SetChildIndex(this.sdstxtDescFiliations, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SdsTexBox.SdsTexBox sdstxtDescFiliations;
        private SdsTexBox.SdsTexBox sdstxtCodeFiliation;
        private System.Windows.Forms.Label labDescFiliations;
        private System.Windows.Forms.Label labCodeFiliation;
    }
}