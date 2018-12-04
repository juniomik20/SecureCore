using MantenimientoBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaCerca
{
    public partial class Cerca : Form
    {
        private string _TableName;

        public string TableName
        {
            get { return _TableName; }
            set { _TableName = value; }
        }

        private string _ControlName;

        public string ControlName
        {
            get { return _ControlName; }
            set { _ControlName = value; }
        }

        public Cerca()
        {
            InitializeComponent();
        }

        public Cerca(string TableName, string ControlName)
        {
            InitializeComponent();

            this.TableName = TableName;
            this.ControlName = ControlName;
        }
        #region Variables
        //Creamos el dataset
        DataSet dts;
        //Instanciamos la ConnectionClass
        ConnectionClass.ClassBDD BDD = new ConnectionClass.ClassBDD();
        //Hacemos la consulta
        public string query /*= "select * from Sectors"*/;

        #endregion

        #region Metodos
        public void Inicializar()
        {
            query = "select * from " + TableName;
            dts = BDD.PortaPerConsulta(query);
        }
        public void RellenarGrid(DataSet dts)
        {
            dGVCerca.DataSource = dts.Tables[0];
            dGVCerca.Columns[0].Visible = false;
        }
        public void Bindings()
        {

        }
        #endregion

        #region Eventos
        private void Cerca_Load(object sender, EventArgs e)
        {
            //al cargar utilice el metodo RellenarGrid
            Inicializar();
            RellenarGrid(dts);
            dGVCerca.AllowUserToAddRows = false;
        }

        #endregion

        private void dGVCerca_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(dGVCerca.SelectedCells[0].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Selecciona toda la linea.");
            }
        }
    }
}
