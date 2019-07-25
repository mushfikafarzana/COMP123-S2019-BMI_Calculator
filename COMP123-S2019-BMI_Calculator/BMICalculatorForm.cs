using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_BMI_Calculator
{
    public partial class BMICalculatorForm : Form
    {
        public string outputString { get; set; }
        public float outputValue { get; set; }
        public bool decimalExists { get; set; }
        public TextBox ActiveTextBox { get; set; }
        public double Result { get; set; }

        /// <summary>
        /// this is the constructor for the BMICalculatorForm
        /// </summary>
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this is the event handler for BMICalculatorForm Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            ClearNumericKeyboard();
            MetricRadioButton.Checked = true;
        }

        /// <summary>
        /// this is the event handler for BMICalculatorForm Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_Click(object sender, EventArgs e)
        {
            ClearNumericKeyboard();
            MetricRadioButton.Checked = true;
            WeightTextBox.BackColor = Color.Azure;
            HeightTextBox.BackColor = Color.Azure;
        }

        /// <summary>
        /// this is the shared event handler for all the KeyboardButton's Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void KeyBoardButton_Click(object sender, EventArgs e)
        {
            Button TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();

            int buttonValue = 0;
            bool numericResult = int.TryParse(tag, out buttonValue);

            if (numericResult)
            {
                int maxSize = 3;
                if (decimalExists)
                {
                    maxSize = 5;
                }
                else if (outputString == "0")
                {
                    ActiveTextBox.Text = tag;
                }
                else if (outputString != "0" && outputString.Length < maxSize)
                {
                    ActiveTextBox.Text += tag ;
                }
            }
            else
            {
                switch (tag)
                {
                    case "reset":
                        ClearNumericKeyboard();
                        BMIProgressBar.Value = 0;
                        break;
                    case "back":
                        RemoveLastCharacterFromActiveTextBox();
                        break;
                    case "calculate":
                        outputValue = 0;
                        BMIProgressBar.Value = 0;
                        CalculateBMI();
                        break;
                    case "decimal":
                        AddDecimalToActiveTextBox();
                        break;
                }
            }
        }

        /// <summary>
        /// this method adds a decimal point  to the ActiveTextBox
        /// </summary>
        private void AddDecimalToActiveTextBox()
        {
            if (!decimalExists)
            {
                outputString += ".";
                decimalExists = false;
            }
            ActiveTextBox.Text += outputString;
        }

        /// <summary>
        /// this method removes the last character from the ActiveTextBox
        /// </summary>
        private void RemoveLastCharacterFromActiveTextBox()
        {
            var lastChar = ActiveTextBox.Text.Substring(ActiveTextBox.Text.Length - 1);
            if (lastChar == ".")
            {
                decimalExists = false;
            }

            else if (ActiveTextBox.Text.Length == 0)
            { 
                ActiveTextBox.Text = "0";
            }
            ActiveTextBox.Text = ActiveTextBox.Text.Remove(ActiveTextBox.Text.Length - 1);
        }
        /// <summary>
        /// this method resets the numeric keyboard and related variables 
        /// </summary>
        private void ClearNumericKeyboard()
        {
            CalculatedBMITextBox.Text = "";
            outputValue = 0.0f;
            outputString = "";
            decimalExists = false;
            WeightTextBox.Text = "";
            HeightTextBox.Text = "";
            ActiveTextBox = WeightTextBox;
            ConditionTextBox.Text = "";
            HeightTextBox.BackColor = Color.White;
        }

        /// <summary>
        ///  this is the event handler for ActiveTextBox Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveTextBox_Click(object sender, EventArgs e)
        {
            if (ActiveTextBox != null)
            {
                ActiveTextBox.BackColor = Color.White;
            }
            ActiveTextBox = sender as TextBox;
            ActiveTextBox.BackColor = Color.Azure;
            if (ActiveTextBox.Text != "0")
            {
                outputString = ActiveTextBox.Text;
            }
        }
        /// <summary>
        /// this is the event handler for MetricRadioButton Checked event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            WeightUnitLabel.Text = "kg";
            HeightUnitLabel.Text = "cm";
        }
        /// <summary>
        /// this is the event handler for ImperialRadioButton Checked event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            WeightUnitLabel.Text = "lb";
            HeightUnitLabel.Text = "in";
        }

        /// <summary>
        /// this method calculates BMI 
        /// </summary>
        private void CalculateBMI()
        {
            if (float.TryParse(HeightTextBox.Text, out float Height) && float.TryParse(WeightTextBox.Text, out float Weight))
            {
                var height = Convert.ToDouble(HeightTextBox.Text);
                var weight = Convert.ToDouble(WeightTextBox.Text);
                if (height > 0 && height <= 999 && weight > 0 && weight <= 999)
                {
                    if (MetricRadioButton.Checked == true)
                    {
                        Result = (weight /( height * height)) * 10000;
                        CalculatedBMITextBox.Text = string.Format($"{Result:F1}").ToString();
                        DisplayBMILevel();
                    }
                    else if (ImperialRadioButton.Checked == true)
                    {
                        Result = weight * 703 / (height * height);
                        CalculatedBMITextBox.Text = string.Format($"{Result:F1}").ToString();
                        DisplayBMILevel();
                    }
                }

                else
                {
                    CalculatedBMITextBox.Text = "Please Enter all values!";
                    CalculatedBMITextBox.ForeColor = Color.Navy;
                }
            }

            else
            {
                CalculatedBMITextBox.Text = "Please Enter all values!";
                CalculatedBMITextBox.ForeColor = Color.Navy;
            }
            
        }

        private void DisplayBMILevel()
        {
            BMIProgressBar.Value = 0;
            BMIProgressBar.Maximum = 4;
            if (Result < 18.5)
            {
                ConditionTextBox.Text = "You are Underweight";
                ConditionTextBox.ForeColor = Color.Brown;
                BMIProgressBar.Value += 1;
                BMIProgressBar.ForeColor = Color.Brown;
            }
            else if (Result >= 18.5 && Result <= 24.9)
            {
                ConditionTextBox.Text = "You are Normal";
                ConditionTextBox.ForeColor = Color.Green;
                BMIProgressBar.Value += 2;
                BMIProgressBar.ForeColor = Color.Green;
            }
            else if (Result >= 25 && Result <= 29.9)
            {
                ConditionTextBox.Text = "You are Overweight";
                ConditionTextBox.ForeColor = Color.Orange;
                BMIProgressBar.Value += 3;
                BMIProgressBar.ForeColor = Color.Orange;
            }
            else if (Result >= 30)
            {
                ConditionTextBox.Text = "You are Obese";
                ConditionTextBox.ForeColor = Color.Red;
                BMIProgressBar.Value += 4;
                BMIProgressBar.ForeColor = Color.Red;
            }
        }

        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
