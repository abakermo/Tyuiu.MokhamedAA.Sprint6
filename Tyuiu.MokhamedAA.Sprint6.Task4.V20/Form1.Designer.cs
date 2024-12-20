﻿using Tyuiu.MokhamedAA.Sprint6.Task4.V20.Lib;
namespace Tyuiu.MokhamedAA.Sprint6.Task4.V20
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
        private void buttonDone_GVE_Click(object sender, EventArgs e)
        {
            try
            {
                int startstep = Convert.ToInt32(textBoxVarA_GVE.Text);
                int stopstep = Convert.ToInt32(textBoxVarB_GVE.Text);

                string strline;

                int len = ds.GetMassFunction(startstep, stopstep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startstep, stopstep);

                this.chartRes_GVE.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartRes_GVE.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxRes_GVE.Text = "";
                chartRes_GVE.Series[0].Points.Clear();

                for (int i = 0; i < len - 1; i++)
                {
                    this.chartRes_GVE.Series[0].Points.AddXY(startstep, valueArray[i]);
                    textBoxRes_GVE.AppendText(valueArray[i] + Environment.NewLine);
                    startstep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_GVE_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\PutPutFileTask4V20.txt";
                File.WriteAllText(path, textBoxRes_GVE.Text);

                DialogResult dialogres = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogres == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_GVE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студент группы ПКТб-23-2 Гурьевская В.Е.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
