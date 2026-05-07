using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SotoCIS210Final
{
    public partial class Form1 : Form
    {
        private int[] generatedNumbers = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOne.Checked && checkBoxTwo.Checked)
                textBoxState.Text = "Both";
            else if (checkBoxOne.Checked)
                textBoxState.Text = "One";
            else if (checkBoxTwo.Checked)
                textBoxState.Text = "Two";
            else
                textBoxState.Text = "None";
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            string[] names = { "Score 1", "Score 2", "Score 3" };
            string[] values = { textBoxScore1.Text, textBoxScore2.Text, textBoxScore3.Text };
            double total = 0;

            for (int i = 0; i < 3; i++)
            {
                if (string.IsNullOrWhiteSpace(values[i]))
                {
                    MessageBox.Show(names[i] + " is missing.");
                    return;
                }
                if (!double.TryParse(values[i], out double score))
                {
                    MessageBox.Show(names[i] + " is not a valid number.");
                    return;
                }
                total += score;
            }

            labelAverageValue.Text = (total / 3).ToString("F2");
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            generatedNumbers = new int[50];
            for (int i = 0; i < 50; i++)
                generatedNumbers[i] = rand.Next(10, 51);

            radioAscending.Checked = false;
            radioDescending.Checked = false;
            DisplayNumbers(generatedNumbers);
        }

        private void RadioSort_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (!rb.Checked) return;

            if (generatedNumbers == null)
            {
                MessageBox.Show("Generate random numbers first");
                radioAscending.Checked = false;
                radioDescending.Checked = false;
                return;
            }

            int[] sorted = (int[])generatedNumbers.Clone();
            Array.Sort(sorted);
            if (radioDescending.Checked)
                Array.Reverse(sorted);

            DisplayNumbers(sorted);
        }

        private void ButtonNoDuplicates_Click(object sender, EventArgs e)
        {
            if (generatedNumbers == null) return;
            int[] unique = generatedNumbers.Distinct().ToArray();
            DisplayNumbers(unique);
        }

        private void DisplayNumbers(int[] numbers)
        {
            textBoxNumbers.Text = string.Join(" ", numbers);
        }
    }
}