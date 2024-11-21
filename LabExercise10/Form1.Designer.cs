namespace LabExercise10
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
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.lastNameButton = new System.Windows.Forms.Button();
            this.grade1Button = new System.Windows.Forms.Button();
            this.grade2Button = new System.Windows.Forms.Button();
            this.averageButton = new System.Windows.Forms.Button();
            this.compositeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentListBox
            // 
            this.studentListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentListBox.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.ItemHeight = 23;
            this.studentListBox.Location = new System.Drawing.Point(25, 25);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(670, 326);
            this.studentListBox.TabIndex = 5;
            // 
            // lastNameButton
            // 
            this.lastNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameButton.Location = new System.Drawing.Point(25, 373);
            this.lastNameButton.Name = "lastNameButton";
            this.lastNameButton.Size = new System.Drawing.Size(122, 81);
            this.lastNameButton.TabIndex = 0;
            this.lastNameButton.Text = "Sort by Last Name";
            this.lastNameButton.UseVisualStyleBackColor = true;
            this.lastNameButton.Click += new System.EventHandler(this.LastNameButton_Click);
            // 
            // grade1Button
            // 
            this.grade1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade1Button.Location = new System.Drawing.Point(162, 373);
            this.grade1Button.Name = "grade1Button";
            this.grade1Button.Size = new System.Drawing.Size(122, 81);
            this.grade1Button.TabIndex = 1;
            this.grade1Button.Text = "Sort by Grade 1";
            this.grade1Button.UseVisualStyleBackColor = true;
            this.grade1Button.Click += new System.EventHandler(this.Grade1Button_Click);
            // 
            // grade2Button
            // 
            this.grade2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade2Button.Location = new System.Drawing.Point(299, 373);
            this.grade2Button.Name = "grade2Button";
            this.grade2Button.Size = new System.Drawing.Size(122, 81);
            this.grade2Button.TabIndex = 2;
            this.grade2Button.Text = "Sort by Grade 2";
            this.grade2Button.UseVisualStyleBackColor = true;
            this.grade2Button.Click += new System.EventHandler(this.Grade2Button_Click);
            // 
            // averageButton
            // 
            this.averageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageButton.Location = new System.Drawing.Point(436, 373);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(122, 81);
            this.averageButton.TabIndex = 3;
            this.averageButton.Text = "Sort by Average";
            this.averageButton.UseVisualStyleBackColor = true;
            this.averageButton.Click += new System.EventHandler(this.AverageButton_Click);
            // 
            // compositeButton
            // 
            this.compositeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compositeButton.Location = new System.Drawing.Point(573, 373);
            this.compositeButton.Name = "compositeButton";
            this.compositeButton.Size = new System.Drawing.Size(122, 81);
            this.compositeButton.TabIndex = 4;
            this.compositeButton.Text = "Sort by Grade1 then Grade 2";
            this.compositeButton.UseVisualStyleBackColor = true;
            this.compositeButton.Click += new System.EventHandler(this.CompositeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 479);
            this.Controls.Add(this.compositeButton);
            this.Controls.Add(this.averageButton);
            this.Controls.Add(this.grade2Button);
            this.Controls.Add(this.grade1Button);
            this.Controls.Add(this.lastNameButton);
            this.Controls.Add(this.studentListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting using Lambda Expressions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.Button lastNameButton;
        private System.Windows.Forms.Button grade1Button;
        private System.Windows.Forms.Button grade2Button;
        private System.Windows.Forms.Button averageButton;
        private System.Windows.Forms.Button compositeButton;
    }
}

