using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoForanea
{
    public partial class FormForanea : MantenimientoTest.MantenimentBase
    {
        public FormForanea()
        {
          

            InitializeComponent();
        }

        private void FormForanea_Load(object sender, EventArgs e)
        {
            this.ButtonAtras.Visible = true;
            this.TittleScreen.Text = " Mantenimiento de Foraneas";
        }
    }
}
