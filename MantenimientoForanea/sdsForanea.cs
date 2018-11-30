using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectionClass;
using System.Configuration;

namespace MantenimientoForanea
{
    public partial class sdsForanea : UserControl
    {
        public sdsForanea()
        {
            InitializeComponent();
        }

        private Boolean _Requerit;

        public Boolean Requerit
        {
            get { return _Requerit; }
            set
            {
                _Requerit = value;
            }

        }

        private String _lblCodi;
        public String TextLabel
        {
            get { return _lblCodi; }
            set
            {
                //lblCodi.Text = value;
                _lblCodi = value;
            }

        }

        /*   */
        private String _ControlId;
        public String Control_Id
        {
            get { return _ControlId; }
            set
            {
                _ControlId = value;
            }

        }

        private String _ErrorText;

        public String ErrorText
        {
            get { return _ErrorText; }
            set
            {
                _ErrorText = value;
            }
        }

        private String _NomTaula;

        public String NomTaula
        {
            get { return _NomTaula; }
            set
            {
                _NomTaula = value;
            }
        }

        private String _NomCamp;

        public String NomCamp
        {
            get { return _NomCamp; }
            set
            {
                _NomCamp = value;
            }
        }

        private String _DescCodi;

        public String DescCodi
        {
            get { return _DescCodi; }
            set
            {
                _DescCodi = value;
            }
        }

        //////////////////////////////////////////////////////////////////

        DataSet dts;
        ClassBDD CDB;

        private bool bEsNou = false;


        private void Inicializaciones()
        {
            
        }

        private void txtCode_Validating(object sender, CancelEventArgs e)
        {
            string query = "select " + _DescCodi + " from " + _NomTaula + " where " + _NomCamp + " = " + "'"+txtCode.Text+"'";

            CDB = new ClassBDD();
            dts = CDB.PortaPerConsulta(query);
            if(dts.Tables[0].Rows.Count == 1)
            {
                txtShow.Text = dts.Tables[0].Rows[0][DescCodi].ToString();
            }
            
        }
    }
}
