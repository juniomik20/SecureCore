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
using ConnectionClass;

namespace MantenimientoTest
{
    public partial class MantenimentBase : PlantillaPrincipalStarWars.PlantillaForm
    {
        DataSet dts;
       
        ClassBDD CDB;
        public bool bEsNou = false;
        public string query ="Select * from Planets";
        public string id="idPlanet";
        

        public MantenimentBase()
        {
          

            InitializeComponent();
        }

        private void Inicializaciones()
        {
            CDB = new ClassBDD();
            SdsTextBox CSDStxtBox = new SdsTextBox();
            dts = CDB.PortaPerConsulta(query);
            RellenarDataGrid(dts);
            dgvMant_table.AllowUserToAddRows = false;
        }
        private void RellenarDataGrid(DataSet dataset)
        {
            dgvMant_table.DataSource = dts.Tables[0];
            this.dgvMant_table.Columns[id].Visible = false;
            BindDades();
        }
        private void BindDades()
        {
            foreach (Control sdsControl in this.Controls)
            {
                if (sdsControl is SdsTextBox)
                {
                    ((SdsTextBox)sdsControl).DataBindings.Clear();
                    ((SdsTextBox)sdsControl).DataBindings.Add("Text", dts.Tables[0], ((SdsTextBox)sdsControl).ColumnName.ToString());
                    ((SdsTextBox)sdsControl).Validated += new EventHandler(Validar);
                }
            }
        }
        private void QuitarBindDades()
        {
            foreach (Control sdsControl in this.Controls)
            {
                if (sdsControl is SdsTextBox)
                {
                    ((SdsTextBox)sdsControl).DataBindings.Clear();
                    sdsControl.Text = "";             
                }
            }
        }
        private void AñadirFila()
        {
            string nomCamp = ""; 
            DataRow dr = dts.Tables[0].NewRow();
            foreach (Control sdsControl in this.Controls)
            {
                if (sdsControl is SdsTextBox)
                {
                    nomCamp = ((SdsTextBox)sdsControl).ColumnName;
                    dr[nomCamp] = sdsControl.Text;
                    
                }
            }
            dts.Tables[0].Rows.Add(dr);
        }

        public void Validar(object sender, EventArgs e)
        {
            if (!bEsNou)
            {
                ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }        
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!bEsNou)
            {
                CDB.Actualitzar(dts, query);
            }
            else
            {
                AñadirFila();
                CDB.Actualitzar(dts, query);
                BindDades();
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            bEsNou = true;
            QuitarBindDades();
            //SdsTextBox.Nom.Focus();

        }
        private void FrmMant_Table_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            
            Inicializaciones();
            Actualizar();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public void Actualizar() {
            ButtonAtras.Visible = true;
            TittleScreen.Text = " Mantenimiento de UserRanks";
            this.Username = ConfigurationManager.AppSettings["UserName"].ToString();
            this.IconUser = ConfigurationManager.AppSettings["Icon"].ToString();
        }

    }
}
