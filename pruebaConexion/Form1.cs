using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectionClass;
namespace pruebaConexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {


        }




        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            try
            {
            int id = Int32.Parse(textBox1.Text.ToString());
            ConnectionClass.ClassBDD connect = new ConnectionClass.ClassBDD();
            DataSet dts;
            dts = connect.PortarPerID("Nova",id);
            dataGridView1.DataSource = dts.Tables[0];
            }
            catch (Exception)
            {

                label1.Text = "Error al mostrar los datos";
            }
          
            


        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    label1.Text = "";
            
        //        int id = Int32.Parse(textBox1.Text.ToString());
        //        ConnectionClass.Class1 connect = new ConnectionClass.Class1();
        //        DataSet dts;
        //        dts = connect.portarPerID("TableProva",id);
        //        dataGridView1.DataSource = dts.Tables[0];
            
          
        //}
        private void Button3_Click(object sender, EventArgs e)
        {

            ConnectionClass.ClassBDD connect = new ConnectionClass.ClassBDD();
            DataSet dts;
            string strQuery = "SELECT Nova.CodiNova, Nova.DescNova, TableProva.nombre, TableProva.raza FROM Nova INNER JOIN TableProva ON Nova.idTableNova = TableProva.idProva WHERE (Nova.IdNova = 1)";
           // dts = connect.portaPerConsulta(strQuery);
      //     dataGridView1.DataSource = dts.Tables[0];


        }


    }
}
