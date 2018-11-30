namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.sdsForanea1 = new MantenimientoForanea.sdsForanea();
            this.sdsTextBox1 = new MantenimientoTest.SdsTextBox();
            this.SuspendLayout();
            // 
            // sdsForanea1
            // 
            this.sdsForanea1.Control_Id = "sdsTextBox1";
            this.sdsForanea1.DescCodi = "DescSector";
            this.sdsForanea1.ErrorText = null;
            this.sdsForanea1.Location = new System.Drawing.Point(7, 49);
            this.sdsForanea1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sdsForanea1.Name = "sdsForanea1";
            this.sdsForanea1.NomCamp = "CodeSector";
            this.sdsForanea1.NomControl = "sdsTextBox1";
            this.sdsForanea1.NomID = "idSector";
            this.sdsForanea1.NomTaula = "Sectors";
            this.sdsForanea1.Requerit = false;
            this.sdsForanea1.Size = new System.Drawing.Size(391, 46);
            this.sdsForanea1.TabIndex = 2;
            this.sdsForanea1.TextLabel = null;
            // 
            // sdsTextBox1
            // 
            this.sdsTextBox1.CodeSector = null;
            this.sdsTextBox1.ColumnName = null;
            this.sdsTextBox1.DescCodi = null;
            this.sdsTextBox1.Location = new System.Drawing.Point(403, 63);
            this.sdsTextBox1.Name = "sdsTextBox1";
            this.sdsTextBox1.Nom = null;
            this.sdsTextBox1.NomBBDD = null;
            this.sdsTextBox1.NomCamp = "idSector";
            this.sdsTextBox1.NomControl = "sdsForanea1";
            this.sdsTextBox1.NomTaula = "Sectors";
            this.sdsTextBox1.Requerit = false;
            this.sdsTextBox1.SiEsForana = true;
            this.sdsTextBox1.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.sdsForanea1);
            this.Controls.Add(this.sdsTextBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MantenimientoTest.SdsTextBox sdsTextBox1;
        public MantenimientoForanea.sdsForanea sdsForanea1;
    }
}

