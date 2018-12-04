namespace WookieTablas
{
    partial class Routes
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
            this.sdsTextBoxCodeRoute = new SdsTexBox.SdsTexBox();
            this.sdsTextBoxDescRoute = new SdsTexBox.SdsTexBox();
            this.sdsForaneaRouteTypes = new WookieCodeControls.sdsForanea();
            this.sdsTextBoxRouteTypes = new SdsTexBox.SdsTexBox();
            this.SuspendLayout();
            // 
            // sdsTextBoxCodeRoute
            // 
            this.sdsTextBoxCodeRoute.CodeSector = null;
            this.sdsTextBoxCodeRoute.ColumnName = "CodeRoute";
            this.sdsTextBoxCodeRoute.DescCodi = null;
            this.sdsTextBoxCodeRoute.Location = new System.Drawing.Point(141, 179);
            this.sdsTextBoxCodeRoute.Name = "sdsTextBoxCodeRoute";
            this.sdsTextBoxCodeRoute.Nom = null;
            this.sdsTextBoxCodeRoute.NomBBDD = "SecureCore";
            this.sdsTextBoxCodeRoute.NomCamp = null;
            this.sdsTextBoxCodeRoute.NomControl = null;
            this.sdsTextBoxCodeRoute.NomTaula = "Routes";
            this.sdsTextBoxCodeRoute.Requerit = false;
            this.sdsTextBoxCodeRoute.SiEsForana = false;
            this.sdsTextBoxCodeRoute.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBoxCodeRoute.TabIndex = 0;
            // 
            // sdsTextBoxDescRoute
            // 
            this.sdsTextBoxDescRoute.CodeSector = null;
            this.sdsTextBoxDescRoute.ColumnName = "DescRoute";
            this.sdsTextBoxDescRoute.DescCodi = null;
            this.sdsTextBoxDescRoute.Location = new System.Drawing.Point(141, 226);
            this.sdsTextBoxDescRoute.Name = "sdsTextBoxDescRoute";
            this.sdsTextBoxDescRoute.Nom = null;
            this.sdsTextBoxDescRoute.NomBBDD = "SecureCore";
            this.sdsTextBoxDescRoute.NomCamp = null;
            this.sdsTextBoxDescRoute.NomControl = null;
            this.sdsTextBoxDescRoute.NomTaula = "Routes";
            this.sdsTextBoxDescRoute.Requerit = false;
            this.sdsTextBoxDescRoute.SiEsForana = false;
            this.sdsTextBoxDescRoute.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBoxDescRoute.TabIndex = 0;
            // 
            // sdsForaneaRouteTypes
            // 
            this.sdsForaneaRouteTypes.Control_Id = "sdsTextBoxRouteTypes";
            this.sdsForaneaRouteTypes.DescCodi = "DescRouteType";
            this.sdsForaneaRouteTypes.ErrorText = null;
            this.sdsForaneaRouteTypes.Location = new System.Drawing.Point(0, 276);
            this.sdsForaneaRouteTypes.Margin = new System.Windows.Forms.Padding(2);
            this.sdsForaneaRouteTypes.Name = "sdsForaneaRouteTypes";
            this.sdsForaneaRouteTypes.NomCamp = "CodeRouteType";
            this.sdsForaneaRouteTypes.NomControl = "txtIDRoute";
            this.sdsForaneaRouteTypes.NomID = "idRouteType";
            this.sdsForaneaRouteTypes.NomTaula = "RouteTypes";
            this.sdsForaneaRouteTypes.Requerit = false;
            this.sdsForaneaRouteTypes.Size = new System.Drawing.Size(391, 46);
            this.sdsForaneaRouteTypes.TabIndex = 24;
            this.sdsForaneaRouteTypes.TextLabel = "Tipus de Ruta";
            // 
            // sdsTextBoxRouteTypes
            // 
            this.sdsTextBoxRouteTypes.CodeSector = null;
            this.sdsTextBoxRouteTypes.ColumnName = "idRouteType";
            this.sdsTextBoxRouteTypes.DescCodi = null;
            this.sdsTextBoxRouteTypes.Location = new System.Drawing.Point(319, 235);
            this.sdsTextBoxRouteTypes.Name = "sdsTextBoxRouteTypes";
            this.sdsTextBoxRouteTypes.Nom = null;
            this.sdsTextBoxRouteTypes.NomBBDD = "SecureCore";
            this.sdsTextBoxRouteTypes.NomCamp = "idRouteType";
            this.sdsTextBoxRouteTypes.NomControl = "sdsForaneaRouteTypes";
            this.sdsTextBoxRouteTypes.NomTaula = "Routes";
            this.sdsTextBoxRouteTypes.Requerit = false;
            this.sdsTextBoxRouteTypes.SiEsForana = true;
            this.sdsTextBoxRouteTypes.Size = new System.Drawing.Size(20, 20);
            this.sdsTextBoxRouteTypes.TabIndex = 0;
            // 
            // Routes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sdsTextBoxRouteTypes);
            this.Controls.Add(this.sdsForaneaRouteTypes);
            this.Controls.Add(this.sdsTextBoxDescRoute);
            this.Controls.Add(this.sdsTextBoxCodeRoute);
            this.Name = "Routes";
            this.Text = "Routes";
            this.Load += new System.EventHandler(this.Routes_Load);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.sdsTextBoxCodeRoute, 0);
            this.Controls.SetChildIndex(this.sdsTextBoxDescRoute, 0);
            this.Controls.SetChildIndex(this.sdsForaneaRouteTypes, 0);
            this.Controls.SetChildIndex(this.sdsTextBoxRouteTypes, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SdsTexBox.SdsTexBox sdsTextBoxCodeRoute;
        private SdsTexBox.SdsTexBox sdsTextBoxDescRoute;
        private WookieCodeControls.sdsForanea sdsForaneaRouteTypes;
        private SdsTexBox.SdsTexBox sdsTextBoxRouteTypes;
    }
}