namespace LogonScreen
{
    partial class LogonMainScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogonMainScreen));
            this.UserTitle = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.PasswordTitle = new System.Windows.Forms.Label();
            this.IconStarWars = new System.Windows.Forms.PictureBox();
            this.ButtonEntrar = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GifEasterEgg = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.BarraBottom = new System.Windows.Forms.Panel();
            this.BarraRigth = new System.Windows.Forms.Panel();
            this.BarraTop = new System.Windows.Forms.Panel();
            this.BarraLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.IconStarWars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifEasterEgg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.BarraRigth.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserTitle
            // 
            resources.ApplyResources(this.UserTitle, "UserTitle");
            this.UserTitle.BackColor = System.Drawing.Color.Transparent;
            this.UserTitle.ForeColor = System.Drawing.Color.Gold;
            this.UserTitle.Name = "UserTitle";
            // 
            // UserBox
            // 
            resources.ApplyResources(this.UserBox, "UserBox");
            this.UserBox.Name = "UserBox";
            // 
            // PassBox
            // 
            resources.ApplyResources(this.PassBox, "PassBox");
            this.PassBox.Name = "PassBox";
            // 
            // PasswordTitle
            // 
            resources.ApplyResources(this.PasswordTitle, "PasswordTitle");
            this.PasswordTitle.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordTitle.ForeColor = System.Drawing.Color.Gold;
            this.PasswordTitle.Name = "PasswordTitle";
            // 
            // IconStarWars
            // 
            resources.ApplyResources(this.IconStarWars, "IconStarWars");
            this.IconStarWars.BackColor = System.Drawing.Color.Transparent;
            this.IconStarWars.Name = "IconStarWars";
            this.IconStarWars.TabStop = false;
            this.IconStarWars.Click += new System.EventHandler(this.IconStarWars_Click);
            // 
            // ButtonEntrar
            // 
            this.ButtonEntrar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEntrar.FlatAppearance.BorderSize = 0;
            this.ButtonEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.ButtonEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.ButtonEntrar, "ButtonEntrar");
            this.ButtonEntrar.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonEntrar.Name = "ButtonEntrar";
            this.ButtonEntrar.UseVisualStyleBackColor = false;
            this.ButtonEntrar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ErrorLabel
            // 
            resources.ApplyResources(this.ErrorLabel, "ErrorLabel");
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Name = "ErrorLabel";
            // 
            // buttonExit
            // 
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.ForeColor = System.Drawing.Color.Red;
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // GifEasterEgg
            // 
            resources.ApplyResources(this.GifEasterEgg, "GifEasterEgg");
            this.GifEasterEgg.BackColor = System.Drawing.Color.Transparent;
            this.GifEasterEgg.Name = "GifEasterEgg";
            this.GifEasterEgg.TabStop = false;
            this.GifEasterEgg.Click += new System.EventHandler(this.GifEasterEgg_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.GifEasterEgg_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.GifEasterEgg_Click);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.GifEasterEgg_Click);
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.GifEasterEgg_Click);
            // 
            // pictureBox5
            // 
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.GifEasterEgg_Click);
            // 
            // pictureBox6
            // 
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.GifEasterEgg_Click);
            // 
            // pictureBox7
            // 
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.GifEasterEgg_Click);
            // 
            // BarraBottom
            // 
            this.BarraBottom.BackColor = System.Drawing.Color.OrangeRed;
            resources.ApplyResources(this.BarraBottom, "BarraBottom");
            this.BarraBottom.Name = "BarraBottom";
            // 
            // BarraRigth
            // 
            this.BarraRigth.BackColor = System.Drawing.Color.OrangeRed;
            this.BarraRigth.Controls.Add(this.BarraTop);
            resources.ApplyResources(this.BarraRigth, "BarraRigth");
            this.BarraRigth.Name = "BarraRigth";
            // 
            // BarraTop
            // 
            this.BarraTop.BackColor = System.Drawing.Color.OrangeRed;
            resources.ApplyResources(this.BarraTop, "BarraTop");
            this.BarraTop.Name = "BarraTop";
            // 
            // BarraLeft
            // 
            this.BarraLeft.BackColor = System.Drawing.Color.OrangeRed;
            resources.ApplyResources(this.BarraLeft, "BarraLeft");
            this.BarraLeft.Name = "BarraLeft";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // LogonMainScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraLeft);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.BarraRigth);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.IconStarWars);
            this.Controls.Add(this.BarraBottom);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GifEasterEgg);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.ButtonEntrar);
            this.Controls.Add(this.PasswordTitle);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.UserTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogonMainScreen";
            this.Load += new System.EventHandler(this.LogonMainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IconStarWars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifEasterEgg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.BarraRigth.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserTitle;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label PasswordTitle;
        private System.Windows.Forms.PictureBox IconStarWars;
        private System.Windows.Forms.Button ButtonEntrar;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox GifEasterEgg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel BarraBottom;
        private System.Windows.Forms.Panel BarraRigth;
        private System.Windows.Forms.Panel BarraTop;
        private System.Windows.Forms.Panel BarraLeft;
        private System.Windows.Forms.Panel panel1;
    }
}

