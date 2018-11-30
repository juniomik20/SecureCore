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
            this.sdsTextBox1 = new MantenimientoTest.SdsTextBox();
            this.SuspendLayout();
            // 
            // sdsTextBox1
            // 
            this.sdsTextBox1.ColumnName = "CodeRoute";
            this.sdsTextBox1.Location = new System.Drawing.Point(116, 166);
            this.sdsTextBox1.Name = "sdsTextBox1";
            this.sdsTextBox1.Nom = null;
            this.sdsTextBox1.NomBBDD = "SecureCore";
            this.sdsTextBox1.Requerit = false;
            this.sdsTextBox1.SiEsForana = false;
            this.sdsTextBox1.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBox1.TabIndex = 9;
            this.sdsTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sdsTextBox1_KeyUp);
            // 
            // Routes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sdsTextBox1);
            this.Name = "Routes";
            this.Text = "Routes";
            this.Load += new System.EventHandler(this.Routes_Load);
            this.Controls.SetChildIndex(this.sdsTextBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MantenimientoTest.SdsTextBox sdsTextBox1;
    }
}