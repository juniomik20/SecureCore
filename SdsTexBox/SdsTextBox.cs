using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using ConnectionClass;
using System.Data;
using System.ComponentModel;
using Application = System.Windows.Forms.Application;

namespace MantenimientoBase
{
   public class SdsTextBox : TextBox
    {
        public SdsTextBox()
        {
            InitializeComponent();
        }
        //barris menjavergas
        string _Nom;
        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        private string _ColumnName;
        public string ColumnName
        {
            get { return _ColumnName; }
            set { _ColumnName = value; }
        }

        public string _NomControl;
        public string NomControl
        {
            get { return _NomControl; }
            set { _NomControl = value; }
        }
        //////////PROPIETATS///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private Boolean _Requerit;
        public Boolean Requerit
        {
            get { return _Requerit; }
            set
            {
                _Requerit = value;
            }

        }
        private String _NomBBDD;
        private TextBox TextBox1;
        public String NomBBDD
        {
            get { return _NomBBDD; }
            set
            {
                _NomBBDD = value;
            }
        }
        private Boolean _SiEsForana;
        public Boolean SiEsForana
        {
            get { return _SiEsForana; }
            set
            {
                _SiEsForana = value;
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
        private String _CodeSector;
        public String CodeSector
        {
            get { return _CodeSector; }
            set
            {
                _CodeSector = value;
            }
        }
        /////////////////////////METODES///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        
                //MessageBox.Show("Mail correcte");
        
        private void TxtCode_Validated(object sender, EventArgs e)
        {
            //ValidaDades();
        }
        //private void TxtCode_TextChanged(object sender, EventArgs e)
        //{
        //    Focus();
        //    BackColor = Color.LightGreen;

        //}
        private void TxtCode_Leave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
        //static class RegexUtil
        //{
        //    static Regex _regexTxt = new Regex(@"([a-zA-Z])$");
        //    static Regex _regexNum = new Regex(@"([0-9])$");
        //    static Regex _regexMail = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
        //    static Regex _regexTelf = new Regex(@"^([0-9]{9})$");

        //    static public bool MatchKey(string input, Num tipus)
        //    {
        //        Match matchtxt = _regexTxt.Match(input.ToLower());
        //        Match matchNum = _regexNum.Match(input);
        //        Match matchMail = _regexMail.Match(input);
        //        Match matchTelf = _regexTelf.Match(input);
        //        if (matchtxt.Success && Num.txt == tipus)
        //        {
        //            return true;
        //        }
        //        else if (matchNum.Success && Num.Numero == tipus)
        //        {
        //            return true;
        //        }
        //        else if (matchMail.Success && Num.Mail == tipus)
        //        {
        //            return true;
        //        }
        //        else if (matchTelf.Success && Num.Telf == tipus)
        //        {
        //            if (input.Length == 9)
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}
        private void InitializeComponent()
        {
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "TextBox1";
            this.Size = new System.Drawing.Size(100, 20);
            this.TabIndex = 0;
            this.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // SdsTextBox
            // 
            this.Leave += new System.EventHandler(this.TxtCode_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCode_Validating);
            this.Validated += new System.EventHandler(this.TxtCode_Validated);
            this.ResumeLayout(false);

        }
        private void TxtCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Requerit)
            {
                if (Text.Length == 0) e.Cancel = true;
            }
            //if (SiEsForana)
            //{
            //    if (this.Text.Length != 0)
            //    {
            //        Form frm = this.FindForm();
            //        foreach (Control c in this.Controls)
            //        {
            //            if (c.Name == _NomControl)
            //            {
            //                c.Text = this.Text;
            //            }
            //        }
            //    }
            //}

            EsForanea();

        }
        private void EsForanea()
        {
            string nomFormulari = FindForm().Name;

            if (SiEsForana)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == nomFormulari)
                    {
                        foreach (Control frmControl in frm.Controls)
                        {
                            if (frmControl is WookieCodeControls.sdsForanea)
                            {
                                try
                                {
                                    if (frmControl.Name == this.NomControl)
                                    {
                                        frmControl.Text = this.Text;
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("ERROR DE DADES");
                                }

                            }
                        }
                    }
                }
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            EsForanea();
        }
    }
}
