using System;
using System.Windows.Forms;

namespace Long_Significant_Figure_Calculator
{
    public partial class Form1 : Form
    {
        String answer = String.Empty;
        int Nume = 0;
        int Denomi = 0;
        int quotient = 0;
        int nearestDivisor = 0;
        int reminder = 0;
        int length = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nume = Int32.Parse(textBoxNume.Text);
            Denomi=Int32.Parse(textBoxDenomi.Text);
            length = Int32.Parse(textBoxLength.Text);
            toolStripProgressBar1.Minimum = 1;
            toolStripProgressBar1.Maximum = length;
            toolStripProgressBar1.Step = 1;
            quotient = Nume / Denomi;
            nearestDivisor = quotient * Denomi;
            reminder = Nume - nearestDivisor;
            answer = quotient +".";
            for (int i = 1; i <= length; i++)
            {
                quotient = Int32.Parse(reminder+"0") / Denomi;
                nearestDivisor = quotient * Denomi;
                reminder = Int32.Parse(reminder + "0") - nearestDivisor;
                //toolStripProgressBar1.PerformStep();
                toolStripProgressBar1.Value = i;
                answer = answer + quotient;
                toolStripStatusLabelDP.Text = "Decimal Places: " + i;
            }
            textBoxAnswer.Text = answer;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            answer = String.Empty;
            Nume = 0;
            Denomi = 0;
            quotient = 0;
            nearestDivisor = 0;
            reminder = 0;
            length = 0;
            textBoxAnswer.Text = String.Empty;
            textBoxDenomi.Text = String.Empty;
            textBoxNume.Text = String.Empty;
            textBoxLength.Text = String.Empty;
            toolStripProgressBar1.Value = 0;
        }
    }
}
