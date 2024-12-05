using Tyuiu.MokhamedAA.Sprint6.Task0.V12.Lib;
namespace Tyuiu.MokhamedAA.Sprint6.Task0.V12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(textBox1.Text, out n))
            {
                DataService ds = new DataService();
                int a;
                a = Convert.ToInt32(textBox1.Text);
                double b = ds.Calculate(a);
                textBox2.Text = b.ToString();
            }
            else MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
