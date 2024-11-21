namespace LabExercise11
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
            this.components = new System.ComponentModel.Container();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.mouseGroupBox = new System.Windows.Forms.GroupBox();
            this.mouseMoveRadioButton = new System.Windows.Forms.RadioButton();
            this.mouseClickRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startButton = new System.Windows.Forms.Button();
            this.roundLabel = new System.Windows.Forms.Label();
            this.countdownLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scoresListBox = new System.Windows.Forms.ListBox();
            this.playerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonPanel.SuspendLayout();
            this.mouseGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.mouseGroupBox);
            this.buttonPanel.Controls.Add(this.groupBox1);
            this.buttonPanel.Controls.Add(this.label2);
            this.buttonPanel.Controls.Add(this.scoresListBox);
            this.buttonPanel.Controls.Add(this.playerTextBox);
            this.buttonPanel.Controls.Add(this.label1);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(282, 800);
            this.buttonPanel.TabIndex = 7;
            // 
            // mouseGroupBox
            // 
            this.mouseGroupBox.Controls.Add(this.mouseMoveRadioButton);
            this.mouseGroupBox.Controls.Add(this.mouseClickRadioButton);
            this.mouseGroupBox.Location = new System.Drawing.Point(12, 718);
            this.mouseGroupBox.Name = "mouseGroupBox";
            this.mouseGroupBox.Size = new System.Drawing.Size(105, 70);
            this.mouseGroupBox.TabIndex = 7;
            this.mouseGroupBox.TabStop = false;
            this.mouseGroupBox.Text = "Score Method:";
            // 
            // mouseMoveRadioButton
            // 
            this.mouseMoveRadioButton.AutoSize = true;
            this.mouseMoveRadioButton.Location = new System.Drawing.Point(6, 42);
            this.mouseMoveRadioButton.Name = "mouseMoveRadioButton";
            this.mouseMoveRadioButton.Size = new System.Drawing.Size(87, 17);
            this.mouseMoveRadioButton.TabIndex = 1;
            this.mouseMoveRadioButton.Text = "Mouse Move";
            this.mouseMoveRadioButton.UseVisualStyleBackColor = true;
            // 
            // mouseClickRadioButton
            // 
            this.mouseClickRadioButton.AutoSize = true;
            this.mouseClickRadioButton.Checked = true;
            this.mouseClickRadioButton.Location = new System.Drawing.Point(6, 19);
            this.mouseClickRadioButton.Name = "mouseClickRadioButton";
            this.mouseClickRadioButton.Size = new System.Drawing.Size(83, 17);
            this.mouseClickRadioButton.TabIndex = 0;
            this.mouseClickRadioButton.TabStop = true;
            this.mouseClickRadioButton.Text = "Mouse Click";
            this.mouseClickRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.roundLabel);
            this.groupBox1.Controls.Add(this.countdownLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(82, 19);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(87, 41);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // roundLabel
            // 
            this.roundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.Location = new System.Drawing.Point(82, 81);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(87, 23);
            this.roundLabel.TabIndex = 1;
            this.roundLabel.Text = "Round 0";
            this.roundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countdownLabel
            // 
            this.countdownLabel.BackColor = System.Drawing.SystemColors.Control;
            this.countdownLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countdownLabel.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel.Location = new System.Drawing.Point(82, 118);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(87, 65);
            this.countdownLabel.TabIndex = 2;
            this.countdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Top Scores:";
            // 
            // scoresListBox
            // 
            this.scoresListBox.BackColor = System.Drawing.SystemColors.Control;
            this.scoresListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoresListBox.FormattingEnabled = true;
            this.scoresListBox.Location = new System.Drawing.Point(15, 304);
            this.scoresListBox.Name = "scoresListBox";
            this.scoresListBox.Size = new System.Drawing.Size(261, 117);
            this.scoresListBox.TabIndex = 6;
            this.scoresListBox.TabStop = false;
            // 
            // playerTextBox
            // 
            this.playerTextBox.Location = new System.Drawing.Point(15, 246);
            this.playerTextBox.Name = "playerTextBox";
            this.playerTextBox.Size = new System.Drawing.Size(261, 20);
            this.playerTextBox.TabIndex = 4;
            this.playerTextBox.Text = "Nick";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player:";
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.drawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingPanel.Location = new System.Drawing.Point(282, 0);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(813, 800);
            this.drawingPanel.TabIndex = 8;
            this.drawingPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseClick);
            this.drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseMove);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 5000;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.CountdownTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 800);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.buttonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Let\'s Play A Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.buttonPanel.ResumeLayout(false);
            this.buttonPanel.PerformLayout();
            this.mouseGroupBox.ResumeLayout(false);
            this.mouseGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Label countdownLabel;
        private System.Windows.Forms.TextBox playerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox scoresListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox mouseGroupBox;
        private System.Windows.Forms.RadioButton mouseMoveRadioButton;
        private System.Windows.Forms.RadioButton mouseClickRadioButton;
    }
}

