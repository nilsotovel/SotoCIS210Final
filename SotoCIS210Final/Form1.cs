using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SotoCIS210Final
{
    public partial class Form1 : Form
    {
        private CheckBox checkBoxOne, checkBoxTwo;
        private TextBox textBoxState;
        private TextBox textBoxScore1, textBoxScore2, textBoxScore3;
        private Label labelScore1, labelScore2, labelScore3, labelAverage, labelAverageValue;
        private Button buttonCalculate;
        private GroupBox groupBoxExtra;
        private RadioButton radioAscending, radioDescending;
        private TextBox textBoxNumbers;
        private Button buttonGenerate, buttonNoDuplicates;
        private int[] generatedNumbers = null;

        public Form1()
        {
            InitializeComponent();
            BuildUI();
        }

        private void BuildUI()
        {

            this.Text = "Soto CIS210 Final";
            this.Font = new Font(this.Font.FontFamily, 10);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.ClientSize = new Size(660, 620);

            checkBoxOne = new CheckBox();
            checkBoxOne.Text = "One";
            checkBoxOne.Location = new Point(50, 30);
            checkBoxOne.Checked = true;
            checkBoxOne.CheckedChanged += CheckBox_CheckedChanged;

            checkBoxTwo = new CheckBox();
            checkBoxTwo.Text = "Two";
            checkBoxTwo.Location = new Point(50, 60);
            checkBoxTwo.Checked = false;
            checkBoxTwo.CheckedChanged += CheckBox_CheckedChanged;

            textBoxState = new TextBox();
            textBoxState.Location = new Point(250, 30);
            textBoxState.Width = 120;
            textBoxState.ReadOnly = true;
            textBoxState.Text = "One";

            labelScore1 = new Label();
            labelScore1.Text = "Score 1";
            labelScore1.Location = new Point(50, 130);

            textBoxScore1 = new TextBox();
            textBoxScore1.Location = new Point(50, 155);
            textBoxScore1.Width = 80;

            labelScore2 = new Label();
            labelScore2.Text = "Score 2";
            labelScore2.Location = new Point(160, 130);

            textBoxScore2 = new TextBox();
            textBoxScore2.Location = new Point(160, 155);
            textBoxScore2.Width = 80;

            labelScore3 = new Label();
            labelScore3.Text = "Score 3";
            labelScore3.Location = new Point(270, 130);

            textBoxScore3 = new TextBox();
            textBoxScore3.Location = new Point(270, 155);
            textBoxScore3.Width = 80;

            labelAverage = new Label();
            labelAverage.Text = "Average";
            labelAverage.Location = new Point(400, 130);

            labelAverageValue = new Label();
            labelAverageValue.Location = new Point(400, 155);
            labelAverageValue.Width = 100;
            labelAverageValue.Height = 22;
            labelAverageValue.BorderStyle = BorderStyle.Fixed3D;
            labelAverageValue.AutoSize = false;

            buttonCalculate = new Button();
            buttonCalculate.Text = "Calculate Average";
            buttonCalculate.Location = new Point(240, 200);
            buttonCalculate.Width = 130;
            buttonCalculate.Height = 45;
            buttonCalculate.Click += ButtonCalculate_Click;

            groupBoxExtra = new GroupBox();
            groupBoxExtra.Text = "Extra 20%";
            groupBoxExtra.Location = new Point(30, 270);
            groupBoxExtra.Size = new Size(600, 320);

            radioAscending = new RadioButton();
            radioAscending.Text = "Ascending";
            radioAscending.Location = new Point(20, 40);
            radioAscending.CheckedChanged += RadioSort_CheckedChanged;

            radioDescending = new RadioButton();
            radioDescending.Text = "Descending";
            radioDescending.Location = new Point(20, 80);
            radioDescending.CheckedChanged += RadioSort_CheckedChanged;

            textBoxNumbers = new TextBox();
            textBoxNumbers.Location = new Point(200, 30);
            textBoxNumbers.Size = new Size(200, 220);
            textBoxNumbers.Multiline = true;
            textBoxNumbers.ScrollBars = ScrollBars.Vertical;
            textBoxNumbers.ReadOnly = true;

            buttonNoDuplicates = new Button();
            buttonNoDuplicates.Text = "No Duplicates";
            buttonNoDuplicates.Location = new Point(430, 110);
            buttonNoDuplicates.Width = 120;
            buttonNoDuplicates.Click += ButtonNoDuplicates_Click;

            buttonGenerate = new Button();
            buttonGenerate.Text = "Generate";
            buttonGenerate.Location = new Point(270, 265);
            buttonGenerate.Width = 100;
            buttonGenerate.Click += ButtonGenerate_Click;

            groupBoxExtra.Controls.Add(radioAscending);
            groupBoxExtra.Controls.Add(radioDescending);
            groupBoxExtra.Controls.Add(textBoxNumbers);
            groupBoxExtra.Controls.Add(buttonNoDuplicates);
            groupBoxExtra.Controls.Add(buttonGenerate);

            this.Controls.Add(checkBoxOne);
            this.Controls.Add(checkBoxTwo);
            this.Controls.Add(textBoxState);
            this.Controls.Add(labelScore1);
            this.Controls.Add(textBoxScore1);
            this.Controls.Add(labelScore2);
            this.Controls.Add(textBoxScore2);
            this.Controls.Add(labelScore3);
            this.Controls.Add(textBoxScore3);
            this.Controls.Add(labelAverage);
            this.Controls.Add(labelAverageValue);
            this.Controls.Add(buttonCalculate);
            this.Controls.Add(groupBoxExtra);
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
            double total = 0;
            int count = 0;

            string[] names = { "Score 1", "Score 2", "Score 3" };
            string[] values = { textBoxScore1.Text, textBoxScore2.Text, textBoxScore3.Text };

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
                count++;
            }

            labelAverageValue.Text = (total / count).ToString("F2");
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