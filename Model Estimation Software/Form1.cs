using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
namespace Model_Estimation_Software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] txtLines = File.ReadAllLines(Application.StartupPath + "\\SettingData.txt");

            textBoxPM.Text = txtLines[0];
            textBoxPG.Text = txtLines[1];   
            textBoxMIN.Text = txtLines[2];

            comboBox1.Items.Add("Español");
            comboBox1.Items.Add("English");

            comboBox1.SelectedIndex = int.Parse(txtLines[3]);

            if (comboBox1.SelectedIndex == 1)
            {
                #region txt en
                groupBox1.Text = ResEn.Datos;
                groupBox2.Text = ResEn.Est;
                groupBox3.Text = ResEn.Pers;
                label1.Text = ResEn.CantModel;
                label2.Text = ResEn.CantG;
                label3.Text = ResEn.TimeImpH;
                label6.Text = ResEn.TimeImpMin;
                buttonEstimate.Text = ResEn.Estimar;
                buttonClear.Text = ResEn.Borrar_Todo;
                checkBoxPrecios.Text = ResEn.Ver;
                label8.Text = ResEn.Ppm;
                label4.Text = ResEn.pp3g;
                label9.Text = ResEn.pc30m;
                buttonSave.Text = ResEn.Guardar;
                label5.Text = ResEn.Por + ": " + "DevElop";
                label7.Text = ResEn.Lenguaje;
                #endregion
            }
            else
            {
                #region txt es
                groupBox1.Text = Res.Datos;
                groupBox2.Text = Res.Est;
                groupBox3.Text = Res.Pers;
                label1.Text = Res.CantModel;
                label2.Text = Res.CantG;
                label3.Text = Res.TimeImpH;
                label6.Text = Res.TimeImpMin;
                buttonEstimate.Text = Res.Estimar;
                buttonClear.Text = Res.Borrar_Todo;
                checkBoxPrecios.Text = Res.Ver;
                label8.Text = Res.Ppm;
                label4.Text = Res.pp3g;
                label9.Text = Res.pc30m;
                buttonSave.Text = Res.Guardar;
                label5.Text = Res.Por + ": " + "DevElop";
                label7.Text = Res.Lenguaje;
                #endregion
            }
        }

        void EstimateCost()
        {
            if(textBoxM.Text == "")
            {
                MessageBox.Show("Debe llenar el campo de cantidad de modelos");
            }
            else if(textBoxG.Text == "")
            {
                MessageBox.Show("Debe llenar el campo de cantidad de gramos");
            }
            else if(textBoxHourTime.Text == "" )
            {
                MessageBox.Show("Debe llenar el campo de horas o escribir 0");
            }
            else if (textBoxMinTime.Text == "")
            {
                MessageBox.Show("Debe llenar el campo de minutos o escribir 0");
            }
            else
            {
                //userPrincipalData
                int modelCant = Int32.Parse(textBoxM.Text);
                float gramsPerModel = float.Parse(textBoxG.Text);
                float hourPrintingTime = float.Parse(textBoxHourTime.Text);
                float minPrintingTime = float.Parse(textBoxMinTime.Text);

                //back data 
                float modelPrice = modelCant * float.Parse(textBoxPM.Text);
                float gramsPrice = (gramsPerModel / 3) * float.Parse(textBoxPG.Text);
                float printingTimePrice = ((hourPrintingTime / 30) + (minPrintingTime / 60 / 30)) * float.Parse(textBoxMIN.Text);

                float estimation = modelPrice + gramsPrice + printingTimePrice;
                double estimationRounded = Convert.ToDouble(estimation);
                estimationRounded = Math.Round(estimation, 2);

                textTotal.Text = "$" + estimationRounded.ToString();         
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EstimateCost();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxG.Clear();
            textBoxM.Clear();
            textBoxHourTime.Clear();
            textTotal.Clear();
            textBoxMinTime.Clear();
        }

        private void checkBoxPrecios_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPrecios.CheckState == CheckState.Checked)
            {
                groupBoxPrecios.Visible = true;
            }
            else
            {
                groupBoxPrecios.Visible = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(textBoxPM.Text == "")
            {
                MessageBox.Show("Error al guardar. Debe rellenar todos los campos de precios");
            }
            else if(textBoxPG.Text == "")
            {
                MessageBox.Show("Error al guardar. Debe rellenar todos los campos de precios");
            }
            else if(textBoxMIN.Text == "")
            {
                MessageBox.Show("Error al guardar. Debe rellenar todos los campos de precios");
            }
            else
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\SettingData.txt");
                sw.WriteLine(textBoxPM.Text);
                sw.WriteLine(textBoxPG.Text);
                sw.WriteLine(textBoxMIN.Text);
                sw.WriteLine(comboBox1.SelectedIndex.ToString());
                sw.Close();
                Application.Restart();
            }
        }
    }
}
