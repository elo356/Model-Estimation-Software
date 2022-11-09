
namespace Model_Estimation_Software
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxPrecios = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMIN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPG = new System.Windows.Forms.TextBox();
            this.checkBoxPrecios = new System.Windows.Forms.CheckBox();
            this.buttonEstimate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHourTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMinTime = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxPrecios.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textTotal);
            this.groupBox2.Location = new System.Drawing.Point(334, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estimacion";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(6, 65);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(127, 20);
            this.textTotal.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSave);
            this.groupBox3.Controls.Add(this.groupBoxPrecios);
            this.groupBox3.Controls.Add(this.checkBoxPrecios);
            this.groupBox3.Location = new System.Drawing.Point(533, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 342);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personalizacion";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(60, 273);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(143, 58);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Guardar Cambios";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxPrecios
            // 
            this.groupBoxPrecios.Controls.Add(this.label9);
            this.groupBoxPrecios.Controls.Add(this.textBoxMIN);
            this.groupBoxPrecios.Controls.Add(this.label4);
            this.groupBoxPrecios.Controls.Add(this.textBoxPM);
            this.groupBoxPrecios.Controls.Add(this.label8);
            this.groupBoxPrecios.Controls.Add(this.textBoxPG);
            this.groupBoxPrecios.Location = new System.Drawing.Point(0, 62);
            this.groupBoxPrecios.Name = "groupBoxPrecios";
            this.groupBoxPrecios.Size = new System.Drawing.Size(255, 185);
            this.groupBoxPrecios.TabIndex = 12;
            this.groupBoxPrecios.TabStop = false;
            this.groupBoxPrecios.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Precio por cada 30 min";
            // 
            // textBoxMIN
            // 
            this.textBoxMIN.Location = new System.Drawing.Point(122, 114);
            this.textBoxMIN.Name = "textBoxMIN";
            this.textBoxMIN.Size = new System.Drawing.Size(127, 20);
            this.textBoxMIN.TabIndex = 12;
            this.textBoxMIN.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio por 3 gramos";
            // 
            // textBoxPM
            // 
            this.textBoxPM.Location = new System.Drawing.Point(122, 38);
            this.textBoxPM.Name = "textBoxPM";
            this.textBoxPM.Size = new System.Drawing.Size(127, 20);
            this.textBoxPM.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Precio por modelo";
            // 
            // textBoxPG
            // 
            this.textBoxPG.Location = new System.Drawing.Point(122, 73);
            this.textBoxPG.Name = "textBoxPG";
            this.textBoxPG.Size = new System.Drawing.Size(127, 20);
            this.textBoxPG.TabIndex = 10;
            // 
            // checkBoxPrecios
            // 
            this.checkBoxPrecios.AutoSize = true;
            this.checkBoxPrecios.Location = new System.Drawing.Point(6, 34);
            this.checkBoxPrecios.Name = "checkBoxPrecios";
            this.checkBoxPrecios.Size = new System.Drawing.Size(144, 17);
            this.checkBoxPrecios.TabIndex = 8;
            this.checkBoxPrecios.Text = "Ver precios por categoria";
            this.checkBoxPrecios.UseVisualStyleBackColor = true;
            this.checkBoxPrecios.CheckedChanged += new System.EventHandler(this.checkBoxPrecios_CheckedChanged);
            // 
            // buttonEstimate
            // 
            this.buttonEstimate.Location = new System.Drawing.Point(334, 243);
            this.buttonEstimate.Name = "buttonEstimate";
            this.buttonEstimate.Size = new System.Drawing.Size(143, 58);
            this.buttonEstimate.TabIndex = 9;
            this.buttonEstimate.Text = "Estimar";
            this.buttonEstimate.UseVisualStyleBackColor = true;
            this.buttonEstimate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(722, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "By: DevElop";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(334, 315);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(143, 58);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Borrar Todo";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(118, 62);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(127, 20);
            this.textBoxM.TabIndex = 1;
            this.textBoxM.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad de modelos";
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(118, 110);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(127, 20);
            this.textBoxG.TabIndex = 3;
            this.textBoxG.TextChanged += new System.EventHandler(this.textBoxG_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad de gramos";
            // 
            // textBoxHourTime
            // 
            this.textBoxHourTime.Location = new System.Drawing.Point(122, 152);
            this.textBoxHourTime.Name = "textBoxHourTime";
            this.textBoxHourTime.Size = new System.Drawing.Size(127, 20);
            this.textBoxHourTime.TabIndex = 5;
            this.textBoxHourTime.TextChanged += new System.EventHandler(this.textBoxHourTime_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tiempo impresion Horas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxMinTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxHourTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxG);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxM);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tiempo impresion Minuts";
            // 
            // textBoxMinTime
            // 
            this.textBoxMinTime.Location = new System.Drawing.Point(122, 190);
            this.textBoxMinTime.Name = "textBoxMinTime";
            this.textBoxMinTime.Size = new System.Drawing.Size(127, 20);
            this.textBoxMinTime.TabIndex = 7;
            this.textBoxMinTime.Text = "0";
            this.textBoxMinTime.TextChanged += new System.EventHandler(this.textBoxMinTime_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonEstimate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Printing Cost Estimation Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxPrecios.ResumeLayout(false);
            this.groupBoxPrecios.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonEstimate;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.CheckBox checkBoxPrecios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHourTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxPrecios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMIN;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMinTime;
    }
}

