namespace Node
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NetworkInterface = new System.Windows.Forms.Timer(this.components);
            this._NoNodes = new System.Windows.Forms.Label();
            this.AutoTag = new System.Windows.Forms.Label();
            this.MemoryProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CPUProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DASHBOARD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(237, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(683, 507);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(447, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "SERVER:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LawnGreen;
            this.label6.Location = new System.Drawing.Point(578, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "RUNNING";
            // 
            // NetworkInterface
            // 
            this.NetworkInterface.Interval = 1000;
            this.NetworkInterface.Tick += new System.EventHandler(this.NetworkInterface_Tick);
            // 
            // _NoNodes
            // 
            this._NoNodes.AutoSize = true;
            this._NoNodes.Font = new System.Drawing.Font("Roboto Light", 36F);
            this._NoNodes.ForeColor = System.Drawing.Color.Orchid;
            this._NoNodes.Location = new System.Drawing.Point(417, 643);
            this._NoNodes.Name = "_NoNodes";
            this._NoNodes.Size = new System.Drawing.Size(96, 72);
            this._NoNodes.TabIndex = 23;
            this._NoNodes.Text = "00";
            // 
            // AutoTag
            // 
            this.AutoTag.AutoSize = true;
            this.AutoTag.Font = new System.Drawing.Font("Roboto Light", 20F);
            this.AutoTag.ForeColor = System.Drawing.Color.Orange;
            this.AutoTag.Location = new System.Drawing.Point(198, 659);
            this.AutoTag.Name = "AutoTag";
            this.AutoTag.Size = new System.Drawing.Size(65, 41);
            this.AutoTag.TabIndex = 24;
            this.AutoTag.Text = "NO";
            // 
            // MemoryProgress
            // 
            this.MemoryProgress.animated = false;
            this.MemoryProgress.animationIterval = 5;
            this.MemoryProgress.animationSpeed = 300;
            this.MemoryProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.MemoryProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MemoryProgress.BackgroundImage")));
            this.MemoryProgress.Font = new System.Drawing.Font("Roboto Light", 13.8F);
            this.MemoryProgress.ForeColor = System.Drawing.Color.DeepPink;
            this.MemoryProgress.LabelVisible = true;
            this.MemoryProgress.LineProgressThickness = 10;
            this.MemoryProgress.LineThickness = 1;
            this.MemoryProgress.Location = new System.Drawing.Point(903, 618);
            this.MemoryProgress.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MemoryProgress.MaxValue = 100;
            this.MemoryProgress.Name = "MemoryProgress";
            this.MemoryProgress.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MemoryProgress.ProgressColor = System.Drawing.Color.DeepPink;
            this.MemoryProgress.Size = new System.Drawing.Size(115, 115);
            this.MemoryProgress.TabIndex = 27;
            this.MemoryProgress.Value = 100;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(802, 618);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 116);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // CPUProgress
            // 
            this.CPUProgress.animated = false;
            this.CPUProgress.animationIterval = 5;
            this.CPUProgress.animationSpeed = 300;
            this.CPUProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.CPUProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CPUProgress.BackgroundImage")));
            this.CPUProgress.Font = new System.Drawing.Font("Roboto Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUProgress.ForeColor = System.Drawing.Color.Yellow;
            this.CPUProgress.LabelVisible = true;
            this.CPUProgress.LineProgressThickness = 10;
            this.CPUProgress.LineThickness = 1;
            this.CPUProgress.Location = new System.Drawing.Point(639, 617);
            this.CPUProgress.Margin = new System.Windows.Forms.Padding(10);
            this.CPUProgress.MaxValue = 100;
            this.CPUProgress.Name = "CPUProgress";
            this.CPUProgress.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CPUProgress.ProgressColor = System.Drawing.Color.Yellow;
            this.CPUProgress.Size = new System.Drawing.Size(115, 115);
            this.CPUProgress.TabIndex = 26;
            this.CPUProgress.Value = 100;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(543, 617);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(97, 618);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(109, 116);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(317, 618);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(109, 116);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(543, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 44);
            this.button1.TabIndex = 31;
            this.button1.Text = "Sync";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1150, 800);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AutoTag);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.MemoryProgress);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.CPUProgress);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this._NoNodes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer NetworkInterface;
        private System.Windows.Forms.Label _NoNodes;
        private System.Windows.Forms.Label AutoTag;
        private Bunifu.Framework.UI.BunifuCircleProgressbar MemoryProgress;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuCircleProgressbar CPUProgress;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button1;
    }
}