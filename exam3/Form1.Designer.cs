namespace exam3
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
            this.welcomeMsg = new System.Windows.Forms.Label();
            this.patties = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toppings = new System.Windows.Forms.GroupBox();
            this.mustard = new System.Windows.Forms.CheckBox();
            this.ketchup = new System.Windows.Forms.CheckBox();
            this.onion = new System.Windows.Forms.CheckBox();
            this.tomato = new System.Windows.Forms.CheckBox();
            this.lettuce = new System.Windows.Forms.CheckBox();
            this.side = new System.Windows.Forms.GroupBox();
            this.noside = new System.Windows.Forms.RadioButton();
            this.salad = new System.Windows.Forms.RadioButton();
            this.fires = new System.Windows.Forms.RadioButton();
            this.totalButton = new System.Windows.Forms.Button();
            this.totalValue = new System.Windows.Forms.Label();
            this.patties.SuspendLayout();
            this.toppings.SuspendLayout();
            this.side.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeMsg
            // 
            this.welcomeMsg.AutoSize = true;
            this.welcomeMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.welcomeMsg.Location = new System.Drawing.Point(68, 42);
            this.welcomeMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeMsg.Name = "welcomeMsg";
            this.welcomeMsg.Size = new System.Drawing.Size(743, 37);
            this.welcomeMsg.TabIndex = 0;
            this.welcomeMsg.Text = "Welcome to Burger Master Point-of-Sale system";
            // 
            // patties
            // 
            this.patties.Controls.Add(this.listBox1);
            this.patties.Location = new System.Drawing.Point(46, 116);
            this.patties.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patties.Name = "patties";
            this.patties.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patties.Size = new System.Drawing.Size(205, 202);
            this.patties.TabIndex = 1;
            this.patties.TabStop = false;
            this.patties.Text = "Patties";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Single-Burger ($2.50)",
            "Double-Burger ($3.50)",
            "Triple-Burger ($4.00)"});
            this.listBox1.Location = new System.Drawing.Point(28, 36);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(154, 84);
            this.listBox1.TabIndex = 6;
            // 
            // toppings
            // 
            this.toppings.Controls.Add(this.mustard);
            this.toppings.Controls.Add(this.ketchup);
            this.toppings.Controls.Add(this.onion);
            this.toppings.Controls.Add(this.tomato);
            this.toppings.Controls.Add(this.lettuce);
            this.toppings.Location = new System.Drawing.Point(296, 116);
            this.toppings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toppings.Name = "toppings";
            this.toppings.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toppings.Size = new System.Drawing.Size(260, 202);
            this.toppings.TabIndex = 2;
            this.toppings.TabStop = false;
            this.toppings.Text = "Toppings ($0.25 each)";
            // 
            // mustard
            // 
            this.mustard.AutoSize = true;
            this.mustard.Location = new System.Drawing.Point(24, 148);
            this.mustard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mustard.Name = "mustard";
            this.mustard.Size = new System.Drawing.Size(93, 24);
            this.mustard.TabIndex = 4;
            this.mustard.Text = "Mustard";
            this.mustard.UseVisualStyleBackColor = true;
            // 
            // ketchup
            // 
            this.ketchup.AutoSize = true;
            this.ketchup.Location = new System.Drawing.Point(24, 120);
            this.ketchup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ketchup.Name = "ketchup";
            this.ketchup.Size = new System.Drawing.Size(94, 24);
            this.ketchup.TabIndex = 3;
            this.ketchup.Text = "Ketchup";
            this.ketchup.UseVisualStyleBackColor = true;
            // 
            // onion
            // 
            this.onion.AutoSize = true;
            this.onion.Location = new System.Drawing.Point(24, 92);
            this.onion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.onion.Name = "onion";
            this.onion.Size = new System.Drawing.Size(77, 24);
            this.onion.TabIndex = 2;
            this.onion.Text = "Onion";
            this.onion.UseVisualStyleBackColor = true;
            // 
            // tomato
            // 
            this.tomato.AutoSize = true;
            this.tomato.Location = new System.Drawing.Point(24, 64);
            this.tomato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tomato.Name = "tomato";
            this.tomato.Size = new System.Drawing.Size(89, 24);
            this.tomato.TabIndex = 1;
            this.tomato.Text = "Tomato";
            this.tomato.UseVisualStyleBackColor = true;
            // 
            // lettuce
            // 
            this.lettuce.AutoSize = true;
            this.lettuce.Location = new System.Drawing.Point(24, 36);
            this.lettuce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lettuce.Name = "lettuce";
            this.lettuce.Size = new System.Drawing.Size(89, 24);
            this.lettuce.TabIndex = 0;
            this.lettuce.Text = "Lettuce";
            this.lettuce.UseVisualStyleBackColor = true;
            // 
            // side
            // 
            this.side.Controls.Add(this.noside);
            this.side.Controls.Add(this.salad);
            this.side.Controls.Add(this.fires);
            this.side.Location = new System.Drawing.Point(590, 116);
            this.side.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.side.Name = "side";
            this.side.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.side.Size = new System.Drawing.Size(208, 202);
            this.side.TabIndex = 3;
            this.side.TabStop = false;
            this.side.Text = "Side";
            // 
            // noside
            // 
            this.noside.AutoSize = true;
            this.noside.Location = new System.Drawing.Point(18, 92);
            this.noside.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noside.Name = "noside";
            this.noside.Size = new System.Drawing.Size(144, 24);
            this.noside.TabIndex = 2;
            this.noside.TabStop = true;
            this.noside.Text = "No Side ($0.00)";
            this.noside.UseVisualStyleBackColor = true;
            // 
            // salad
            // 
            this.salad.AutoSize = true;
            this.salad.Location = new System.Drawing.Point(18, 63);
            this.salad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salad.Name = "salad";
            this.salad.Size = new System.Drawing.Size(129, 24);
            this.salad.TabIndex = 1;
            this.salad.TabStop = true;
            this.salad.Text = "Salad ($5.25)";
            this.salad.UseVisualStyleBackColor = true;
            // 
            // fires
            // 
            this.fires.AutoSize = true;
            this.fires.Location = new System.Drawing.Point(18, 36);
            this.fires.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fires.Name = "fires";
            this.fires.Size = new System.Drawing.Size(123, 24);
            this.fires.TabIndex = 0;
            this.fires.TabStop = true;
            this.fires.Text = "Fries ($3.25)";
            this.fires.UseVisualStyleBackColor = true;
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(46, 349);
            this.totalButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(144, 60);
            this.totalButton.TabIndex = 4;
            this.totalButton.Text = "Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // totalValue
            // 
            this.totalValue.AutoSize = true;
            this.totalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.totalValue.Location = new System.Drawing.Point(214, 360);
            this.totalValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalValue.Name = "totalValue";
            this.totalValue.Size = new System.Drawing.Size(103, 37);
            this.totalValue.TabIndex = 5;
            this.totalValue.Text = "$0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 422);
            this.Controls.Add(this.totalValue);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.side);
            this.Controls.Add(this.toppings);
            this.Controls.Add(this.patties);
            this.Controls.Add(this.welcomeMsg);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.patties.ResumeLayout(false);
            this.toppings.ResumeLayout(false);
            this.toppings.PerformLayout();
            this.side.ResumeLayout(false);
            this.side.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeMsg;
        private System.Windows.Forms.GroupBox patties;
        private System.Windows.Forms.GroupBox toppings;
        private System.Windows.Forms.GroupBox side;
        private System.Windows.Forms.CheckBox mustard;
        private System.Windows.Forms.CheckBox ketchup;
        private System.Windows.Forms.CheckBox onion;
        private System.Windows.Forms.CheckBox tomato;
        private System.Windows.Forms.CheckBox lettuce;
        private System.Windows.Forms.RadioButton noside;
        private System.Windows.Forms.RadioButton salad;
        private System.Windows.Forms.RadioButton fires;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label totalValue;
        private System.Windows.Forms.ListBox listBox1;
    }
}