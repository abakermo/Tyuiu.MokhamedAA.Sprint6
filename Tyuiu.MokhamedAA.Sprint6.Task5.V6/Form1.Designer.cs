using System.IO;
using Tyuiu.MokhamedAA.Sprint6.Task5.V6.Lib;
namespace Tyuiu.MokhamedAA.Sprint6.Task5.V6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        private void buttonDone_SDA_Click(object sender, EventArgs e)
        {
            try
            {

                string strLine;
                int len = ds.LoadFromDataFile(path).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.LoadFromDataFile(path);

                this.chartFunction_SDA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SDA.ChartAreas[0].AxisY.Title = "Ось Y";
                chartFunction_SDA.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_SDA.Rows.Add(Convert.ToString(i), Convert.ToString(valueArray[i]));
                    this.chartFunction_SDA.Series[0].Points.AddXY(i, valueArray[i]);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТБ-23-1 Сысоев Данил Алексеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonFile_SDA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
    }
}
