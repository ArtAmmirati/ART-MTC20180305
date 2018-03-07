using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtsCalculator
{
    public partial class ArtsCalculator : Form
    {
        public ArtsCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double FirstValue = 0;
            double SecondValue = 0;
            bool number = true;

            number = (double.TryParse(FirstValueTextBox.Text, out FirstValue) &&
                double.TryParse(SecondValueTextBox.Text, out SecondValue));

            if (FirstValueTextBox != null && SecondValueTextBox != null && number)

            {
                if (AddRadioButton.Checked)
                {
                    ResultTextBox.Text = (FirstValue + SecondValue).ToString();
                }
                if (SubtractRadioButton.Checked)
                {
                    ResultTextBox.Text = (FirstValue - SecondValue).ToString();
                }
                if (MultiplyRadioButton.Checked)
                {
                    ResultTextBox.Text = (FirstValue * SecondValue).ToString();
                }
                if (DivideRadioButton.Checked)
                {
                    ResultTextBox.Text = (FirstValue / SecondValue).ToString();
                }
            }

            else
                MessageBox.Show("Numbers ONLY");
        }

        private void OperatorGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void FirstValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

