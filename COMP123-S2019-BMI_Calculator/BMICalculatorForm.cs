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
            ActiveTextBox = WeightTextBox;
            WeightUnitLabel.Text = "kg";
            HeightUnitLabel.Text = "cm";
           // NumericKeyboardPanel.Visible = true;
        }

        /// <summary>
        /// this is the event handler for BMICalculatorForm Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_Click(object sender, EventArgs e)
        {
            ClearNumericKeyboard();
            if (ActiveTextBox.Text != string.Empty)
            {
                ActiveTextBox.BackColor = Color.White;
            }
            ActiveTextBox.Text = string.Empty;
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
                if (outputString == "0")
                {
                    outputString = tag;
                }
                if (outputString != "0" && outputString.Length < maxSize)
                {
                    outputString += tag;
                }
                ActiveTextBox.Text = outputString;
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
                        //CalculateBMI();
                        BMIProgressBar.Value = 0;
                        break;
                    case "decimal":
                        AddDecimalToActiveTextBox();
                        break;
                }
            }
        }

        /// <summary>
        /// this method finalizes and converts the outputString to a floating point value
        /// </summary>
        private void FinalizeOutput()
        {
            if (outputString == string.Empty)
            {
                outputString = "0";
            }
            if (outputValue < 0.1f)
            {
                outputValue = 0.1f;
            }
            outputValue = float.Parse(outputString);

            outputValue = (float)(Math.Round(outputValue, 1));
            ActiveTextBox.Text = outputValue.ToString();
            ClearNumericKeyboard();

            ActiveTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// this method adds a decimal point  to the ActiveTextBox
        /// </summary>
        private void AddDecimalToActiveTextBox()
        {
            if (!decimalExists)
            {
                outputString += ".";
                decimalExists = true;
            }
        }

        /// <summary>
        /// this method removes the last character from the ActiveTextBox
        /// </summary>
        private void RemoveLastCharacterFromActiveTextBox()

        {
            var lastChar = outputString.Substring(outputString.Length - 1);
            if (lastChar == ".")
            {
                decimalExists = false;
            }
            outputString = outputString.Remove(outputString.Length - 1);
            if (outputString.Length == 0)
            {
                outputString = "0";
            }
            ActiveTextBox.Text = outputString;
        }
        /// <summary>
        /// this method resets the numeric keyboard and related variables 
        /// </summary>
        private void ClearNumericKeyboard()
        {
            CalculatedBMITextBox.Text = "0";
            outputValue = 0.0f;
            outputString = null;
            decimalExists = false;
            WeightTextBox.Text = "0";
            HeightTextBox.Text = "0";
            ConditionTextBox.Text = "";
            BMIProgressBar.Value = 0;
        }

        /// <summary>
        ///  this is the event handler for ActiveTextBox Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveTextBox_Click(object sender, EventArgs e)
        {
            ActiveTextBox = sender as TextBox;
            if (ActiveTextBox != null)
            {
                ActiveTextBox.BackColor = Color.White;
                ActiveTextBox = null;
            }
            outputValue = 0.0f;
            outputString = String.Empty;
            NumericKeyboardPanel.Visible = true;
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
        
    }
}
