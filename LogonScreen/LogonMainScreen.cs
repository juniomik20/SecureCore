using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Configuration;
using System.Drawing.Text;

namespace LogonScreen
{
    public partial class LogonMainScreen : Form
    {
        private int _countDown = 0;
        bool musicOn = false;
        SoundPlayer player = new SoundPlayer
        {
            SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\CANTINA.wav"
        };
        public LogonMainScreen()
        {
            InitializeComponent();
         
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            ConnectionClass.ClassBDD connect = new ConnectionClass.ClassBDD();
            DataSet dts;
            dts = connect.ComprobarUser(UserBox.Text, PassBox.Text);
            if (dts.Tables[0].Rows.Count == 1)
            {
                ErrorLabel.Visible = true;
                timer1.Start();
                ErrorLabel.Text = "Bienvenido "+ dts.Tables[0].Rows[0]["DescCategory"].ToString() + " "+ dts.Tables[0].Rows[0]["UserName"].ToString();

              
                   
                    ConfigurationManager.AppSettings.Set("UserName", dts.Tables[0].Rows[0]["UserName"].ToString());
                    ConfigurationManager.AppSettings.Set("AccesLevel", dts.Tables[0].Rows[0]["AccessLevel"].ToString());
                    ConfigurationManager.AppSettings.Set("Icon", dts.Tables[0].Rows[0]["Photo"].ToString());

                #region Token
                string idUser = dts.Tables[0].Rows[0]["idUser"].ToString();
                var LoginTicks = DateTime.Now.Ticks;
                string queryToken = "insert into LogUsers (idUser, Token) values ("+idUser+",'"+LoginTicks+"');";
                connect.Executa(queryToken);
                #endregion
            }
            else {
                if (UserBox.Text.ToUpper().Equals("DEATH START"))
                {
                    System.Diagnostics.Process.Start("EstrelladelaMuerte.vbs");
                    MessageBox.Show("Felicidades Ganaste un Porta Vasos!", "SEGUNDO EASTER EGG");                    
                }
                else
                {
                    ErrorLabel.Text = "Error Usuario/Password! ";
                    ErrorLabel.Visible = true;
                    UserBox.Clear();
                    PassBox.Clear();
                    UserBox.Focus();
                }
                
            }
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            _countDown--;
            if (_countDown < 1)
            {
                _countDown = 10;
            }
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LogonMainScreen_Load(object sender, EventArgs e)
        {
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            _countDown = _countDown + 1;
            if (_countDown==2)
            {
                this.Hide();
                ErrorLabel.Visible = false;
               player.Stop();
                Form frm = new MenuSecureCore.MenuForm();
                frm.Show();
            }
        }
        private void IconStarWars_Click(object sender, EventArgs e)
        {
            if (!musicOn)
            {
                player.Play();
                musicOn = true;
                GifEasterEgg.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
            }
        }
        private void GifEasterEgg_Click(object sender, EventArgs e)
        {
            desactviarMusic();
        }
        public void desactviarMusic() {
            if (musicOn)
            {
                player.Stop();
                musicOn = false;
                GifEasterEgg.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;

            }
        }
    }
}
