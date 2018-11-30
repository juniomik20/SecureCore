namespace WookieCodeControls
{
    partial class ConsejoMenu
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonConsejo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonConsejo
            // 
            this.ButtonConsejo.Location = new System.Drawing.Point(0, 0);
            this.ButtonConsejo.Name = "ButtonConsejo";
            this.ButtonConsejo.Size = new System.Drawing.Size(99, 31);
            this.ButtonConsejo.TabIndex = 0;
            this.ButtonConsejo.Text = "Text";
            this.ButtonConsejo.UseVisualStyleBackColor = true;
            this.ButtonConsejo.Click += new System.EventHandler(this.ObreForm);
            // 
            // ConsejoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonConsejo);
            this.Name = "ConsejoMenu";
            this.Size = new System.Drawing.Size(99, 31);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonConsejo;
    }
}
