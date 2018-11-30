namespace WookieTablas
{
    partial class RouteTypes
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
            this.sdsTextBoxCodeRoute = new MantenimientoTest.SdsTextBox();
            this.sdsTextBoxDescRoute = new MantenimientoTest.SdsTextBox();
            this.lblCodeRouteType = new System.Windows.Forms.Label();
            this.lblDescRouteType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sdsTextBoxCodeRoute
            // 
            this.sdsTextBoxCodeRoute.BackColor = System.Drawing.Color.LightGreen;
            this.sdsTextBoxCodeRoute.CodeSector = null;
            this.sdsTextBoxCodeRoute.ColumnName = "CodeRouteType";
            this.sdsTextBoxCodeRoute.DescCodi = null;
            this.sdsTextBoxCodeRoute.Location = new System.Drawing.Point(155, 158);
            this.sdsTextBoxCodeRoute.Name = "sdsTextBoxCodeRoute";
            this.sdsTextBoxCodeRoute.Nom = null;
            this.sdsTextBoxCodeRoute.NomBBDD = "SecureCore";
            this.sdsTextBoxCodeRoute.NomCamp = null;
            this.sdsTextBoxCodeRoute.NomControl = null;
            this.sdsTextBoxCodeRoute.NomTaula = "RouteTypes";
            this.sdsTextBoxCodeRoute.Requerit = true;
            this.sdsTextBoxCodeRoute.SiEsForana = false;
            this.sdsTextBoxCodeRoute.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBoxCodeRoute.TabIndex = 9;
            // 
            // sdsTextBoxDescRoute
            // 
            this.sdsTextBoxDescRoute.BackColor = System.Drawing.Color.LightGreen;
            this.sdsTextBoxDescRoute.CodeSector = null;
            this.sdsTextBoxDescRoute.ColumnName = "DescRouteType";
            this.sdsTextBoxDescRoute.DescCodi = null;
            this.sdsTextBoxDescRoute.Location = new System.Drawing.Point(155, 214);
            this.sdsTextBoxDescRoute.Name = "sdsTextBoxDescRoute";
            this.sdsTextBoxDescRoute.Nom = null;
            this.sdsTextBoxDescRoute.NomBBDD = "SecureCore";
            this.sdsTextBoxDescRoute.NomCamp = null;
            this.sdsTextBoxDescRoute.NomControl = null;
            this.sdsTextBoxDescRoute.NomTaula = "RouteTypes";
            this.sdsTextBoxDescRoute.Requerit = false;
            this.sdsTextBoxDescRoute.SiEsForana = false;
            this.sdsTextBoxDescRoute.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBoxDescRoute.TabIndex = 10;
            // 
            // lblCodeRouteType
            // 
            this.lblCodeRouteType.AutoSize = true;
            this.lblCodeRouteType.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeRouteType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCodeRouteType.Location = new System.Drawing.Point(27, 161);
            this.lblCodeRouteType.Name = "lblCodeRouteType";
            this.lblCodeRouteType.Size = new System.Drawing.Size(88, 13);
            this.lblCodeRouteType.TabIndex = 11;
            this.lblCodeRouteType.Text = "CodeRouteType:";
            // 
            // lblDescRouteType
            // 
            this.lblDescRouteType.AutoSize = true;
            this.lblDescRouteType.BackColor = System.Drawing.Color.Transparent;
            this.lblDescRouteType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescRouteType.Location = new System.Drawing.Point(27, 217);
            this.lblDescRouteType.Name = "lblDescRouteType";
            this.lblDescRouteType.Size = new System.Drawing.Size(88, 13);
            this.lblDescRouteType.TabIndex = 12;
            this.lblDescRouteType.Text = "DescRouteType:";
            // 
            // RouteTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDescRouteType);
            this.Controls.Add(this.lblCodeRouteType);
            this.Controls.Add(this.sdsTextBoxDescRoute);
            this.Controls.Add(this.sdsTextBoxCodeRoute);
            this.Name = "RouteTypes";
            this.Text = "RouteTypes";
            this.Load += new System.EventHandler(this.RouteTypes_Load);
            this.Controls.SetChildIndex(this.sdsTextBoxCodeRoute, 0);
            this.Controls.SetChildIndex(this.sdsTextBoxDescRoute, 0);
            this.Controls.SetChildIndex(this.lblCodeRouteType, 0);
            this.Controls.SetChildIndex(this.lblDescRouteType, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MantenimientoTest.SdsTextBox sdsTextBoxCodeRoute;
        private MantenimientoTest.SdsTextBox sdsTextBoxDescRoute;
        private System.Windows.Forms.Label lblCodeRouteType;
        private System.Windows.Forms.Label lblDescRouteType;
    }
}