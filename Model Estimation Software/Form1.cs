using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            MessageBox.Show("Bienvenido, al rellenar los campos solo escriba numeros enteros sin ningun simbolo");
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
                sw.Close();
            }
        }
        #region trash
        private void textBox1_TextChanged(object sender, EventArgs e) { } private void groupBox1_Enter(object sender, EventArgs e) { }private void label4_Click(object sender, EventArgs e) { }private void label6_Click(object sender, EventArgs e) { }private void textBox3_TextChanged(object sender, EventArgs e) { }private void textBoxPrntWatt_TextChanged(object sender, EventArgs e) { }
        #endregion

        private void textBoxMinTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxG_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHourTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
