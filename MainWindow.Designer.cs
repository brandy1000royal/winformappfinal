namespace ZuberSample
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDriversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.addToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1017, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDriversToolStripMenuItem,
            this.viewAdministratorToolStripMenuItem,
            this.viewCustomersToolStripMenuItem});
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewDriversToolStripMenuItem
            // 
            this.viewDriversToolStripMenuItem.Name = "viewDriversToolStripMenuItem";
            this.viewDriversToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.viewDriversToolStripMenuItem.Text = "View Drivers";
            this.viewDriversToolStripMenuItem.Click += new System.EventHandler(this.viewDriversToolStripMenuItem_Click);
            // 
            // viewAdministratorToolStripMenuItem
            // 
            this.viewAdministratorToolStripMenuItem.Name = "viewAdministratorToolStripMenuItem";
            this.viewAdministratorToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.viewAdministratorToolStripMenuItem.Text = "View Administrator";
            this.viewAdministratorToolStripMenuItem.Click += new System.EventHandler(this.viewAdministratorToolStripMenuItem_Click);
            // 
            // viewCustomersToolStripMenuItem
            // 
            this.viewCustomersToolStripMenuItem.Name = "viewCustomersToolStripMenuItem";
            this.viewCustomersToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.viewCustomersToolStripMenuItem.Text = "View Customers";
            this.viewCustomersToolStripMenuItem.Click += new System.EventHandler(this.viewCustomersToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDriverToolStripMenuItem,
            this.addNewAdministratorToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addNewDriverToolStripMenuItem
            // 
            this.addNewDriverToolStripMenuItem.Name = "addNewDriverToolStripMenuItem";
            this.addNewDriverToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addNewDriverToolStripMenuItem.Text = "Add New Driver";
            this.addNewDriverToolStripMenuItem.Click += new System.EventHandler(this.addNewDriverToolStripMenuItem_Click);
            // 
            // addNewAdministratorToolStripMenuItem
            // 
            this.addNewAdministratorToolStripMenuItem.Name = "addNewAdministratorToolStripMenuItem";
            this.addNewAdministratorToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addNewAdministratorToolStripMenuItem.Text = "Add New Administrator";
            this.addNewAdministratorToolStripMenuItem.Click += new System.EventHandler(this.addNewAdministratorToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 587);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1017, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::ZuberSample.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(1017, 609);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDriversToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem viewAdministratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAdministratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}