namespace ArtsCalculator
{
    partial class ArtsCalculator
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.FirstValueLabel = new System.Windows.Forms.Label();
            this.SecondValueLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.OperatorGroupBox = new System.Windows.Forms.GroupBox();
            this.AddRadioButton = new System.Windows.Forms.RadioButton();
            this.SubtractRadioButton = new System.Windows.Forms.RadioButton();
            this.MultiplyRadioButton = new System.Windows.Forms.RadioButton();
            this.DivideRadioButton = new System.Windows.Forms.RadioButton();
            this.FirstValueTextBox = new System.Windows.Forms.TextBox();
            this.SecondValueTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.OperatorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(15, 159);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(100, 20);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // FirstValueLabel
            // 
            this.FirstValueLabel.AutoSize = true;
            this.FirstValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstValueLabel.Location = new System.Drawing.Point(15, 9);
            this.FirstValueLabel.Name = "FirstValueLabel";
            this.FirstValueLabel.Size = new System.Drawing.Size(67, 13);
            this.FirstValueLabel.TabIndex = 1;
            this.FirstValueLabel.Text = "First Value";
            // 
            // SecondValueLabel
            // 
            this.SecondValueLabel.AutoSize = true;
            this.SecondValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondValueLabel.Location = new System.Drawing.Point(15, 84);
            this.SecondValueLabel.Name = "SecondValueLabel";
            this.SecondValueLabel.Size = new System.Drawing.Size(86, 13);
            this.SecondValueLabel.TabIndex = 2;
            this.SecondValueLabel.Text = "Second Value";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(15, 203);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(53, 13);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "Results:";
            // 
            // OperatorGroupBox
            // 
            this.OperatorGroupBox.Controls.Add(this.DivideRadioButton);
            this.OperatorGroupBox.Controls.Add(this.MultiplyRadioButton);
            this.OperatorGroupBox.Controls.Add(this.SubtractRadioButton);
            this.OperatorGroupBox.Controls.Add(this.AddRadioButton);
            this.OperatorGroupBox.Location = new System.Drawing.Point(198, 12);
            this.OperatorGroupBox.Name = "OperatorGroupBox";
            this.OperatorGroupBox.Size = new System.Drawing.Size(151, 169);
            this.OperatorGroupBox.TabIndex = 4;
            this.OperatorGroupBox.TabStop = false;
            this.OperatorGroupBox.Text = "Operator";
            this.OperatorGroupBox.Enter += new System.EventHandler(this.OperatorGroupBox_Enter);
            // 
            // AddRadioButton
            // 
            this.AddRadioButton.AutoSize = true;
            this.AddRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRadioButton.Location = new System.Drawing.Point(23, 31);
            this.AddRadioButton.Name = "AddRadioButton";
            this.AddRadioButton.Size = new System.Drawing.Size(47, 17);
            this.AddRadioButton.TabIndex = 0;
            this.AddRadioButton.TabStop = true;
            this.AddRadioButton.Text = "Add";
            this.AddRadioButton.UseVisualStyleBackColor = true;
            // 
            // SubtractRadioButton
            // 
            this.SubtractRadioButton.AutoSize = true;
            this.SubtractRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractRadioButton.Location = new System.Drawing.Point(23, 67);
            this.SubtractRadioButton.Name = "SubtractRadioButton";
            this.SubtractRadioButton.Size = new System.Drawing.Size(73, 17);
            this.SubtractRadioButton.TabIndex = 1;
            this.SubtractRadioButton.TabStop = true;
            this.SubtractRadioButton.Text = "Subtract";
            this.SubtractRadioButton.UseVisualStyleBackColor = true;
            // 
            // MultiplyRadioButton
            // 
            this.MultiplyRadioButton.AutoSize = true;
            this.MultiplyRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyRadioButton.Location = new System.Drawing.Point(23, 103);
            this.MultiplyRadioButton.Name = "MultiplyRadioButton";
            this.MultiplyRadioButton.Size = new System.Drawing.Size(68, 17);
            this.MultiplyRadioButton.TabIndex = 2;
            this.MultiplyRadioButton.TabStop = true;
            this.MultiplyRadioButton.Text = "Multiply";
            this.MultiplyRadioButton.UseVisualStyleBackColor = true;
            // 
            // DivideRadioButton
            // 
            this.DivideRadioButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DivideRadioButton.AutoSize = true;
            this.DivideRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideRadioButton.Location = new System.Drawing.Point(23, 139);
            this.DivideRadioButton.Name = "DivideRadioButton";
            this.DivideRadioButton.Size = new System.Drawing.Size(61, 17);
            this.DivideRadioButton.TabIndex = 3;
            this.DivideRadioButton.TabStop = true;
            this.DivideRadioButton.Text = "Divide";
            this.DivideRadioButton.UseVisualStyleBackColor = true;
            // 
            // FirstValueTextBox
            // 
            this.FirstValueTextBox.Location = new System.Drawing.Point(15, 43);
            this.FirstValueTextBox.Name = "FirstValueTextBox";
            this.FirstValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstValueTextBox.TabIndex = 5;
            this.FirstValueTextBox.TextChanged += new System.EventHandler(this.FirstValueTextBox_TextChanged);
            // 
            // SecondValueTextBox
            // 
            this.SecondValueTextBox.Location = new System.Drawing.Point(15, 118);
            this.SecondValueTextBox.Name = "SecondValueTextBox";
            this.SecondValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.SecondValueTextBox.TabIndex = 6;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(15, 237);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(100, 20);
            this.ResultTextBox.TabIndex = 7;
            // 
            // ArtsCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 366);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.SecondValueTextBox);
            this.Controls.Add(this.FirstValueTextBox);
            this.Controls.Add(this.OperatorGroupBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.SecondValueLabel);
            this.Controls.Add(this.FirstValueLabel);
            this.Controls.Add(this.CalculateButton);
            this.Name = "ArtsCalculator";
            this.Text = "Arts Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.OperatorGroupBox.ResumeLayout(false);
            this.OperatorGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label FirstValueLabel;
        private System.Windows.Forms.Label SecondValueLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.GroupBox OperatorGroupBox;
        private System.Windows.Forms.RadioButton DivideRadioButton;
        private System.Windows.Forms.RadioButton MultiplyRadioButton;
        private System.Windows.Forms.RadioButton SubtractRadioButton;
        private System.Windows.Forms.RadioButton AddRadioButton;
        private System.Windows.Forms.TextBox FirstValueTextBox;
        private System.Windows.Forms.TextBox SecondValueTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}

