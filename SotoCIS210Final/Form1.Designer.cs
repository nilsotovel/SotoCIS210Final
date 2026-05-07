namespace SotoCIS210Final
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBoxOne = new CheckBox();
            checkBoxTwo = new CheckBox();
            textBoxState = new TextBox();
            labelScore1 = new Label();
            textBoxScore1 = new TextBox();
            labelScore2 = new Label();
            textBoxScore2 = new TextBox();
            labelScore3 = new Label();
            textBoxScore3 = new TextBox();
            labelAverage = new Label();
            labelAverageValue = new Label();
            buttonCalculate = new Button();
            groupBoxExtra = new GroupBox();
            buttonGenerate = new Button();
            buttonNoDuplicates = new Button();
            textBoxNumbers = new TextBox();
            radioDescending = new RadioButton();
            radioAscending = new RadioButton();
            groupBoxExtra.SuspendLayout();
            SuspendLayout();
            // 
            // checkBoxOne
            // 
            checkBoxOne.AutoSize = true;
            checkBoxOne.Checked = true;
            checkBoxOne.CheckState = CheckState.Checked;
            checkBoxOne.Location = new Point(115, 124);
            checkBoxOne.Name = "checkBoxOne";
            checkBoxOne.Size = new Size(93, 34);
            checkBoxOne.TabIndex = 0;
            checkBoxOne.Text = "One";
            checkBoxOne.UseVisualStyleBackColor = true;
            checkBoxOne.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // checkBoxTwo
            // 
            checkBoxTwo.AutoSize = true;
            checkBoxTwo.Location = new Point(113, 186);
            checkBoxTwo.Name = "checkBoxTwo";
            checkBoxTwo.Size = new Size(93, 34);
            checkBoxTwo.TabIndex = 1;
            checkBoxTwo.Text = "Two";
            checkBoxTwo.UseVisualStyleBackColor = true;
            checkBoxTwo.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // textBoxState
            // 
            textBoxState.Location = new Point(303, 134);
            textBoxState.Name = "textBoxState";
            textBoxState.ReadOnly = true;
            textBoxState.Size = new Size(200, 38);
            textBoxState.TabIndex = 2;
            textBoxState.Text = "One";
            // 
            // labelScore1
            // 
            labelScore1.AutoSize = true;
            labelScore1.Location = new Point(97, 332);
            labelScore1.Name = "labelScore1";
            labelScore1.Size = new Size(125, 30);
            labelScore1.TabIndex = 3;
            labelScore1.Text = "Score 1";
            // 
            // textBoxScore1
            // 
            textBoxScore1.Location = new Point(97, 365);
            textBoxScore1.Name = "textBoxScore1";
            textBoxScore1.Size = new Size(200, 38);
            textBoxScore1.TabIndex = 4;
            // 
            // labelScore2
            // 
            labelScore2.AutoSize = true;
            labelScore2.Location = new Point(381, 332);
            labelScore2.Name = "labelScore2";
            labelScore2.Size = new Size(125, 30);
            labelScore2.TabIndex = 5;
            labelScore2.Text = "Score 2";
            // 
            // textBoxScore2
            // 
            textBoxScore2.Location = new Point(381, 365);
            textBoxScore2.Name = "textBoxScore2";
            textBoxScore2.Size = new Size(200, 38);
            textBoxScore2.TabIndex = 6;
            // 
            // labelScore3
            // 
            labelScore3.AutoSize = true;
            labelScore3.Location = new Point(647, 332);
            labelScore3.Name = "labelScore3";
            labelScore3.Size = new Size(125, 30);
            labelScore3.TabIndex = 7;
            labelScore3.Text = "Score 3";
            // 
            // textBoxScore3
            // 
            textBoxScore3.Location = new Point(647, 365);
            textBoxScore3.Name = "textBoxScore3";
            textBoxScore3.Size = new Size(200, 38);
            textBoxScore3.TabIndex = 8;
            // 
            // labelAverage
            // 
            labelAverage.AutoSize = true;
            labelAverage.Location = new Point(1087, 332);
            labelAverage.Name = "labelAverage";
            labelAverage.Size = new Size(125, 30);
            labelAverage.TabIndex = 9;
            labelAverage.Text = "Average";
            // 
            // labelAverageValue
            // 
            labelAverageValue.BackColor = SystemColors.InactiveCaption;
            labelAverageValue.BorderStyle = BorderStyle.Fixed3D;
            labelAverageValue.Location = new Point(1069, 367);
            labelAverageValue.Name = "labelAverageValue";
            labelAverageValue.Size = new Size(156, 38);
            labelAverageValue.TabIndex = 10;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(525, 418);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(322, 46);
            buttonCalculate.TabIndex = 11;
            buttonCalculate.Text = "Calculate Average";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += ButtonCalculate_Click;
            // 
            // groupBoxExtra
            // 
            groupBoxExtra.BackColor = SystemColors.ActiveCaption;
            groupBoxExtra.Controls.Add(buttonGenerate);
            groupBoxExtra.Controls.Add(buttonNoDuplicates);
            groupBoxExtra.Controls.Add(textBoxNumbers);
            groupBoxExtra.Controls.Add(radioDescending);
            groupBoxExtra.Controls.Add(radioAscending);
            groupBoxExtra.Location = new Point(61, 490);
            groupBoxExtra.Name = "groupBoxExtra";
            groupBoxExtra.Size = new Size(1164, 415);
            groupBoxExtra.TabIndex = 12;
            groupBoxExtra.TabStop = false;
            groupBoxExtra.Text = "Extra 20%";
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(348, 294);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(290, 46);
            buttonGenerate.TabIndex = 4;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += ButtonGenerate_Click;
            // 
            // buttonNoDuplicates
            // 
            buttonNoDuplicates.Location = new Point(780, 140);
            buttonNoDuplicates.Name = "buttonNoDuplicates";
            buttonNoDuplicates.Size = new Size(290, 46);
            buttonNoDuplicates.TabIndex = 3;
            buttonNoDuplicates.Text = "No Duplicates";
            buttonNoDuplicates.UseVisualStyleBackColor = true;
            buttonNoDuplicates.Click += ButtonNoDuplicates_Click;
            // 
            // textBoxNumbers
            // 
            textBoxNumbers.BackColor = SystemColors.ButtonFace;
            textBoxNumbers.Location = new Point(324, 56);
            textBoxNumbers.Multiline = true;
            textBoxNumbers.Name = "textBoxNumbers";
            textBoxNumbers.ReadOnly = true;
            textBoxNumbers.ScrollBars = ScrollBars.Vertical;
            textBoxNumbers.Size = new Size(346, 202);
            textBoxNumbers.TabIndex = 2;
            // 
            // radioDescending
            // 
            radioDescending.AutoSize = true;
            radioDescending.Location = new Point(36, 224);
            radioDescending.Name = "radioDescending";
            radioDescending.Size = new Size(204, 34);
            radioDescending.TabIndex = 1;
            radioDescending.TabStop = true;
            radioDescending.Text = "Descending";
            radioDescending.UseVisualStyleBackColor = true;
            radioDescending.CheckedChanged += RadioSort_CheckedChanged;
            // 
            // radioAscending
            // 
            radioAscending.AutoSize = true;
            radioAscending.Location = new Point(36, 120);
            radioAscending.Name = "radioAscending";
            radioAscending.Size = new Size(188, 34);
            radioAscending.TabIndex = 0;
            radioAscending.TabStop = true;
            radioAscending.Text = "Ascending";
            radioAscending.UseVisualStyleBackColor = true;
            radioAscending.CheckedChanged += RadioSort_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 917);
            Controls.Add(groupBoxExtra);
            Controls.Add(buttonCalculate);
            Controls.Add(labelAverageValue);
            Controls.Add(labelAverage);
            Controls.Add(textBoxScore3);
            Controls.Add(labelScore3);
            Controls.Add(textBoxScore2);
            Controls.Add(labelScore2);
            Controls.Add(textBoxScore1);
            Controls.Add(labelScore1);
            Controls.Add(textBoxState);
            Controls.Add(checkBoxTwo);
            Controls.Add(checkBoxOne);
            Font = new Font("Courier New", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Soto CIS210 Final";
            groupBoxExtra.ResumeLayout(false);
            groupBoxExtra.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxOne;
        private CheckBox checkBoxTwo;
        private TextBox textBoxState;
        private Label labelScore1;
        private TextBox textBoxScore1;
        private Label labelScore2;
        private TextBox textBoxScore2;
        private Label labelScore3;
        private TextBox textBoxScore3;
        private Label labelAverage;
        private Label labelAverageValue;
        private Button buttonCalculate;
        private GroupBox groupBoxExtra;
        private RadioButton radioDescending;
        private RadioButton radioAscending;
        private Button buttonGenerate;
        private Button buttonNoDuplicates;
        private TextBox textBoxNumbers;
    }
}
