namespace MantenimientoTest
{
    partial class MantenimentBase
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
            this.dgvMant_table = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.sdsTextBox0 = new MantenimientoTest.SdsTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMant_table)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMant_table
            // 
            this.dgvMant_table.AllowUserToOrderColumns = true;
            this.dgvMant_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMant_table.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvMant_table.Location = new System.Drawing.Point(394, 95);
            this.dgvMant_table.Name = "dgvMant_table";
            this.dgvMant_table.Size = new System.Drawing.Size(406, 355);
            this.dgvMant_table.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsert.Location = new System.Drawing.Point(94, 384);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Location = new System.Drawing.Point(175, 384);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // sdsTextBox0
            // 
            this.sdsTextBox0.CodeSector = null;
            this.sdsTextBox0.ColumnName = null;
            this.sdsTextBox0.DescCodi = null;
            this.sdsTextBox0.Location = new System.Drawing.Point(154, 163);
            this.sdsTextBox0.Name = "sdsTextBox0";
            this.sdsTextBox0.Nom = null;
            this.sdsTextBox0.NomBBDD = null;
            this.sdsTextBox0.NomCamp = null;
            this.sdsTextBox0.NomControl = null;
            this.sdsTextBox0.NomTaula = null;
            this.sdsTextBox0.Requerit = false;
            this.sdsTextBox0.SiEsForana = false;
            this.sdsTextBox0.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBox0.TabIndex = 11;
            // 
            // MantenimentBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgvMant_table);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MantenimentBase";
            this.Text = "frmMant_Table";
            this.Load += new System.EventHandler(this.FrmMant_Table_Load);
            this.Controls.SetChildIndex(this.dgvMant_table, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMant_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMant_table;
        private SdsTextBox txtBoxCodeType;
        private SdsTextBox txtBoxDescType;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private SdsTextBox sdsTextBox0;
    }
}

