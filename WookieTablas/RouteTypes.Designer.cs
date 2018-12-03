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
            this.sdsTexBoxCodeRouteType = new SdsTexBox.SdsTexBox();
            this.sdsTexBoxDescRouteType = new SdsTexBox.SdsTexBox();
            this.SuspendLayout();
            // 
            // sdsTexBoxCodeRouteType
            // 
            this.sdsTexBoxCodeRouteType.ColumnName = "CodeRouteType";
            this.sdsTexBoxCodeRouteType.Location = new System.Drawing.Point(131, 201);
            this.sdsTexBoxCodeRouteType.Name = "sdsTexBoxCodeRouteType";
            this.sdsTexBoxCodeRouteType.Nom = null;
            this.sdsTexBoxCodeRouteType.NomBBDD = "SecureCore";
            this.sdsTexBoxCodeRouteType.Requerit = false;
            this.sdsTexBoxCodeRouteType.SiEsForana = false;
            this.sdsTexBoxCodeRouteType.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBoxCodeRouteType.TabIndex = 24;
            // 
            // sdsTexBoxDescRouteType
            // 
            this.sdsTexBoxDescRouteType.ColumnName = "DescRouteType";
            this.sdsTexBoxDescRouteType.Location = new System.Drawing.Point(131, 258);
            this.sdsTexBoxDescRouteType.Name = "sdsTexBoxDescRouteType";
            this.sdsTexBoxDescRouteType.Nom = null;
            this.sdsTexBoxDescRouteType.NomBBDD = "SecureCore";
            this.sdsTexBoxDescRouteType.Requerit = false;
            this.sdsTexBoxDescRouteType.SiEsForana = false;
            this.sdsTexBoxDescRouteType.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBoxDescRouteType.TabIndex = 25;
            // 
            // RouteTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 595);
            this.Controls.Add(this.sdsTexBoxDescRouteType);
            this.Controls.Add(this.sdsTexBoxCodeRouteType);
            this.Name = "RouteTypes";
            this.Text = "RouteTypes";
            this.Load += new System.EventHandler(this.RouteTypes_Load);
            this.Controls.SetChildIndex(this.sdsTexBoxCodeRouteType, 0);
            this.Controls.SetChildIndex(this.sdsTexBoxDescRouteType, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SdsTexBox.SdsTexBox sdsTexBoxCodeRouteType;
        private SdsTexBox.SdsTexBox sdsTexBoxDescRouteType;
    }
}