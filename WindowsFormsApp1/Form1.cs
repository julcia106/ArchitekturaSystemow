using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Text = "--select--";
            comboBox1.Items.Insert(0, "MOV");
            comboBox1.Items.Insert(1, "ADD");
            comboBox1.Items.Insert(2, "SUB");
            comboBox1.Items.Insert(3, "DEC");

            comboBox2.Text = "--select--";
            comboBox2.Items.Add("AX");
            comboBox2.Items.Add("BX");
            comboBox2.Items.Add("CX");
            comboBox2.Items.Add("DX");
        }

        int AXvalue = 0;
        int BXvalue = 0;
        int CXvalue = 0;
        int DXvalue = 0;

        bool AXisMOV = false;
        bool BXisMOV = false;
        bool CXisMOV = false;
        bool DXisMOV = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("MOV"))
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Proszę podać wartość parametru!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comboBox2.Text.Equals("AX"))
                    {
                        if (BXisMOV == true && textBox1.Text.Equals("BX"))
                        {
                            listBox1.Items.Add("MOV AX , BX ");
                            textBox2.Text = "AX = " + BXvalue.ToString();

                            AXvalue = BXvalue;
                            textBox1.Text = "";
                        }
                        else if (CXisMOV == true && textBox1.Text.Equals("CX"))
                        {
                            listBox1.Items.Add("MOV AX , CX ");
                            textBox2.Text = "AX = " + CXvalue.ToString();

                            AXvalue = CXvalue;
                            textBox1.Text = "";
                        }
                        else if (DXisMOV == true && textBox1.Text.Equals("DX"))
                        {
                            listBox1.Items.Add("MOV AX , DX ");
                            textBox2.Text = "AX = " + DXvalue.ToString();

                            AXvalue = DXvalue;
                            textBox1.Text = "";
                        }
                        else
                        {
                            AXvalue = (Convert.ToInt32(textBox1.Text));
                            textBox2.Text = "AX = " + textBox1.Text;
                            listBox1.Items.Add("MOV " + "AX , " + AXvalue);

                            textBox1.Text = "";
                            AXisMOV = true;
                        }
                    }
                    else if (comboBox2.Text.Equals("BX"))
                    {
                        if (AXisMOV == true && textBox1.Text.Equals("AX"))
                        {
                            listBox1.Items.Add("MOV BX , AX ");
                            textBox2.Text = "BX = " + AXvalue.ToString();

                            BXvalue = AXvalue;
                            textBox1.Text = "";
                        }
                        else if (CXisMOV == true && textBox1.Text.Equals("CX"))
                        {
                            listBox1.Items.Add("MOV BX , CX ");
                            textBox2.Text = "BX = " + CXvalue.ToString();

                            BXvalue = CXvalue;
                            textBox1.Text = "";
                        }
                        else if (DXisMOV == true && textBox1.Text.Equals("DX"))
                        {
                            listBox1.Items.Add("MOV BX , DX ");
                            textBox2.Text = "BX = " + DXvalue.ToString();

                            BXvalue = DXvalue;
                            textBox1.Text = "";
                        }
                        else
                        {
                            BXvalue = (Convert.ToInt32(textBox1.Text));
                            textBox2.Text = "BX = " + textBox1.Text;
                            listBox1.Items.Add("MOV " + "BX , " + BXvalue);
                            textBox1.Text = "";
                            BXisMOV = true;
                        }
                    }
                    else if (comboBox2.Text.Equals("CX"))
                    {
                        if (AXisMOV == true && textBox1.Text.Equals("AX"))
                        {
                            listBox1.Items.Add("MOV CX , AX ");
                            textBox2.Text = "CX = " + AXvalue.ToString();

                            CXvalue = AXvalue;
                            textBox1.Text = "";
                        }
                        else if (BXisMOV == true && textBox1.Text.Equals("BX"))
                        {
                            listBox1.Items.Add("MOV CX , BX ");
                            textBox2.Text = "CX = " + BXvalue.ToString();

                            CXvalue = BXvalue;
                            textBox1.Text = "";
                        }
                        else if (DXisMOV == true && textBox1.Text.Equals("DX"))
                        {
                            listBox1.Items.Add("MOV CX , DX ");
                            textBox2.Text = "CX = " + DXvalue.ToString();

                            CXvalue = DXvalue;
                            textBox1.Text = "";
                        }
                        else
                        {
                            CXvalue = (Convert.ToInt32(textBox1.Text));
                            textBox2.Text = "CX = " + textBox1.Text;
                            listBox1.Items.Add("MOV " + "CX , " + CXvalue);
                            textBox1.Text = "";
                            CXisMOV = true;
                        }
                    }
                    else if (comboBox2.Text.Equals("DX"))
                    {
                        if (AXisMOV == true && textBox1.Text.Equals("AX"))
                        {
                            listBox1.Items.Add("MOV DX , AX ");
                            textBox2.Text = "DX = " + AXvalue.ToString();

                            DXvalue = AXvalue;
                            textBox1.Text = "";
                        }
                        else if (BXisMOV == true && textBox1.Text.Equals("BX"))
                        {
                            listBox1.Items.Add("MOV DX , BX ");
                            textBox2.Text = "DX = " + BXvalue.ToString();

                            DXvalue = BXvalue;
                            textBox1.Text = "";
                        }
                        else if (CXisMOV == true && textBox1.Text.Equals("CX"))
                        {
                            listBox1.Items.Add("MOV DX , CX ");
                            textBox2.Text = "DX = " + CXvalue.ToString();

                            DXvalue = CXvalue;
                            textBox1.Text = "";
                        }
                        else
                        {
                            DXvalue = (Convert.ToInt32(textBox1.Text));
                            textBox2.Text = "DX = " + textBox1.Text;
                            listBox1.Items.Add("MOV " + "DX , " + DXvalue);
                            textBox1.Text = "";
                            DXisMOV = true;
                        }
                    }
                }
            }
            else if (comboBox1.Text.Equals("ADD"))
            {

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Proszę podać wartość parametru!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comboBox2.Text.Equals("AX"))
                    {
                        if (AXisMOV == true)
                        {
                            if (BXisMOV == true && textBox1.Text.Equals("BX"))
                            {
                                listBox1.Items.Add("ADD AX , BX ");
                                textBox2.Text = "AX = " + (AXvalue + BXvalue);

                                AXvalue = AXvalue + BXvalue;
                                textBox1.Text = "";
                            }
                            else if (CXisMOV == true && textBox1.Text.Equals("CX"))
                            {
                                listBox1.Items.Add("ADD AX , CX ");
                                textBox2.Text = "AX = " + (AXvalue + CXvalue);

                                AXvalue = AXvalue + CXvalue;
                                textBox1.Text = "";
                            }
                            else if (DXisMOV == true && textBox1.Text.Equals("DX"))
                            {
                                listBox1.Items.Add("ADD AX , DX ");
                                textBox2.Text = "AX = " + (AXvalue + DXvalue);

                                AXvalue = AXvalue + DXvalue;
                                textBox1.Text = "";
                            }
                            else
                            {
                                AXvalue = AXvalue + (Convert.ToInt32(textBox1.Text));
                                textBox2.Text = "AX = " + AXvalue;
                                listBox1.Items.Add("ADD AX , " + textBox1.Text);
                                textBox1.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Proszę najpierw przypisać wartość do rejestru za pomocą rozkazu MOV!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (comboBox2.Text.Equals("BX"))
                    {
                        if (BXisMOV == true)
                        {
                            if (AXisMOV == true && textBox1.Text.Equals("AX"))
                            {
                                listBox1.Items.Add("ADD BX , AX ");
                                textBox2.Text = "BX = " + (BXvalue + AXvalue);

                                BXvalue = BXvalue + AXvalue;
                                textBox1.Text = "";
                            }
                            else if (CXisMOV == true && textBox1.Text.Equals("CX"))
                            {
                                listBox1.Items.Add("ADD BX , CX ");
                                textBox2.Text = "BX = " + (BXvalue + CXvalue);

                                BXvalue = BXvalue + CXvalue;
                                textBox1.Text = "";
                            }
                            else if (DXisMOV == true && textBox1.Text.Equals("DX"))
                            {
                                listBox1.Items.Add("ADD BX , DX ");
                                textBox2.Text = "BX = " + (BXvalue + DXvalue);

                                BXvalue = BXvalue + DXvalue;
                                textBox1.Text = "";
                            }
                            else
                            {
                                BXvalue = BXvalue + (Convert.ToInt32(textBox1.Text));
                                textBox2.Text = "BX = " + BXvalue;
                                listBox1.Items.Add("ADD BX , " + textBox1.Text);
                                textBox1.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Proszę najpierw przypisać wartość do rejestru za pomocą rozkazu MOV!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (comboBox2.Text.Equals("CX"))
                    {
                        if (CXisMOV == true)
                        {
                            if (AXisMOV == true && textBox1.Text.Equals("AX"))
                            {
                                listBox1.Items.Add("ADD CX , AX ");
                                textBox2.Text = "CX = " + (CXvalue + AXvalue);

                                CXvalue = CXvalue + AXvalue;
                                textBox1.Text = "";
                            }
                            else if (BXisMOV == true && textBox1.Text.Equals("BX"))
                            {
                                listBox1.Items.Add("ADD CX , BX ");
                                textBox2.Text = "CX = " + (CXvalue + BXvalue);

                                CXvalue = CXvalue + BXvalue;
                                textBox1.Text = "";
                            }
                            else if (DXisMOV == true && textBox1.Text.Equals("DX"))
                            {
                                listBox1.Items.Add("ADD CX , DX ");
                                textBox2.Text = "CX = " + (CXvalue + DXvalue);

                                CXvalue = CXvalue + DXvalue;
                                textBox1.Text = "";
                            }
                            else
                            {
                                CXvalue = CXvalue + (Convert.ToInt32(textBox1.Text));
                                textBox2.Text = "CX = " + CXvalue;
                                listBox1.Items.Add("ADD CX , " + textBox1.Text);
                                textBox1.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Proszę najpierw przypisać wartość do rejestru za pomocą rozkazu MOV!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (comboBox2.Text.Equals("DX"))
                    {
                        if (DXisMOV == true)
                        {
                            if (AXisMOV == true && textBox1.Text.Equals("AX"))
                            {
                                listBox1.Items.Add("ADD DX , AX ");
                                textBox2.Text = "DX = " + (DXvalue + AXvalue);

                                DXvalue = DXvalue + AXvalue;
                                textBox1.Text = "";
                            }
                            else if (BXisMOV == true && textBox1.Text.Equals("BX"))
                            {
                                listBox1.Items.Add("ADD DX , BX ");
                                textBox2.Text = "DX = " + (DXvalue + BXvalue);

                                DXvalue = DXvalue + BXvalue;
                                textBox1.Text = "";
                            }
                            else if (CXisMOV == true && textBox1.Text.Equals("CX"))
                            {
                                listBox1.Items.Add("ADD DX , CX ");
                                textBox2.Text = "DX = " + (DXvalue + CXvalue);

                                DXvalue = DXvalue + CXvalue;
                                textBox1.Text = "";
                            }
                            else
                            {
                                DXvalue = DXvalue + (Convert.ToInt32(textBox1.Text));
                                textBox2.Text = "DX = " + DXvalue;
                                listBox1.Items.Add("ADD DX , " + textBox1.Text);
                                textBox1.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Proszę najpierw przypisać wartość do rejestru za pomocą rozkazu MOV!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else if (comboBox1.Text.Equals("SUB"))
            {

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Proszę podać wartość parametru!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comboBox2.Text.Equals("AX"))
                    {
                        if (AXisMOV == true)
                        {
                            if (BXisMOV == true && textBox1.Text.Equals("BX"))
                            {
                                listBox1.Items.Add("SUB AX , BX ");
                                textBox2.Text = "AX = " + (AXvalue - BXvalue);

                                AXvalue = AXvalue - BXvalue;
                                textBox1.Text = "";
                            }
                            else if (CXisMOV == true && textBox1.Text.Equals("CX"))
                            {
                                listBox1.Items.Add("SUB AX , CX ");
                                textBox2.Text = "AX = " + (AXvalue - CXvalue);

                                AXvalue = AXvalue - CXvalue;
                                textBox1.Text = "";
                            }
                            else if (DXisMOV == true && textBox1.Text.Equals("DX"))
                            {
                                listBox1.Items.Add("SUB AX , DX ");
                                textBox2.Text = "AX = " + (AXvalue - DXvalue);

                                AXvalue = AXvalue - DXvalue;
                                textBox1.Text = "";
                            }
                            else
                            {
                                AXvalue = AXvalue - (Convert.ToInt32(textBox1.Text));
                                textBox2.Text = "AX = " + AXvalue;
                                listBox1.Items.Add("SUB AX , " + textBox1.Text);
                                textBox1.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Proszę najpierw przypisać wartość do rejestru za pomocą rozkazu MOV!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else if (comboBox2.Text.Equals("BX"))
                    {
                        if (BXisMOV == true)
                        {
                            if (AXisMOV == true && textBox1.Text.Equals("AX"))
                            {
                                listBox1.Items.Add("SUB BX , AX ");
                                textBox2.Text = "BX = " + (BXvalue - AXvalue);

                                BXvalue = BXvalue - AXvalue;
                                textBox1.Text = "";
                            }
                            else if (CXisMOV == true && textBox1.Text.Equals("CX"))
                            {
                                listBox1.Items.Add("SUB BX , CX ");
                                textBox2.Text = "BX = " + (BXvalue - CXvalue);

                                BXvalue = BXvalue - CXvalue;
                                textBox1.Text = "";
                            }
                            else if (DXisMOV == true && textBox1.Text.Equals("DX"))
                            {
                                listBox1.Items.Add("SUB BX , DX ");
                                textBox2.Text = "BX = " + (BXvalue - DXvalue);

                                BXvalue = BXvalue - DXvalue;
                                textBox1.Text = "";
                            }
                            else
                            {
                                BXvalue = BXvalue - (Convert.ToInt32(textBox1.Text));
                                textBox2.Text = "BX = " + BXvalue;
                                listBox1.Items.Add("SUB BX , " + textBox1.Text);
                                textBox1.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Proszę najpierw przypisać wartość do rejestru za pomocą rozkazu MOV!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (comboBox2.Text.Equals("CX"))
                    {
                        if (CXisMOV == true)
                        {
                            if (AXisMOV == true && textBox1.Text.Equals("AX"))
                            {
                                listBox1.Items.Add("SUB CX , AX ");
                                textBox2.Text = "CX = " + (CXvalue - AXvalue);

                                CXvalue = CXvalue - AXvalue;
                                textBox1.Text = "";
                            }
                            else if (BXisMOV == true && textBox1.Text.Equals("BX"))
                            {
                                listBox1.Items.Add("SUB CX , BX ");
                                textBox2.Text = "CX = " + (CXvalue - BXvalue);

                                CXvalue = CXvalue - BXvalue;
                                textBox1.Text = "";
                            }
                            else if (DXisMOV == true && textBox1.Text.Equals("DX"))
                            {
                                listBox1.Items.Add("SUB CX , DX ");
                                textBox2.Text = "CX = " + (CXvalue - DXvalue);

                                CXvalue = CXvalue - DXvalue;
                                textBox1.Text = "";
                            }
                            else
                            {
                                CXvalue = CXvalue - (Convert.ToInt32(textBox1.Text));
                                textBox2.Text = "CX = " + CXvalue;
                                listBox1.Items.Add("SUB CX , " + textBox1.Text);
                                textBox1.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Proszę najpierw przypisać wartość do rejestru za pomocą rozkazu MOV!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (comboBox2.Text.Equals("DX"))
                    {
                        if (DXisMOV == true)
                        {
                            if (AXisMOV == true && textBox1.Text.Equals("AX"))
                            {
                                listBox1.Items.Add("SUB DX , AX ");
                                textBox2.Text = "DX = " + (DXvalue - AXvalue);

                                DXvalue = DXvalue - AXvalue;
                                textBox1.Text = "";
                            }
                            else if (BXisMOV == true && textBox1.Text.Equals("BX"))
                            {
                                listBox1.Items.Add("SUB DX , BX ");
                                textBox2.Text = "DX = " + (DXvalue - BXvalue);

                                DXvalue = DXvalue - BXvalue;
                                textBox1.Text = "";
                            }
                            else if (CXisMOV == true && textBox1.Text.Equals("CX"))
                            {
                                listBox1.Items.Add("SUB DX , CX ");
                                textBox2.Text = "DX = " + (DXvalue - CXvalue);

                                DXvalue = DXvalue - CXvalue;
                                textBox1.Text = "";
                            }
                            else
                            {
                                DXvalue = DXvalue - (Convert.ToInt32(textBox1.Text));
                                textBox2.Text = "DX = " + DXvalue;
                                listBox1.Items.Add("SUB DX , " + textBox1.Text);
                                textBox1.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Proszę najpierw przypisać wartość do rejestru za pomocą rozkazu MOV!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else if (comboBox1.Text.Equals("DEC"))
            {
                if (comboBox2.Text.Equals("AX"))
                {
                    if (AXisMOV == true)
                    {
                        AXvalue = AXvalue - 1;
                        textBox2.Text = "AX = " + AXvalue;
                        listBox1.Items.Add("DEC AX");
                    }
                    else
                    {
                        MessageBox.Show("Proszę najpierw przypisać wartość do rejestru za pomocą rozkazu MOV!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (comboBox2.Text.Equals("BX"))
                {
                    if (BXisMOV == true)
                    {
                        BXvalue = BXvalue - 1;
                        textBox2.Text = "BX = " + BXvalue;
                        listBox1.Items.Add("DEC BX");
                    }
                    else
                    {
                        MessageBox.Show("Proszę najpierw przypisać wartość do rejestru za pomocą rozkazu MOV!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (comboBox2.Text.Equals("CX"))
                {
                    if (CXisMOV == true)
                    {
                        CXvalue = CXvalue - 1;
                        textBox2.Text = "CX = " + DXvalue;
                        listBox1.Items.Add("DEC CX");
                    }
                    else
                    {
                        MessageBox.Show("Proszę najpierw przypisać wartość do rejestru za pomocą rozkazu MOV!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (comboBox2.Text.Equals("DX"))
                {
                    if (DXisMOV == true)
                    {
                        DXvalue = DXvalue - 1;
                        textBox2.Text = "DX = " + DXvalue;
                        listBox1.Items.Add("DEC DX");
                    }
                    else
                    {
                        MessageBox.Show("Proszę najpierw przypisać wartość do rejestru za pomocą rozkazu MOV!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";

            AXvalue = 0;
            BXvalue = 0;
            CXvalue = 0;
            DXvalue = 0;

            AXisMOV = false;
            BXisMOV = false;
            CXisMOV = false;
            DXisMOV = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
