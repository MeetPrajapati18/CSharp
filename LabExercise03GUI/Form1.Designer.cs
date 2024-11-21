namespace LabExercise03GUI
{
    partial class Form1
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
            this.ListButton = new System.Windows.Forms.Button();
            this.MileageButton = new System.Windows.Forms.Button();
            this.FordButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListButton
            // 
            this.ListButton.Location = new System.Drawing.Point(25, 18);
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(340, 75);
            this.ListButton.TabIndex = 0;
            this.ListButton.Text = "&List All Cars";
            this.ListButton.UseVisualStyleBackColor = true;
            this.ListButton.Click += new System.EventHandler(this.ListButton_Click);
            // 
            // MileageButton
            // 
            this.MileageButton.Location = new System.Drawing.Point(25, 140);
            this.MileageButton.Name = "MileageButton";
            this.MileageButton.Size = new System.Drawing.Size(340, 75);
            this.MileageButton.TabIndex = 1;
            this.MileageButton.Text = "Cars With Best &Mileage";
            this.MileageButton.UseVisualStyleBackColor = true;
            this.MileageButton.Click += new System.EventHandler(this.MileageButton_Click);
            // 
            // FordButton
            // 
            this.FordButton.Location = new System.Drawing.Point(25, 262);
            this.FordButton.Name = "FordButton";
            this.FordButton.Size = new System.Drawing.Size(340, 75);
            this.FordButton.TabIndex = 2;
            this.FordButton.Text = "Cars Built By &Ford";
            this.FordButton.UseVisualStyleBackColor = true;
            this.FordButton.Click += new System.EventHandler(this.FordButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(19, 366);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(101, 32);
            this.OutputLabel.TabIndex = 3;
            this.OutputLabel.Text = "Output";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(25, 401);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(966, 263);
            this.OutputTextBox.TabIndex = 4;
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(25, 702);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(340, 75);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.ListButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(1023, 803);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.FordButton);
            this.Controls.Add(this.MileageButton);
            this.Controls.Add(this.ListButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "COMP102054 - Week 2 Lab Exercise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ListButton;
        private System.Windows.Forms.Button MileageButton;
        private System.Windows.Forms.Button FordButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button ExitButton;
    }
}

