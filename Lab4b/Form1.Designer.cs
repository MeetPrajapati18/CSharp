namespace Lab4b
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuSectionForItems;
        private System.Windows.Forms.ToolStripMenuItem fileUploadToolMenu;
        private System.Windows.Forms.ToolStripMenuItem processFileContentUpload;
        private System.Windows.Forms.ToolStripMenuItem loadFileContentItem;
        private System.Windows.Forms.ToolStripMenuItem checkTagsItemsMenu;
        private System.Windows.Forms.TextBox filePathTextBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuSectionForItems = new System.Windows.Forms.MenuStrip();
            this.fileUploadToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileContentItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processFileContentUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.checkTagsItemsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileLoadedLabel = new System.Windows.Forms.Label();
            this.menuSectionForItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSectionForItems
            // 
            this.menuSectionForItems.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuSectionForItems.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuSectionForItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileUploadToolMenu,
            this.processFileContentUpload});
            this.menuSectionForItems.Location = new System.Drawing.Point(0, 0);
            this.menuSectionForItems.Name = "menuSectionForItems";
            this.menuSectionForItems.Size = new System.Drawing.Size(800, 36);
            this.menuSectionForItems.TabIndex = 0;
            this.menuSectionForItems.Text = "menuStrip1";
            // 
            // fileUploadToolMenu
            // 
            this.fileUploadToolMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileContentItem,
            this.exitToolStripMenuItem});
            this.fileUploadToolMenu.Name = "fileUploadToolMenu";
            this.fileUploadToolMenu.Size = new System.Drawing.Size(54, 29);
            this.fileUploadToolMenu.Text = "File";
            // 
            // loadFileContentItem
            // 
            this.loadFileContentItem.Name = "loadFileContentItem";
            this.loadFileContentItem.Size = new System.Drawing.Size(270, 34);
            this.loadFileContentItem.Text = "Load";
            this.loadFileContentItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // processFileContentUpload
            // 
            this.processFileContentUpload.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkTagsItemsMenu});
            this.processFileContentUpload.Name = "processFileContentUpload";
            this.processFileContentUpload.Size = new System.Drawing.Size(88, 29);
            this.processFileContentUpload.Text = "Process";
            // 
            // checkTagsItemsMenu
            // 
            this.checkTagsItemsMenu.Name = "checkTagsItemsMenu";
            this.checkTagsItemsMenu.Size = new System.Drawing.Size(270, 34);
            this.checkTagsItemsMenu.Text = "Check Tags";
            this.checkTagsItemsMenu.Click += new System.EventHandler(this.checkTagsToolStripMenuItem_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.filePathTextBox.Location = new System.Drawing.Point(14, 78);
            this.filePathTextBox.Multiline = true;
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.filePathTextBox.Size = new System.Drawing.Size(776, 366);
            this.filePathTextBox.TabIndex = 1;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.fileLoadedLabel.AutoSize = true;
            this.fileLoadedLabel.Location = new System.Drawing.Point(12, 45);
            this.fileLoadedLabel.Name = "label1";
            this.fileLoadedLabel.Size = new System.Drawing.Size(96, 20);
            this.fileLoadedLabel.TabIndex = 2;
            this.fileLoadedLabel.Text = "Loaded File:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.fileLoadedLabel);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.menuSectionForItems);
            this.MainMenuStrip = this.menuSectionForItems;
            this.Name = "Form1";
            this.Text = "Meet\'s HTML File Checker";
            this.menuSectionForItems.ResumeLayout(false);
            this.menuSectionForItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label fileLoadedLabel;
    }
}