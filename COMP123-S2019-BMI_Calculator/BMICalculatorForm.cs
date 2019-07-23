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
        public Label ActiveLabel { get; set; }

        public Animation animationState;

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
            clearNumericKeyboard();
            ActiveLabel = null;
            NumericKeyboardPanel.Visible = true;
        }

        /// <summary>
        /// this is the event handler for BMICalculatorForm Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_Click(object sender, EventArgs e)
        {
            clearNumericKeyboard();
            if (ActiveLabel != null)
            {
                ActiveLabel.BackColor = Color.White;
            }
            ActiveLabel = null;
        }

        /// <summary>
        /// this is the shared event handler for all the calculator buttons - click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void KeyBoardButton_Click(object sender, EventArgs e)
        {
            Button TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();

            int buttonValue = 0;
            bool numericResult = int.TryParse(tag, out buttonValue);

            //If the user pressed a number button 
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
                if ((outputString != "0") && (ActiveLabel.Text.Count() < maxSize))
                {
                    outputString += tag;
                    ActiveLabel.Text = outputString;
                }
            }

            // if the user pressed a button that is not a number
            else
            {
                switch (tag)
                {
                    case "reset":
                        clearNumericKeyboard();
                        break;
                    case "back":
                        removeLastCharacterFromResultLabel();
                        break;
                    case "calculate":
                        finalizeOutput();
                        break;
                    case "decimal":
                        addDecimalToResultLabel();
                        break;
                }
            }
        }

        /// <summary>
        /// this method finalizes and converts the outputString to a floating point value
        /// </summary>
        private void finalizeOutput()
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
            ActiveLabel.Text = outputValue.ToString();
            clearNumericKeyboard();

            ActiveLabel.BackColor = Color.White;
            ActiveLabel = null;
        }

        /// <summary>
        /// this method adds a decimal point  to the resultLabel
        /// </summary>
        private void addDecimalToResultLabel()
        {
            if (!decimalExists)
            {
                outputString += ".";
                decimalExists = true;
            }
        }

        /// <summary>
        /// this method removes the last character from the resultLabel
        /// </summary>
        private void removeLastCharacterFromResultLabel()

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
            CalculatedBMITextBox.Text = outputString;
        }
        /// <summary>
        /// this method resets the numeric keyboard and related variables 
        /// </summary>
        private void clearNumericKeyboard()
        {
            CalculatedBMITextBox.Text = "0";
            outputString = String.Empty;
            decimalExists = false;
            outputValue = 0.0f;
        }

        /// <summary>
        ///  this is the event handler for ActiveLabel Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveLabel_Click(object sender, EventArgs e)
        {
            if (ActiveLabel != null)
            {
                ActiveLabel.BackColor = Color.White;
                ActiveLabel = null;
            }

            ActiveLabel = sender as Label;

            ActiveLabel.BackColor = Color.LightBlue;

            NumericKeyboardPanel.Visible = true;

            if (ActiveLabel.Text != "0")
            {
                CalculatedBMITextBox.Text = ActiveLabel.Text;
                outputString = ActiveLabel.Text;
            }
        }
    }
}
