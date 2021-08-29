namespace Node
{
    partial class Core
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Core));
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DatabaseButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShutdownButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SettingsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.HomeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.CoreBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.NavBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.superMinimize = new System.Windows.Forms.Button();
            this.DashboardPanel.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.BackColor = System.Drawing.Color.Yellow;
            this.DashboardPanel.Controls.Add(this.bunifuGradientPanel1);
            this.DashboardPanel.Location = new System.Drawing.Point(12, 12);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(217, 868);
            this.DashboardPanel.TabIndex = 0;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.BlueViolet;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.DatabaseButton);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Controls.Add(this.ShutdownButton);
            this.bunifuGradientPanel1.Controls.Add(this.SettingsButton);
            this.bunifuGradientPanel1.Controls.Add(this.HomeButton);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DarkViolet;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DarkViolet;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(217, 868);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // DatabaseButton
            // 
            this.DatabaseButton.Activecolor = System.Drawing.Color.DeepPink;
            this.DatabaseButton.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.DatabaseButton.BackColor = System.Drawing.Color.Transparent;
            this.DatabaseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DatabaseButton.BorderRadius = 0;
            this.DatabaseButton.ButtonText = "Information";
            this.DatabaseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DatabaseButton.DisabledColor = System.Drawing.Color.Gray;
            this.DatabaseButton.Iconcolor = System.Drawing.Color.Transparent;
            this.DatabaseButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("DatabaseButton.Iconimage")));
            this.DatabaseButton.Iconimage_right = null;
            this.DatabaseButton.Iconimage_right_Selected = null;
            this.DatabaseButton.Iconimage_Selected = null;
            this.DatabaseButton.IconMarginLeft = 0;
            this.DatabaseButton.IconMarginRight = 0;
            this.DatabaseButton.IconRightVisible = true;
            this.DatabaseButton.IconRightZoom = 0D;
            this.DatabaseButton.IconVisible = true;
            this.DatabaseButton.IconZoom = 90D;
            this.DatabaseButton.IsTab = false;
            this.DatabaseButton.Location = new System.Drawing.Point(7, 392);
            this.DatabaseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DatabaseButton.Name = "DatabaseButton";
            this.DatabaseButton.Normalcolor = System.Drawing.Color.Transparent;
            this.DatabaseButton.OnHovercolor = System.Drawing.Color.DeepPink;
            this.DatabaseButton.OnHoverTextColor = System.Drawing.Color.White;
            this.DatabaseButton.selected = false;
            this.DatabaseButton.Size = new System.Drawing.Size(203, 50);
            this.DatabaseButton.TabIndex = 7;
            this.DatabaseButton.Text = "Information";
            this.DatabaseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DatabaseButton.Textcolor = System.Drawing.Color.White;
            this.DatabaseButton.TextFont = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseButton.Click += new System.EventHandler(this.DatabaseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Location = new System.Drawing.Point(15, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 2);
            this.panel1.TabIndex = 5;
            // 
            // ShutdownButton
            // 
            this.ShutdownButton.Activecolor = System.Drawing.Color.DeepPink;
            this.ShutdownButton.BackColor = System.Drawing.Color.Transparent;
            this.ShutdownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShutdownButton.BorderRadius = 0;
            this.ShutdownButton.ButtonText = "Stop Server";
            this.ShutdownButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShutdownButton.DisabledColor = System.Drawing.Color.Gray;
            this.ShutdownButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ShutdownButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("ShutdownButton.Iconimage")));
            this.ShutdownButton.Iconimage_right = null;
            this.ShutdownButton.Iconimage_right_Selected = null;
            this.ShutdownButton.Iconimage_Selected = null;
            this.ShutdownButton.IconMarginLeft = 0;
            this.ShutdownButton.IconMarginRight = 0;
            this.ShutdownButton.IconRightVisible = true;
            this.ShutdownButton.IconRightZoom = 0D;
            this.ShutdownButton.IconVisible = true;
            this.ShutdownButton.IconZoom = 90D;
            this.ShutdownButton.IsTab = false;
            this.ShutdownButton.Location = new System.Drawing.Point(7, 773);
            this.ShutdownButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShutdownButton.Name = "ShutdownButton";
            this.ShutdownButton.Normalcolor = System.Drawing.Color.Transparent;
            this.ShutdownButton.OnHovercolor = System.Drawing.Color.DeepPink;
            this.ShutdownButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ShutdownButton.selected = false;
            this.ShutdownButton.Size = new System.Drawing.Size(203, 50);
            this.ShutdownButton.TabIndex = 4;
            this.ShutdownButton.Text = "Stop Server";
            this.ShutdownButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShutdownButton.Textcolor = System.Drawing.Color.White;
            this.ShutdownButton.TextFont = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShutdownButton.Click += new System.EventHandler(this.ShutdownButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Activecolor = System.Drawing.Color.DeepPink;
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsButton.BorderRadius = 0;
            this.SettingsButton.ButtonText = "Settings";
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.DisabledColor = System.Drawing.Color.Gray;
            this.SettingsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SettingsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Iconimage")));
            this.SettingsButton.Iconimage_right = null;
            this.SettingsButton.Iconimage_right_Selected = null;
            this.SettingsButton.Iconimage_Selected = null;
            this.SettingsButton.IconMarginLeft = 0;
            this.SettingsButton.IconMarginRight = 0;
            this.SettingsButton.IconRightVisible = true;
            this.SettingsButton.IconRightZoom = 0D;
            this.SettingsButton.IconVisible = true;
            this.SettingsButton.IconZoom = 90D;
            this.SettingsButton.IsTab = false;
            this.SettingsButton.Location = new System.Drawing.Point(7, 159);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Normalcolor = System.Drawing.Color.Transparent;
            this.SettingsButton.OnHovercolor = System.Drawing.Color.DeepPink;
            this.SettingsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SettingsButton.selected = false;
            this.SettingsButton.Size = new System.Drawing.Size(203, 50);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Textcolor = System.Drawing.Color.White;
            this.SettingsButton.TextFont = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // HomeButton
            // 
            this.HomeButton.Activecolor = System.Drawing.Color.DeepPink;
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeButton.BorderRadius = 0;
            this.HomeButton.ButtonText = "Home";
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.DisabledColor = System.Drawing.Color.Gray;
            this.HomeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.HomeButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("HomeButton.Iconimage")));
            this.HomeButton.Iconimage_right = null;
            this.HomeButton.Iconimage_right_Selected = null;
            this.HomeButton.Iconimage_Selected = null;
            this.HomeButton.IconMarginLeft = 0;
            this.HomeButton.IconMarginRight = 0;
            this.HomeButton.IconRightVisible = true;
            this.HomeButton.IconRightZoom = 0D;
            this.HomeButton.IconVisible = true;
            this.HomeButton.IconZoom = 90D;
            this.HomeButton.IsTab = false;
            this.HomeButton.Location = new System.Drawing.Point(7, 101);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Normalcolor = System.Drawing.Color.Transparent;
            this.HomeButton.OnHovercolor = System.Drawing.Color.DeepPink;
            this.HomeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.HomeButton.selected = false;
            this.HomeButton.Size = new System.Drawing.Size(203, 50);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Textcolor = System.Drawing.Color.White;
            this.HomeButton.TextFont = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.Click += new System.EventHandler(this.Home_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1400, 5);
            this.TopPanel.TabIndex = 1;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 5);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(5, 887);
            this.LeftPanel.TabIndex = 2;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(5, 887);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1395, 5);
            this.BottomPanel.TabIndex = 3;
            // 
            // CoreBorder
            // 
            this.CoreBorder.ElipseRadius = 8;
            this.CoreBorder.TargetControl = this;
            // 
            // NavBorder
            // 
            this.NavBorder.ElipseRadius = 5;
            this.NavBorder.TargetControl = this.DashboardPanel;
            // 
            // ControlPanel
            // 
            this.ControlPanel.Location = new System.Drawing.Point(235, 55);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(1150, 825);
            this.ControlPanel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Marlett", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1358, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "r";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // superMinimize
            // 
            this.superMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.superMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.superMinimize.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superMinimize.ForeColor = System.Drawing.Color.OrangeRed;
            this.superMinimize.Location = new System.Drawing.Point(1203, 5);
            this.superMinimize.Name = "superMinimize";
            this.superMinimize.Size = new System.Drawing.Size(149, 33);
            this.superMinimize.TabIndex = 0;
            this.superMinimize.Text = "Super Minimize";
            this.superMinimize.UseVisualStyleBackColor = true;
            this.superMinimize.Click += new System.EventHandler(this.superMinimize_Click);
            // 
            // Core
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1400, 892);
            this.Controls.Add(this.superMinimize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.DashboardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Core";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Plus";
            this.Load += new System.EventHandler(this.Core_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            this.DashboardPanel.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DashboardPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private Bunifu.Framework.UI.BunifuElipse CoreBorder;
        private Bunifu.Framework.UI.BunifuElipse NavBorder;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton HomeButton;
        private Bunifu.Framework.UI.BunifuFlatButton SettingsButton;
        private Bunifu.Framework.UI.BunifuFlatButton ShutdownButton;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton DatabaseButton;
        private System.Windows.Forms.Button superMinimize;
    }
}

