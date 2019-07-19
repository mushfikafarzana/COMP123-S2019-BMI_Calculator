namespace COMP123_S2019_BMI_Calculator
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
            this.HeightWeightPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.CalculatedBMITextBox = new System.Windows.Forms.TextBox();
            this.BMICalculatorLabel = new System.Windows.Forms.Label();
            this.ResetBMIButton = new System.Windows.Forms.Button();
            this.BMIResultLabel = new System.Windows.Forms.Label();
            this.HeightWeightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeightWeightPanel
            // 
            this.HeightWeightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightWeightPanel.ColumnCount = 2;
            this.HeightWeightPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeightWeightPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeightWeightPanel.Controls.Add(this.WeightLabel, 0, 1);
            this.HeightWeightPanel.Controls.Add(this.WeightTextBox, 1, 1);
            this.HeightWeightPanel.Controls.Add(this.HeightTextBox, 1, 0);
            this.HeightWeightPanel.Controls.Add(this.HeightLabel, 0, 0);
            this.HeightWeightPanel.Location = new System.Drawing.Point(21, 134);
            this.HeightWeightPanel.Name = "HeightWeightPanel";
            this.HeightWeightPanel.RowCount = 2;
            this.HeightWeightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeightWeightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeightWeightPanel.Size = new System.Drawing.Size(267, 75);
            this.HeightWeightPanel.TabIndex = 0;
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialButton.Location = new System.Drawing.Point(34, 66);
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
            this.MetricButton.Location = new System.Drawing.Point(175, 66);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(89, 30);
            this.MetricButton.TabIndex = 2;
            this.MetricButton.TabStop = true;
            this.MetricButton.Text = "Metric";
            this.MetricButton.UseVisualStyleBackColor = true;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(3, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(127, 37);
            this.HeightLabel.TabIndex = 3;
            this.HeightLabel.Text = "My Height:";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(3, 37);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(127, 38);
            this.WeightLabel.TabIndex = 4;
            this.WeightLabel.Text = "My Weight:";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightTextBox.Location = new System.Drawing.Point(136, 3);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(128, 32);
            this.HeightTextBox.TabIndex = 5;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTextBox.Location = new System.Drawing.Point(136, 40);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(128, 32);
            this.WeightTextBox.TabIndex = 6;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.BackColor = System.Drawing.Color.Navy;
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.ForeColor = System.Drawing.Color.White;
            this.CalculateBMIButton.Location = new System.Drawing.Point(21, 241);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(121, 29);
            this.CalculateBMIButton.TabIndex = 7;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            // 
            // CalculatedBMITextBox
            // 
            this.CalculatedBMITextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculatedBMITextBox.BackColor = System.Drawing.Color.Honeydew;
            this.CalculatedBMITextBox.ForeColor = System.Drawing.Color.Teal;
            this.CalculatedBMITextBox.Location = new System.Drawing.Point(145, 304);
            this.CalculatedBMITextBox.Name = "CalculatedBMITextBox";
            this.CalculatedBMITextBox.Size = new System.Drawing.Size(140, 38);
            this.CalculatedBMITextBox.TabIndex = 9;
            // 
            // BMICalculatorLabel
            // 
            this.BMICalculatorLabel.AutoSize = true;
            this.BMICalculatorLabel.ForeColor = System.Drawing.Color.Navy;
            this.BMICalculatorLabel.Location = new System.Drawing.Point(61, 9);
            this.BMICalculatorLabel.Name = "BMICalculatorLabel";
            this.BMICalculatorLabel.Size = new System.Drawing.Size(192, 31);
            this.BMICalculatorLabel.TabIndex = 10;
            this.BMICalculatorLabel.Text = "BMI Calculator";
            // 
            // ResetBMIButton
            // 
            this.ResetBMIButton.BackColor = System.Drawing.Color.Navy;
            this.ResetBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBMIButton.ForeColor = System.Drawing.Color.White;
            this.ResetBMIButton.Location = new System.Drawing.Point(157, 241);
            this.ResetBMIButton.Name = "ResetBMIButton";
            this.ResetBMIButton.Size = new System.Drawing.Size(121, 29);
            this.ResetBMIButton.TabIndex = 7;
            this.ResetBMIButton.Text = "Reset";
            this.ResetBMIButton.UseVisualStyleBackColor = false;
            // 
            // BMIResultLabel
            // 
            this.BMIResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMIResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIResultLabel.Location = new System.Drawing.Point(67, 306);
            this.BMIResultLabel.Name = "BMIResultLabel";
            this.BMIResultLabel.Size = new System.Drawing.Size(75, 38);
            this.BMIResultLabel.TabIndex = 3;
            this.BMIResultLabel.Text = "BMI:";
            this.BMIResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BMICalculatorLabel);
            this.Controls.Add(this.CalculatedBMITextBox);
            this.Controls.Add(this.ResetBMIButton);
            this.Controls.Add(this.BMIResultLabel);
            this.Controls.Add(this.CalculateBMIButton);
            this.Controls.Add(this.MetricButton);
            this.Controls.Add(this.ImperialButton);
            this.Controls.Add(this.HeightWeightPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator App";
            this.HeightWeightPanel.ResumeLayout(false);
            this.HeightWeightPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel HeightWeightPanel;
        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox CalculatedBMITextBox;
        private System.Windows.Forms.Label BMICalculatorLabel;
        private System.Windows.Forms.Button ResetBMIButton;
        private System.Windows.Forms.Label BMIResultLabel;
    }
}

