﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace SdsTexBox
{
    public class SdsTexBox : TextBox
    {
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
            //////////PROPIETATS///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            public enum Num { Numero = 1, txt = 2, data = 3, Mail = 4, Telf = 5 }
            private Num _TipusDada;
            public Num TipusDada
            {
                get
                {
                    return _TipusDada;
                }
                set
                {
                    _TipusDada = value;
                }
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
            private String _NomBBDD;
            private TextBox textBox1;
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

            /////////////////////////METODES///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            private void ValidaDades()
            {

                if (Num.txt == TipusDada && RegexUtil.MatchKey(Text, TipusDada))
                {
                    //MessageBox.Show("Es Lletra");
                }
                else if (Num.Numero == TipusDada && RegexUtil.MatchKey(Text, TipusDada))
                {
                    //MessageBox.Show("Es numero");
                }
                else if (Num.data == TipusDada && DateTime.TryParse(Text, out DateTime fecha))
                {
                    //MessageBox.Show("Es data");
                }
                else if (Num.Mail == TipusDada && RegexUtil.MatchKey(Text, TipusDada))
                {
                    //MessageBox.Show("Mail correcte");
                }
                else if (Num.Telf == TipusDada && RegexUtil.MatchKey(Text, TipusDada))
                {
                    //MessageBox.Show("es correcte");
                }
                else
                {
                    ForeColor = Color.Red;
                    MessageBox.Show("Format de dades incorrecte!");
                    Clear();
                    Focus();

                }
            }
            private void TxtCode_Validated(object sender, EventArgs e)
            {
                ValidaDades();
            }

            private void TxtCode_TextChanged(object sender, EventArgs e)
            {
                Focus();
                BackColor = Color.LightGreen;
            }
            private void TxtCode_Leave(object sender, EventArgs e)
            {
                BackColor = Color.White;
            }
            static class RegexUtil
            {
                static Regex _regexTxt = new Regex(@"([a-zA-Z])$");
                static Regex _regexNum = new Regex(@"([0-9])$");
                static Regex _regexMail = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
                static Regex _regexTelf = new Regex(@"^([0-9]{9})$");

                static public bool MatchKey(string input, Num tipus)
                {
                    Match matchtxt = _regexTxt.Match(input.ToLower());
                    Match matchNum = _regexNum.Match(input);
                    Match matchMail = _regexMail.Match(input);
                    Match matchTelf = _regexTelf.Match(input);

                    if (matchtxt.Success && Num.txt == tipus)
                    {
                        return true;
                    }

                    else if (matchNum.Success && Num.Numero == tipus)
                    {
                        return true;
                    }
                    else if (matchMail.Success && Num.Mail == tipus)
                    {
                        return true;
                    }
                    else if (matchTelf.Success && Num.Telf == tipus)
                    {
                        if (input.Length == 9)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            private void InitializeComponent()
            {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SdsTexBox
            // 
            this.TextChanged += new System.EventHandler(this.TxtCode_TextChanged);
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
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }

