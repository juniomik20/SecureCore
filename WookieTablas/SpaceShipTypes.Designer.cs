namespace WookieTablas
{
    partial class SpaceShipTypes
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
            this.labDescSector = new System.Windows.Forms.Label();
            this.labCodeSector = new System.Windows.Forms.Label();
            this.sdstxtRegion = new SdsTexBox.SdsTexBox();
            this.sdsForaneaRegion = new WookieCodeControls.sdsForanea();
            this.sdstxtDescSector = new SdsTexBox.SdsTexBox();
            this.sdstxtCodeSector = new SdsTexBox.SdsTexBox();
            this.sdsForanea1 = new WookieCodeControls.sdsForanea();
            this.sdsForanea2 = new WookieCodeControls.sdsForanea();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sdsTexBox1 = new SdsTexBox.SdsTexBox();
            this.sdsForanea3 = new WookieCodeControls.sdsForanea();
            this.sdsTexBox2 = new SdsTexBox.SdsTexBox();
            this.sdsTexBox3 = new SdsTexBox.SdsTexBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(139, 417);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(47, 417);
            // 
            // labDescSector
            // 
            this.labDescSector.AutoSize = true;
            this.labDescSector.Location = new System.Drawing.Point(66, 225);
            this.labDescSector.Name = "labDescSector";
            this.labDescSector.Size = new System.Drawing.Size(77, 13);
            this.labDescSector.TabIndex = 36;
            this.labDescSector.Text = "labDescSector";
            // 
            // labCodeSector
            // 
            this.labCodeSector.AutoSize = true;
            this.labCodeSector.Location = new System.Drawing.Point(66, 181);
            this.labCodeSector.Name = "labCodeSector";
            this.labCodeSector.Size = new System.Drawing.Size(77, 13);
            this.labCodeSector.TabIndex = 35;
            this.labCodeSector.Text = "labCodeSector";
            // 
            // sdstxtRegion
            // 
            this.sdstxtRegion.CodeSector = null;
            this.sdstxtRegion.ColumnName = "idRegion";
            this.sdstxtRegion.DescCodi = null;
            this.sdstxtRegion.Location = new System.Drawing.Point(327, 234);
            this.sdstxtRegion.Name = "sdstxtRegion";
            this.sdstxtRegion.Nom = null;
            this.sdstxtRegion.NomBBDD = "SecureCore";
            this.sdstxtRegion.NomCamp = "idRegion";
            this.sdstxtRegion.NomControl = "sdsForaneaRegion";
            this.sdstxtRegion.NomTaula = "Sectors";
            this.sdstxtRegion.Requerit = false;
            this.sdstxtRegion.SiEsForana = true;
            this.sdstxtRegion.Size = new System.Drawing.Size(20, 20);
            this.sdstxtRegion.TabIndex = 31;
            // 
            // sdsForaneaRegion
            // 
            this.sdsForaneaRegion.Control_Id = "sdstxtRegion";
            this.sdsForaneaRegion.DescCodi = "DescRegion";
            this.sdsForaneaRegion.ErrorText = null;
            this.sdsForaneaRegion.Location = new System.Drawing.Point(8, 275);
            this.sdsForaneaRegion.Margin = new System.Windows.Forms.Padding(2);
            this.sdsForaneaRegion.Name = "sdsForaneaRegion";
            this.sdsForaneaRegion.NomCamp = "CodeRegion";
            this.sdsForaneaRegion.NomControl = "txtIDRegion";
            this.sdsForaneaRegion.NomID = "idRegion";
            this.sdsForaneaRegion.NomTaula = "Regions";
            this.sdsForaneaRegion.Requerit = false;
            this.sdsForaneaRegion.Size = new System.Drawing.Size(391, 46);
            this.sdsForaneaRegion.TabIndex = 34;
            this.sdsForaneaRegion.TextLabel = "Region";
            // 
            // sdstxtDescSector
            // 
            this.sdstxtDescSector.CodeSector = null;
            this.sdstxtDescSector.ColumnName = "DescSector";
            this.sdstxtDescSector.DescCodi = null;
            this.sdstxtDescSector.Location = new System.Drawing.Point(149, 225);
            this.sdstxtDescSector.Name = "sdstxtDescSector";
            this.sdstxtDescSector.Nom = null;
            this.sdstxtDescSector.NomBBDD = "SecureCore";
            this.sdstxtDescSector.NomCamp = null;
            this.sdstxtDescSector.NomControl = null;
            this.sdstxtDescSector.NomTaula = "Sectors";
            this.sdstxtDescSector.Requerit = false;
            this.sdstxtDescSector.SiEsForana = false;
            this.sdstxtDescSector.Size = new System.Drawing.Size(100, 20);
            this.sdstxtDescSector.TabIndex = 32;
            // 
            // sdstxtCodeSector
            // 
            this.sdstxtCodeSector.CodeSector = null;
            this.sdstxtCodeSector.ColumnName = "CodeSector";
            this.sdstxtCodeSector.DescCodi = null;
            this.sdstxtCodeSector.Location = new System.Drawing.Point(149, 181);
            this.sdstxtCodeSector.Name = "sdstxtCodeSector";
            this.sdstxtCodeSector.Nom = null;
            this.sdstxtCodeSector.NomBBDD = "SecureCore";
            this.sdstxtCodeSector.NomCamp = null;
            this.sdstxtCodeSector.NomControl = null;
            this.sdstxtCodeSector.NomTaula = "Sectors";
            this.sdstxtCodeSector.Requerit = false;
            this.sdstxtCodeSector.SiEsForana = false;
            this.sdstxtCodeSector.Size = new System.Drawing.Size(100, 20);
            this.sdstxtCodeSector.TabIndex = 33;
            // 
            // sdsForanea1
            // 
            this.sdsForanea1.Control_Id = "sdstxtRegion";
            this.sdsForanea1.DescCodi = "DescRegion";
            this.sdsForanea1.ErrorText = null;
            this.sdsForanea1.Location = new System.Drawing.Point(8, 325);
            this.sdsForanea1.Margin = new System.Windows.Forms.Padding(2);
            this.sdsForanea1.Name = "sdsForanea1";
            this.sdsForanea1.NomCamp = "CodeRegion";
            this.sdsForanea1.NomControl = "txtIDRegion";
            this.sdsForanea1.NomID = "idRegion";
            this.sdsForanea1.NomTaula = "Regions";
            this.sdsForanea1.Requerit = false;
            this.sdsForanea1.Size = new System.Drawing.Size(391, 46);
            this.sdsForanea1.TabIndex = 37;
            this.sdsForanea1.TextLabel = "Region";
            // 
            // sdsForanea2
            // 
            this.sdsForanea2.Control_Id = "sdstxtRegion";
            this.sdsForanea2.DescCodi = "DescRegion";
            this.sdsForanea2.ErrorText = null;
            this.sdsForanea2.Location = new System.Drawing.Point(172, 530);
            this.sdsForanea2.Margin = new System.Windows.Forms.Padding(2);
            this.sdsForanea2.Name = "sdsForanea2";
            this.sdsForanea2.NomCamp = "CodeRegion";
            this.sdsForanea2.NomControl = "txtIDRegion";
            this.sdsForanea2.NomID = "idRegion";
            this.sdsForanea2.NomTaula = "Regions";
            this.sdsForanea2.Requerit = false;
            this.sdsForanea2.Size = new System.Drawing.Size(391, 46);
            this.sdsForanea2.TabIndex = 44;
            this.sdsForanea2.TextLabel = "Region";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "label2";
            // 
            // sdsTexBox1
            // 
            this.sdsTexBox1.CodeSector = null;
            this.sdsTexBox1.ColumnName = "idRegion";
            this.sdsTexBox1.DescCodi = null;
            this.sdsTexBox1.Location = new System.Drawing.Point(491, 439);
            this.sdsTexBox1.Name = "sdsTexBox1";
            this.sdsTexBox1.Nom = null;
            this.sdsTexBox1.NomBBDD = "SecureCore";
            this.sdsTexBox1.NomCamp = "idRegion";
            this.sdsTexBox1.NomControl = "sdsForaneaRegion";
            this.sdsTexBox1.NomTaula = "Sectors";
            this.sdsTexBox1.Requerit = false;
            this.sdsTexBox1.SiEsForana = true;
            this.sdsTexBox1.Size = new System.Drawing.Size(20, 20);
            this.sdsTexBox1.TabIndex = 38;
            // 
            // sdsForanea3
            // 
            this.sdsForanea3.Control_Id = "sdstxtRegion";
            this.sdsForanea3.DescCodi = "DescRegion";
            this.sdsForanea3.ErrorText = null;
            this.sdsForanea3.Location = new System.Drawing.Point(172, 480);
            this.sdsForanea3.Margin = new System.Windows.Forms.Padding(2);
            this.sdsForanea3.Name = "sdsForanea3";
            this.sdsForanea3.NomCamp = "CodeRegion";
            this.sdsForanea3.NomControl = "txtIDRegion";
            this.sdsForanea3.NomID = "idRegion";
            this.sdsForanea3.NomTaula = "Regions";
            this.sdsForanea3.Requerit = false;
            this.sdsForanea3.Size = new System.Drawing.Size(391, 46);
            this.sdsForanea3.TabIndex = 41;
            this.sdsForanea3.TextLabel = "Region";
            // 
            // sdsTexBox2
            // 
            this.sdsTexBox2.CodeSector = null;
            this.sdsTexBox2.ColumnName = "DescSector";
            this.sdsTexBox2.DescCodi = null;
            this.sdsTexBox2.Location = new System.Drawing.Point(313, 430);
            this.sdsTexBox2.Name = "sdsTexBox2";
            this.sdsTexBox2.Nom = null;
            this.sdsTexBox2.NomBBDD = "SecureCore";
            this.sdsTexBox2.NomCamp = null;
            this.sdsTexBox2.NomControl = null;
            this.sdsTexBox2.NomTaula = "Sectors";
            this.sdsTexBox2.Requerit = false;
            this.sdsTexBox2.SiEsForana = false;
            this.sdsTexBox2.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox2.TabIndex = 39;
            // 
            // sdsTexBox3
            // 
            this.sdsTexBox3.CodeSector = null;
            this.sdsTexBox3.ColumnName = "CodeSector";
            this.sdsTexBox3.DescCodi = null;
            this.sdsTexBox3.Location = new System.Drawing.Point(313, 386);
            this.sdsTexBox3.Name = "sdsTexBox3";
            this.sdsTexBox3.Nom = null;
            this.sdsTexBox3.NomBBDD = "SecureCore";
            this.sdsTexBox3.NomCamp = null;
            this.sdsTexBox3.NomControl = null;
            this.sdsTexBox3.NomTaula = "Sectors";
            this.sdsTexBox3.Requerit = false;
            this.sdsTexBox3.SiEsForana = false;
            this.sdsTexBox3.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox3.TabIndex = 40;
            // 
            // SpaceShipTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 628);
            this.Controls.Add(this.sdsForanea2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sdsTexBox1);
            this.Controls.Add(this.sdsForanea3);
            this.Controls.Add(this.sdsTexBox2);
            this.Controls.Add(this.sdsTexBox3);
            this.Controls.Add(this.sdsForanea1);
            this.Controls.Add(this.labDescSector);
            this.Controls.Add(this.labCodeSector);
            this.Controls.Add(this.sdstxtRegion);
            this.Controls.Add(this.sdsForaneaRegion);
            this.Controls.Add(this.sdstxtDescSector);
            this.Controls.Add(this.sdstxtCodeSector);
            this.Name = "SpaceShipTypes";
            this.Text = "SpaceShipTypes";
            this.Load += new System.EventHandler(this.SpaceShipTypes_Load);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.sdstxtCodeSector, 0);
            this.Controls.SetChildIndex(this.sdstxtDescSector, 0);
            this.Controls.SetChildIndex(this.sdsForaneaRegion, 0);
            this.Controls.SetChildIndex(this.sdstxtRegion, 0);
            this.Controls.SetChildIndex(this.labCodeSector, 0);
            this.Controls.SetChildIndex(this.labDescSector, 0);
            this.Controls.SetChildIndex(this.sdsForanea1, 0);
            this.Controls.SetChildIndex(this.sdsTexBox3, 0);
            this.Controls.SetChildIndex(this.sdsTexBox2, 0);
            this.Controls.SetChildIndex(this.sdsForanea3, 0);
            this.Controls.SetChildIndex(this.sdsTexBox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.sdsForanea2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDescSector;
        private System.Windows.Forms.Label labCodeSector;
        private SdsTexBox.SdsTexBox sdstxtRegion;
        private WookieCodeControls.sdsForanea sdsForaneaRegion;
        private SdsTexBox.SdsTexBox sdstxtDescSector;
        private SdsTexBox.SdsTexBox sdstxtCodeSector;
        private WookieCodeControls.sdsForanea sdsForanea1;
        private WookieCodeControls.sdsForanea sdsForanea2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private SdsTexBox.SdsTexBox sdsTexBox1;
        private WookieCodeControls.sdsForanea sdsForanea3;
        private SdsTexBox.SdsTexBox sdsTexBox2;
        private SdsTexBox.SdsTexBox sdsTexBox3;
    }
}