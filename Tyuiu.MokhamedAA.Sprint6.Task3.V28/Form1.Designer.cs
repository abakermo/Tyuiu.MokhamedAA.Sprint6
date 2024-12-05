using Tyuiu.MokhamedAA.Sprint6.Task3.V28.Lib;
namespace Tyuiu.MokhamedAA.Sprint6.Task3.V28
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
        private void buttonDone_VAA_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);

            int rows = res.GetUpperBound(0) + 1;
            int columns = res.Length / rows;

            dataGridViewRes_VAA.ColumnCount = columns;
            dataGridViewRes_VAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewRes_VAA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewRes_VAA.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonHelp_VAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнина студентка группы ИИПб-23-2 Варова Ангелина Александровна", "Сообщение", MessageBoxButtons.OK);
        }

        private void groupBoxTask_VAA_Enter(object sender, EventArgs e)
        {
            //
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_VAA.ColumnCount = columns;
            dataGridViewMatrix_VAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_VAA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_VAA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void dataGridViewRes_VAA_CellContentClick(object sender, DataGridViewCellEventArgs e)

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
