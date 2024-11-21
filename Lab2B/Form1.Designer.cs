using System.Drawing;

namespace Lab2B
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
            this.Hairdresser = new System.Windows.Forms.GroupBox();
            this.Jane = new System.Windows.Forms.RadioButton();
            this.Laura = new System.Windows.Forms.RadioButton();
            this.Pat = new System.Windows.Forms.RadioButton();
            this.Ron = new System.Windows.Forms.RadioButton();
            this.Sue = new System.Windows.Forms.RadioButton();
            this.Service = new System.Windows.Forms.GroupBox();
            this.Cut = new System.Windows.Forms.CheckBox();
            this.Colour = new System.Windows.Forms.CheckBox();
            this.Highlights = new System.Windows.Forms.CheckBox();
            this.Extensions = new System.Windows.Forms.CheckBox();
            this.ClientType = new System.Windows.Forms.GroupBox();
            this.Senior = new System.Windows.Forms.RadioButton();
            this.Student = new System.Windows.Forms.RadioButton();
            this.Child = new System.Windows.Forms.RadioButton();
            this.StandardAdult = new System.Windows.Forms.RadioButton();
            this.ClientVisit = new System.Windows.Forms.GroupBox();
            this.NumberOfVisits = new System.Windows.Forms.TextBox();
            this.NumberOfClientVisit = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.Hairdresser.SuspendLayout();
            this.Service.SuspendLayout();
            this.ClientType.SuspendLayout();
            this.ClientVisit.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hairdresser
            // 
            this.Hairdresser.Controls.Add(this.Jane);
            this.Hairdresser.Controls.Add(this.Laura);
            this.Hairdresser.Controls.Add(this.Pat);
            this.Hairdresser.Controls.Add(this.Ron);
            this.Hairdresser.Controls.Add(this.Sue);
            this.Hairdresser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Hairdresser.Location = new System.Drawing.Point(34, 21);
            this.Hairdresser.Name = "Hairdresser";
            this.Hairdresser.Size = new System.Drawing.Size(219, 225);
            this.Hairdresser.TabIndex = 0;
            this.Hairdresser.TabStop = false;
            this.Hairdresser.Text = "Hairdresser";
            // 
            // Jane
            // 
            this.Jane.AutoSize = true;
            this.Jane.Location = new System.Drawing.Point(6, 25);
            this.Jane.Name = "Jane";
            this.Jane.Size = new System.Drawing.Size(136, 24);
            this.Jane.TabIndex = 1;
            this.Jane.TabStop = true;
            this.Jane.Text = "Jane Samley";
            this.Jane.UseVisualStyleBackColor = true;
            // 
            // Laura
            // 
            this.Laura.AutoSize = true;
            this.Laura.Location = new System.Drawing.Point(6, 185);
            this.Laura.Name = "Laura";
            this.Laura.Size = new System.Drawing.Size(150, 24);
            this.Laura.TabIndex = 1;
            this.Laura.TabStop = true;
            this.Laura.Text = "Laura Renkins";
            this.Laura.UseVisualStyleBackColor = true;
            // 
            // Pat
            // 
            this.Pat.AutoSize = true;
            this.Pat.Location = new System.Drawing.Point(6, 64);
            this.Pat.Name = "Pat";
            this.Pat.Size = new System.Drawing.Size(134, 24);
            this.Pat.TabIndex = 2;
            this.Pat.TabStop = true;
            this.Pat.Text = "Pat Johnson";
            this.Pat.UseVisualStyleBackColor = true;
            // 
            // Ron
            // 
            this.Ron.AutoSize = true;
            this.Ron.Location = new System.Drawing.Point(6, 106);
            this.Ron.Name = "Ron";
            this.Ron.Size = new System.Drawing.Size(153, 24);
            this.Ron.TabIndex = 3;
            this.Ron.TabStop = true;
            this.Ron.Text = "Ron Chambers";
            this.Ron.UseVisualStyleBackColor = true;
            // 
            // Sue
            // 
            this.Sue.AutoSize = true;
            this.Sue.Location = new System.Drawing.Point(6, 145);
            this.Sue.Name = "Sue";
            this.Sue.Size = new System.Drawing.Size(120, 24);
            this.Sue.TabIndex = 4;
            this.Sue.TabStop = true;
            this.Sue.Text = "Sue Pallon";
            this.Sue.UseVisualStyleBackColor = true;
            // 
            // Service
            // 
            this.Service.Controls.Add(this.Cut);
            this.Service.Controls.Add(this.Colour);
            this.Service.Controls.Add(this.Highlights);
            this.Service.Controls.Add(this.Extensions);
            this.Service.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Service.Location = new System.Drawing.Point(290, 21);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(230, 225);
            this.Service.TabIndex = 1;
            this.Service.TabStop = false;
            this.Service.Text = "Service";
            // 
            // Cut
            // 
            this.Cut.AutoSize = true;
            this.Cut.Location = new System.Drawing.Point(6, 25);
            this.Cut.Name = "Cut";
            this.Cut.Size = new System.Drawing.Size(63, 24);
            this.Cut.TabIndex = 2;
            this.Cut.Text = "Cut";
            this.Cut.UseVisualStyleBackColor = true;
            // 
            // Colour
            // 
            this.Colour.AutoSize = true;
            this.Colour.Location = new System.Drawing.Point(6, 64);
            this.Colour.Name = "Colour";
            this.Colour.Size = new System.Drawing.Size(87, 24);
            this.Colour.TabIndex = 3;
            this.Colour.Text = "Colour";
            this.Colour.UseVisualStyleBackColor = true;
            // 
            // Highlights
            // 
            this.Highlights.AutoSize = true;
            this.Highlights.Location = new System.Drawing.Point(6, 104);
            this.Highlights.Name = "Highlights";
            this.Highlights.Size = new System.Drawing.Size(115, 24);
            this.Highlights.TabIndex = 4;
            this.Highlights.Text = "Highlights";
            this.Highlights.UseVisualStyleBackColor = true;
            // 
            // Extensions
            // 
            this.Extensions.AutoSize = true;
            this.Extensions.Location = new System.Drawing.Point(6, 146);
            this.Extensions.Name = "Extensions";
            this.Extensions.Size = new System.Drawing.Size(123, 24);
            this.Extensions.TabIndex = 5;
            this.Extensions.Text = "Extensions";
            this.Extensions.UseVisualStyleBackColor = true;
            // 
            // ClientType
            // 
            this.ClientType.Controls.Add(this.Senior);
            this.ClientType.Controls.Add(this.Student);
            this.ClientType.Controls.Add(this.Child);
            this.ClientType.Controls.Add(this.StandardAdult);
            this.ClientType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.ClientType.Location = new System.Drawing.Point(34, 272);
            this.ClientType.Name = "ClientType";
            this.ClientType.Size = new System.Drawing.Size(219, 192);
            this.ClientType.TabIndex = 3;
            this.ClientType.TabStop = false;
            this.ClientType.Text = "Client Type";
            // 
            // Senior
            // 
            this.Senior.AutoSize = true;
            this.Senior.Location = new System.Drawing.Point(6, 144);
            this.Senior.Name = "Senior";
            this.Senior.Size = new System.Drawing.Size(157, 24);
            this.Senior.TabIndex = 4;
            this.Senior.TabStop = true;
            this.Senior.Text = "Senior(over 65)";
            this.Senior.UseVisualStyleBackColor = true;
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Location = new System.Drawing.Point(6, 105);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(98, 24);
            this.Student.TabIndex = 5;
            this.Student.TabStop = true;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = true;
            // 
            // Child
            // 
            this.Child.AutoSize = true;
            this.Child.Location = new System.Drawing.Point(6, 64);
            this.Child.Name = "Child";
            this.Child.Size = new System.Drawing.Size(197, 24);
            this.Child.TabIndex = 6;
            this.Child.TabStop = true;
            this.Child.Text = "Child (12 and under)";
            this.Child.UseVisualStyleBackColor = true;
            // 
            // StandardAdult
            // 
            this.StandardAdult.AutoSize = true;
            this.StandardAdult.Location = new System.Drawing.Point(6, 25);
            this.StandardAdult.Name = "StandardAdult";
            this.StandardAdult.Size = new System.Drawing.Size(155, 24);
            this.StandardAdult.TabIndex = 7;
            this.StandardAdult.TabStop = true;
            this.StandardAdult.Text = "Standard Adult";
            this.StandardAdult.UseVisualStyleBackColor = true;
            // 
            // ClientVisit
            // 
            this.ClientVisit.Controls.Add(this.NumberOfVisits);
            this.ClientVisit.Controls.Add(this.NumberOfClientVisit);
            this.ClientVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.ClientVisit.Location = new System.Drawing.Point(290, 272);
            this.ClientVisit.Name = "ClientVisit";
            this.ClientVisit.Size = new System.Drawing.Size(230, 192);
            this.ClientVisit.TabIndex = 4;
            this.ClientVisit.TabStop = false;
            this.ClientVisit.Text = "Client Visits";
            // 
            // NumberOfVisits
            // 
            this.NumberOfVisits.Location = new System.Drawing.Point(6, 79);
            this.NumberOfVisits.Name = "NumberOfVisits";
            this.NumberOfVisits.Size = new System.Drawing.Size(200, 26);
            this.NumberOfVisits.TabIndex = 6;
            // 
            // NumberOfClientVisit
            // 
            this.NumberOfClientVisit.AutoSize = true;
            this.NumberOfClientVisit.Location = new System.Drawing.Point(6, 38);
            this.NumberOfClientVisit.Name = "NumberOfClientVisit";
            this.NumberOfClientVisit.Size = new System.Drawing.Size(200, 20);
            this.NumberOfClientVisit.TabIndex = 5;
            this.NumberOfClientVisit.Text = "Number Of Client Visits:";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.totalPrice.Location = new System.Drawing.Point(154, 492);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(99, 20);
            this.totalPrice.TabIndex = 5;
            this.totalPrice.Text = "Total Price:";
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Exit.Location = new System.Drawing.Point(412, 539);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(108, 43);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Clear.Location = new System.Drawing.Point(221, 539);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(115, 43);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Calculate
            // 
            this.Calculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Calculate.Location = new System.Drawing.Point(34, 539);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(104, 43);
            this.Calculate.TabIndex = 8;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 608);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.ClientVisit);
            this.Controls.Add(this.ClientType);
            this.Controls.Add(this.Service);
            this.Controls.Add(this.Hairdresser);
            this.Name = "Form1";
            this.Text = "Perfect Cut Hair Salon";
            this.Hairdresser.ResumeLayout(false);
            this.Hairdresser.PerformLayout();
            this.Service.ResumeLayout(false);
            this.Service.PerformLayout();
            this.ClientType.ResumeLayout(false);
            this.ClientType.PerformLayout();
            this.ClientVisit.ResumeLayout(false);
            this.ClientVisit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Hairdresser;
        private System.Windows.Forms.RadioButton Jane;
        private System.Windows.Forms.RadioButton Pat;
        private System.Windows.Forms.RadioButton Ron;
        private System.Windows.Forms.RadioButton Sue;
        private System.Windows.Forms.RadioButton Laura;
        private System.Windows.Forms.GroupBox Service;
        private System.Windows.Forms.CheckBox Cut;
        private System.Windows.Forms.CheckBox Colour;
        private System.Windows.Forms.CheckBox Highlights;
        private System.Windows.Forms.CheckBox Extensions;
        private System.Windows.Forms.GroupBox ClientType;
        private System.Windows.Forms.RadioButton Student;
        private System.Windows.Forms.RadioButton Child;
        private System.Windows.Forms.RadioButton StandardAdult;
        private System.Windows.Forms.RadioButton Senior;
        private System.Windows.Forms.GroupBox ClientVisit;
        private System.Windows.Forms.Label NumberOfClientVisit;
        private System.Windows.Forms.TextBox NumberOfVisits;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Calculate;
    }
}

