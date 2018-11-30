using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsejoJedai
{
    public partial class ConsejoForm : PlantillaPrincipalStarWars.PlantillaForm
    {
        public ConsejoForm()
        {
            InitializeComponent();
            
        }

        private void ConsejoForm_Load(object sender, EventArgs e)
        {
           
            if (DesignMode) return;
            CargarFlow();
            Actualizar();
         

        }

        void CargarFlow() {
            var db = new ConnectionClass.ClassBDD();
            DataSet dts;
           
            dts = db.PortaPerConsulta("SELECT * FROM INFORMATION_SCHEMA.TABLES where TABLE_NAME!='sysdiagrams' ");

            int cont = 0;
            foreach (DataRow dr in dts.Tables[0].Rows)
            {

                var MenuItem = new WookieCodeControls.ConsejoMenu
                {
                    LblText = dr["TABLE_NAME"].ToString(),
                    NameClass = "WookieTablas.dll",
                    NameForm = "WookieTablas."+dr["TABLE_NAME"].ToString(),
                    Location = new Point(10 + (cont * 100), 30)
                };

                PanelButtonsMain.Controls.Add(MenuItem);
                cont = cont + 1;
            }

        }
        private void Actualizar()
        {
            ButtonAtras.Visible = true;
            TittleScreen.Text = "Consejo Jedi";
            this.Username = ConfigurationManager.AppSettings["UserName"].ToString();
            this.IconUser = ConfigurationManager.AppSettings["Icon"].ToString();
        }

        
    }
}
