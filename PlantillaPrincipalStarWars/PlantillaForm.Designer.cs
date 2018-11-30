namespace PlantillaPrincipalStarWars
{
    partial class PlantillaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlantillaForm));
            this.PanelTableTitle = new System.Windows.Forms.TableLayoutPanel();
            this.ExitButtonTitle = new System.Windows.Forms.PictureBox();
            this.UsernameTitle = new System.Windows.Forms.Label();
            this.TittleScreen = new System.Windows.Forms.Label();
            this.UserIconTitle = new System.Windows.Forms.PictureBox();
            this.ButtonAtras = new System.Windows.Forms.PictureBox();
            this.PanelTableTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButtonTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTableTitle
            // 
            this.PanelTableTitle.AutoSize = true;
            this.PanelTableTitle.BackColor = System.Drawing.Color.Transparent;
            this.PanelTableTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelTableTitle.ColumnCount = 5;
            this.PanelTableTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.PanelTableTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTableTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.PanelTableTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.PanelTableTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.PanelTableTitle.Controls.Add(this.ExitButtonTitle, 4, 0);
            this.PanelTableTitle.Controls.Add(this.UsernameTitle, 2, 0);
            this.PanelTableTitle.Controls.Add(this.TittleScreen, 1, 0);
            this.PanelTableTitle.Controls.Add(this.UserIconTitle, 3, 0);
            this.PanelTableTitle.Controls.Add(this.ButtonAtras, 0, 0);
            this.PanelTableTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTableTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTableTitle.Margin = new System.Windows.Forms.Padding(10);
            this.PanelTableTitle.Name = "PanelTableTitle";
            this.PanelTableTitle.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.PanelTableTitle.RowCount = 1;
            this.PanelTableTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTableTitle.Size = new System.Drawing.Size(841, 95);
            this.PanelTableTitle.TabIndex = 0;
            // 
            // ExitButtonTitle
            // 
            this.ExitButtonTitle.BackgroundImage = global::PlantillaPrincipalStarWars.Properties.Resources.exit;
            this.ExitButtonTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitButtonTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitButtonTitle.Location = new System.Drawing.Point(748, 18);
            this.ExitButtonTitle.Name = "ExitButtonTitle";
            this.ExitButtonTitle.Size = new System.Drawing.Size(80, 64);
            this.ExitButtonTitle.TabIndex = 3;
            this.ExitButtonTitle.TabStop = false;
            this.ExitButtonTitle.Click += new System.EventHandler(this.ExitButtonTitle_Click);
            // 
            // UsernameTitle
            // 
            this.UsernameTitle.AutoSize = true;
            this.UsernameTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsernameTitle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTitle.ForeColor = System.Drawing.Color.White;
            this.UsernameTitle.Location = new System.Drawing.Point(468, 15);
            this.UsernameTitle.Name = "UsernameTitle";
            this.UsernameTitle.Size = new System.Drawing.Size(153, 70);
            this.UsernameTitle.TabIndex = 2;
            this.UsernameTitle.Text = "UserName";
            this.UsernameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TittleScreen
            // 
            this.TittleScreen.AutoSize = true;
            this.TittleScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TittleScreen.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TittleScreen.ForeColor = System.Drawing.Color.White;
            this.TittleScreen.Location = new System.Drawing.Point(91, 15);
            this.TittleScreen.Name = "TittleScreen";
            this.TittleScreen.Size = new System.Drawing.Size(371, 70);
            this.TittleScreen.TabIndex = 0;
            this.TittleScreen.Text = "Nombre de la pantalla";
            this.TittleScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserIconTitle
            // 
            this.UserIconTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserIconTitle.Location = new System.Drawing.Point(627, 18);
            this.UserIconTitle.Name = "UserIconTitle";
            this.UserIconTitle.Size = new System.Drawing.Size(115, 64);
            this.UserIconTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserIconTitle.TabIndex = 1;
            this.UserIconTitle.TabStop = false;
            // 
            // ButtonAtras
            // 
            this.ButtonAtras.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonAtras.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAtras.Image")));
            this.ButtonAtras.Location = new System.Drawing.Point(13, 18);
            this.ButtonAtras.Name = "ButtonAtras";
            this.ButtonAtras.Size = new System.Drawing.Size(71, 64);
            this.ButtonAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonAtras.TabIndex = 4;
            this.ButtonAtras.TabStop = false;
            this.ButtonAtras.Visible = false;
            this.ButtonAtras.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PlantillaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 561);
            this.Controls.Add(this.PanelTableTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlantillaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = ".";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelTableTitle.ResumeLayout(false);
            this.PanelTableTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButtonTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelTableTitle;
        private System.Windows.Forms.PictureBox ExitButtonTitle;
        public System.Windows.Forms.PictureBox UserIconTitle;
        public System.Windows.Forms.Label UsernameTitle;
        public System.Windows.Forms.Label TittleScreen;
        public System.Windows.Forms.PictureBox ButtonAtras;
    }
}

