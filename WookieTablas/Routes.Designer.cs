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
            this.lblCodeRoute = new System.Windows.Forms.Label();
            this.lblDescRoute = new System.Windows.Forms.Label();
            this.sdsTextBoxCodeRoute = new MantenimientoBase.SdsTextBox();
            this.sdsTextBoxDescRoute = new MantenimientoBase.SdsTextBox();
            this.sdsTextBoxRouteTypes = new MantenimientoBase.SdsTextBox();
            this.sdsForaneaRouteTypes = new WookieCodeControls.sdsForanea();
            this.SuspendLayout();
            // 
            // lblCodeRoute
            // 
            this.lblCodeRoute.AutoSize = true;
            this.lblCodeRoute.Location = new System.Drawing.Point(114, 146);
            this.lblCodeRoute.Name = "lblCodeRoute";
            this.lblCodeRoute.Size = new System.Drawing.Size(67, 13);
            this.lblCodeRoute.TabIndex = 24;
            this.lblCodeRoute.Text = "Code Route:";
            // 
            // lblDescRoute
            // 
            this.lblDescRoute.AutoSize = true;
            this.lblDescRoute.Location = new System.Drawing.Point(114, 191);
            this.lblDescRoute.Name = "lblDescRoute";
            this.lblDescRoute.Size = new System.Drawing.Size(67, 13);
            this.lblDescRoute.TabIndex = 25;
            this.lblDescRoute.Text = "Desc Route:";
            // 
            // sdsTextBoxCodeRoute
            // 
            this.sdsTextBoxCodeRoute.CodeSector = null;
            this.sdsTextBoxCodeRoute.ColumnName = "CodeRoute";
            this.sdsTextBoxCodeRoute.DescCodi = null;
            this.sdsTextBoxCodeRoute.Location = new System.Drawing.Point(207, 143);
            this.sdsTextBoxCodeRoute.Name = "sdsTextBoxCodeRoute";
            this.sdsTextBoxCodeRoute.Nom = null;
            this.sdsTextBoxCodeRoute.NomBBDD = "SecureCore";
            this.sdsTextBoxCodeRoute.NomCamp = null;
            this.sdsTextBoxCodeRoute.NomControl = null;
            this.sdsTextBoxCodeRoute.NomTaula = "Routes";
            this.sdsTextBoxCodeRoute.Requerit = false;
            this.sdsTextBoxCodeRoute.SiEsForana = false;
            this.sdsTextBoxCodeRoute.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBoxCodeRoute.TabIndex = 26;
            // 
            // sdsTextBoxDescRoute
            // 
            this.sdsTextBoxDescRoute.CodeSector = null;
            this.sdsTextBoxDescRoute.ColumnName = "DescRoute";
            this.sdsTextBoxDescRoute.DescCodi = null;
            this.sdsTextBoxDescRoute.Location = new System.Drawing.Point(207, 188);
            this.sdsTextBoxDescRoute.Name = "sdsTextBoxDescRoute";
            this.sdsTextBoxDescRoute.Nom = null;
            this.sdsTextBoxDescRoute.NomBBDD = "SecureCore";
            this.sdsTextBoxDescRoute.NomCamp = null;
            this.sdsTextBoxDescRoute.NomControl = null;
            this.sdsTextBoxDescRoute.NomTaula = "Routes";
            this.sdsTextBoxDescRoute.Requerit = false;
            this.sdsTextBoxDescRoute.SiEsForana = false;
            this.sdsTextBoxDescRoute.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBoxDescRoute.TabIndex = 27;
            // 
            // sdsTextBoxRouteTypes
            // 
            this.sdsTextBoxRouteTypes.CodeSector = null;
            this.sdsTextBoxRouteTypes.ColumnName = "idRouteType";
            this.sdsTextBoxRouteTypes.DescCodi = null;
            this.sdsTextBoxRouteTypes.Location = new System.Drawing.Point(344, 197);
            this.sdsTextBoxRouteTypes.Name = "sdsTextBoxRouteTypes";
            this.sdsTextBoxRouteTypes.Nom = null;
            this.sdsTextBoxRouteTypes.NomBBDD = null;
            this.sdsTextBoxRouteTypes.NomCamp = "idRouteType";
            this.sdsTextBoxRouteTypes.NomControl = "sdsForaneaRouteTypes";
            this.sdsTextBoxRouteTypes.NomTaula = "Routes";
            this.sdsTextBoxRouteTypes.Requerit = false;
            this.sdsTextBoxRouteTypes.SiEsForana = true;
            this.sdsTextBoxRouteTypes.Size = new System.Drawing.Size(20, 20);
            this.sdsTextBoxRouteTypes.TabIndex = 28;
            // 
            // sdsForaneaRouteTypes
            // 
            this.sdsForaneaRouteTypes.Control_Id = "txtidRoute";
            this.sdsForaneaRouteTypes.DescCodi = "DescRouteType";
            this.sdsForaneaRouteTypes.ErrorText = null;
            this.sdsForaneaRouteTypes.Location = new System.Drawing.Point(0, 246);
            this.sdsForaneaRouteTypes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sdsForaneaRouteTypes.Name = "sdsForaneaRouteTypes";
            this.sdsForaneaRouteTypes.NomCamp = "CodeRouteType";
            this.sdsForaneaRouteTypes.NomControl = "txtIDRoute";
            this.sdsForaneaRouteTypes.NomID = "idRouteType";
            this.sdsForaneaRouteTypes.NomTaula = "RouteTypes";
            this.sdsForaneaRouteTypes.Requerit = false;
            this.sdsForaneaRouteTypes.Size = new System.Drawing.Size(391, 46);
            this.sdsForaneaRouteTypes.TabIndex = 29;
            this.sdsForaneaRouteTypes.TextLabel = "Tipus de Ruta";
            // 
            // Routes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sdsForaneaRouteTypes);
            this.Controls.Add(this.sdsTextBoxRouteTypes);
            this.Controls.Add(this.sdsTextBoxDescRoute);
            this.Controls.Add(this.sdsTextBoxCodeRoute);
            this.Controls.Add(this.lblDescRoute);
            this.Controls.Add(this.lblCodeRoute);
            this.Name = "Routes";
            this.Text = "Routes";
            this.Load += new System.EventHandler(this.Routes_Load);
            this.Controls.SetChildIndex(this.lblCodeRoute, 0);
            this.Controls.SetChildIndex(this.lblDescRoute, 0);
            this.Controls.SetChildIndex(this.sdsTextBoxCodeRoute, 0);
            this.Controls.SetChildIndex(this.sdsTextBoxDescRoute, 0);
            this.Controls.SetChildIndex(this.sdsTextBoxRouteTypes, 0);
            this.Controls.SetChildIndex(this.sdsForaneaRouteTypes, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeRoute;
        private System.Windows.Forms.Label lblDescRoute;
        private MantenimientoBase.SdsTextBox sdsTextBoxCodeRoute;
        private MantenimientoBase.SdsTextBox sdsTextBoxDescRoute;
        private MantenimientoBase.SdsTextBox sdsTextBoxRouteTypes;
        private WookieCodeControls.sdsForanea sdsForaneaRouteTypes;
    }
}