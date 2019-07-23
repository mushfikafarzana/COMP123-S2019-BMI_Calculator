﻿namespace COMP123_S2019_BMI_Calculator
{
    partial class BMICalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.NumericKeyboardPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.BackSpaceButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.BMIResultProgressBar = new System.Windows.Forms.ProgressBar();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.EnterHeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.DisplayBMILabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CalculatedBMITextBox = new System.Windows.Forms.TextBox();
            this.BMILabel = new System.Windows.Forms.Label();
            this.NumericKeyboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialButton.Location = new System.Drawing.Point(155, 3);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(108, 30);
            this.ImperialButton.TabIndex = 1;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Text = "Imperial";
            this.ImperialButton.UseVisualStyleBackColor = true;
            // 
            // MetricButton
            // 
            this.MetricButton.AutoSize = true;
            this.MetricButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricButton.Location = new System.Drawing.Point(24, 3);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(89, 30);
            this.MetricButton.TabIndex = 2;
            this.MetricButton.TabStop = true;
            this.MetricButton.Text = "Metric";
            this.MetricButton.UseVisualStyleBackColor = true;
            // 
            // NumericKeyboardPanel
            // 
            this.NumericKeyboardPanel.ColumnCount = 4;
            this.NumericKeyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumericKeyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumericKeyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumericKeyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumericKeyboardPanel.Controls.Add(this.TwoButton, 1, 2);
            this.NumericKeyboardPanel.Controls.Add(this.OneButton, 0, 2);
            this.NumericKeyboardPanel.Controls.Add(this.SixButton, 2, 1);
            this.NumericKeyboardPanel.Controls.Add(this.FiveButton, 1, 1);
            this.NumericKeyboardPanel.Controls.Add(this.NineButton, 2, 0);
            this.NumericKeyboardPanel.Controls.Add(this.EightButton, 1, 0);
            this.NumericKeyboardPanel.Controls.Add(this.SevenButton, 0, 0);
            this.NumericKeyboardPanel.Controls.Add(this.BackSpaceButton, 3, 0);
            this.NumericKeyboardPanel.Controls.Add(this.FourButton, 0, 1);
            this.NumericKeyboardPanel.Controls.Add(this.ZeroButton, 3, 1);
            this.NumericKeyboardPanel.Controls.Add(this.ThreeButton, 2, 2);
            this.NumericKeyboardPanel.Controls.Add(this.DecimalButton, 3, 2);
            this.NumericKeyboardPanel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericKeyboardPanel.ForeColor = System.Drawing.Color.White;
            this.NumericKeyboardPanel.Location = new System.Drawing.Point(12, 284);
            this.NumericKeyboardPanel.Name = "NumericKeyboardPanel";
            this.NumericKeyboardPanel.RowCount = 3;
            this.NumericKeyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.NumericKeyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.NumericKeyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.NumericKeyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NumericKeyboardPanel.Size = new System.Drawing.Size(280, 145);
            this.NumericKeyboardPanel.TabIndex = 11;
            // 
            // ThreeButton
            // 
            this.ThreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ThreeButton.Location = new System.Drawing.Point(143, 99);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(64, 43);
            this.ThreeButton.TabIndex = 8;
            this.ThreeButton.Tag = "3";
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.KeyBoardButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TwoButton.BackColor = System.Drawing.Color.SteelBlue;
            this.TwoButton.Location = new System.Drawing.Point(73, 99);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(64, 43);
            this.TwoButton.TabIndex = 7;
            this.TwoButton.Tag = "2";
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.KeyBoardButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneButton.BackColor = System.Drawing.Color.SteelBlue;
            this.OneButton.Location = new System.Drawing.Point(3, 99);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(64, 43);
            this.OneButton.TabIndex = 6;
            this.OneButton.Tag = "1";
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.KeyBoardButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SixButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SixButton.Location = new System.Drawing.Point(143, 51);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(64, 42);
            this.SixButton.TabIndex = 5;
            this.SixButton.Tag = "6";
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.KeyBoardButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiveButton.BackColor = System.Drawing.Color.SteelBlue;
            this.FiveButton.Location = new System.Drawing.Point(73, 51);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(64, 42);
            this.FiveButton.TabIndex = 4;
            this.FiveButton.Tag = "5";
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.KeyBoardButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NineButton.BackColor = System.Drawing.Color.SteelBlue;
            this.NineButton.Location = new System.Drawing.Point(143, 3);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(64, 42);
            this.NineButton.TabIndex = 2;
            this.NineButton.Tag = "9";
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.KeyBoardButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EightButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EightButton.Location = new System.Drawing.Point(73, 3);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(64, 42);
            this.EightButton.TabIndex = 1;
            this.EightButton.Tag = "8";
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.KeyBoardButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SevenButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SevenButton.Location = new System.Drawing.Point(3, 3);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(64, 42);
            this.SevenButton.TabIndex = 0;
            this.SevenButton.Tag = "7";
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.KeyBoardButton_Click);
            // 
            // BackSpaceButton
            // 
            this.BackSpaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackSpaceButton.BackColor = System.Drawing.Color.SteelBlue;
            this.BackSpaceButton.BackgroundImage = global::COMP123_S2019_BMI_Calculator.Properties.Resources.backbutton;
            this.BackSpaceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackSpaceButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackSpaceButton.Location = new System.Drawing.Point(213, 3);
            this.BackSpaceButton.Name = "BackSpaceButton";
            this.BackSpaceButton.Size = new System.Drawing.Size(64, 42);
            this.BackSpaceButton.TabIndex = 2;
            this.BackSpaceButton.Tag = "back";
            this.BackSpaceButton.UseVisualStyleBackColor = false;
            this.BackSpaceButton.Click += new System.EventHandler(this.KeyBoardButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FourButton.BackColor = System.Drawing.Color.SteelBlue;
            this.FourButton.Location = new System.Drawing.Point(3, 51);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(64, 42);
            this.FourButton.TabIndex = 3;
            this.FourButton.Tag = "4";
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.KeyBoardButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZeroButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ZeroButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.Location = new System.Drawing.Point(213, 51);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(64, 42);
            this.ZeroButton.TabIndex = 11;
            this.ZeroButton.Tag = "0";
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.KeyBoardButton_Click);
            // 
            // BMIResultProgressBar
            // 
            this.BMIResultProgressBar.Location = new System.Drawing.Point(30, 196);
            this.BMIResultProgressBar.Name = "BMIResultProgressBar";
            this.BMIResultProgressBar.Size = new System.Drawing.Size(243, 27);
            this.BMIResultProgressBar.TabIndex = 12;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(18, 46);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(106, 31);
            this.WeightLabel.TabIndex = 14;
            this.WeightLabel.Text = "Weight:";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnterHeightLabel
            // 
            this.EnterHeightLabel.AutoSize = true;
            this.EnterHeightLabel.Location = new System.Drawing.Point(18, 98);
            this.EnterHeightLabel.Name = "EnterHeightLabel";
            this.EnterHeightLabel.Size = new System.Drawing.Size(101, 31);
            this.EnterHeightLabel.TabIndex = 14;
            this.EnterHeightLabel.Text = "Height:";
            this.EnterHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.BackColor = System.Drawing.Color.White;
            this.HeightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeightLabel.Location = new System.Drawing.Point(169, 165);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(108, 0);
            this.HeightLabel.TabIndex = 14;
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HeightLabel.Click += new System.EventHandler(this.ActiveLabel_Click);
            // 
            // DisplayBMILabel
            // 
            this.DisplayBMILabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayBMILabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DisplayBMILabel.Location = new System.Drawing.Point(37, 162);
            this.DisplayBMILabel.Name = "DisplayBMILabel";
            this.DisplayBMILabel.Size = new System.Drawing.Size(72, 0);
            this.DisplayBMILabel.TabIndex = 15;
            this.DisplayBMILabel.Text = "BMI:";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(130, 46);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(114, 38);
            this.WeightTextBox.TabIndex = 16;
            this.WeightTextBox.Click += new System.EventHandler(this.ActiveLabel_Click);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(130, 98);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(114, 38);
            this.HeightTextBox.TabIndex = 17;
            this.HeightTextBox.Click += new System.EventHandler(this.ActiveLabel_Click);
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.Location = new System.Drawing.Point(250, 46);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(51, 38);
            this.WeightUnitLabel.TabIndex = 18;
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.Location = new System.Drawing.Point(250, 98);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(51, 38);
            this.HeightUnitLabel.TabIndex = 19;
            // 
            // DecimalButton
            // 
            this.DecimalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecimalButton.BackColor = System.Drawing.Color.SteelBlue;
            this.DecimalButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalButton.Location = new System.Drawing.Point(213, 99);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(64, 43);
            this.DecimalButton.TabIndex = 12;
            this.DecimalButton.Tag = "decimal";
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = false;
            this.DecimalButton.Click += new System.EventHandler(this.KeyBoardButton_Click);
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.BackColor = System.Drawing.Color.Navy;
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.ForeColor = System.Drawing.Color.White;
            this.CalculateBMIButton.Location = new System.Drawing.Point(24, 229);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(134, 39);
            this.CalculateBMIButton.TabIndex = 20;
            this.CalculateBMIButton.Tag = "calculate";
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            this.CalculateBMIButton.Click += new System.EventHandler(this.KeyBoardButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Green;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(174, 229);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(103, 39);
            this.ResetButton.TabIndex = 21;
            this.ResetButton.Tag = "reset";
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.KeyBoardButton_Click);
            // 
            // CalculatedBMITextBox
            // 
            this.CalculatedBMITextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CalculatedBMITextBox.Location = new System.Drawing.Point(111, 149);
            this.CalculatedBMITextBox.Name = "CalculatedBMITextBox";
            this.CalculatedBMITextBox.Size = new System.Drawing.Size(152, 38);
            this.CalculatedBMITextBox.TabIndex = 22;
            this.CalculatedBMITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BMILabel
            // 
            this.BMILabel.Location = new System.Drawing.Point(24, 149);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(81, 38);
            this.BMILabel.TabIndex = 23;
            this.BMILabel.Text = "BMI:";
            this.BMILabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BMILabel);
            this.Controls.Add(this.CalculatedBMITextBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CalculateBMIButton);
            this.Controls.Add(this.HeightUnitLabel);
            this.Controls.Add(this.WeightUnitLabel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.DisplayBMILabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.EnterHeightLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.BMIResultProgressBar);
            this.Controls.Add(this.NumericKeyboardPanel);
            this.Controls.Add(this.MetricButton);
            this.Controls.Add(this.ImperialButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator App";
            this.Load += new System.EventHandler(this.BMICalculatorForm_Load);
            this.NumericKeyboardPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.TableLayoutPanel NumericKeyboardPanel;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button BackSpaceButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.ProgressBar BMIResultProgressBar;
        private System.Windows.Forms.Label EnterHeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label DisplayBMILabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label WeightUnitLabel;
        private System.Windows.Forms.Label HeightUnitLabel;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox CalculatedBMITextBox;
        private System.Windows.Forms.Label BMILabel;
    }
}

