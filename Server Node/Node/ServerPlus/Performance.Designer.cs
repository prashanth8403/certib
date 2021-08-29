namespace Node
{
    partial class Performance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Performance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CPUProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.DataProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.MemoryProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.BandProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RequestGraph = new Bunifu.DataViz.WinForms.BunifuDataViz();
            this.Processes = new System.Windows.Forms.Timer(this.components);
            this.Graph = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(33, 637);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 2);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 663);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(306, 663);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // CPUProgress
            // 
            this.CPUProgress.animated = false;
            this.CPUProgress.animationIterval = 5;
            this.CPUProgress.animationSpeed = 300;
            this.CPUProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CPUProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CPUProgress.BackgroundImage")));
            this.CPUProgress.Font = new System.Drawing.Font("Roboto Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUProgress.ForeColor = System.Drawing.Color.Yellow;
            this.CPUProgress.LabelVisible = true;
            this.CPUProgress.LineProgressThickness = 10;
            this.CPUProgress.LineThickness = 1;
            this.CPUProgress.Location = new System.Drawing.Point(163, 663);
            this.CPUProgress.Margin = new System.Windows.Forms.Padding(10);
            this.CPUProgress.MaxValue = 100;
            this.CPUProgress.Name = "CPUProgress";
            this.CPUProgress.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CPUProgress.ProgressColor = System.Drawing.Color.Yellow;
            this.CPUProgress.Size = new System.Drawing.Size(115, 115);
            this.CPUProgress.TabIndex = 4;
            this.CPUProgress.Value = 100;
            // 
            // DataProgress
            // 
            this.DataProgress.animated = false;
            this.DataProgress.animationIterval = 5;
            this.DataProgress.animationSpeed = 300;
            this.DataProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DataProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DataProgress.BackgroundImage")));
            this.DataProgress.Font = new System.Drawing.Font("Roboto Light", 13.8F);
            this.DataProgress.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.DataProgress.LabelVisible = true;
            this.DataProgress.LineProgressThickness = 10;
            this.DataProgress.LineThickness = 1;
            this.DataProgress.Location = new System.Drawing.Point(404, 663);
            this.DataProgress.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DataProgress.MaxValue = 100;
            this.DataProgress.Name = "DataProgress";
            this.DataProgress.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DataProgress.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.DataProgress.Size = new System.Drawing.Size(115, 115);
            this.DataProgress.TabIndex = 5;
            this.DataProgress.Value = 100;
            // 
            // MemoryProgress
            // 
            this.MemoryProgress.animated = false;
            this.MemoryProgress.animationIterval = 5;
            this.MemoryProgress.animationSpeed = 300;
            this.MemoryProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MemoryProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MemoryProgress.BackgroundImage")));
            this.MemoryProgress.Font = new System.Drawing.Font("Roboto Light", 13.8F);
            this.MemoryProgress.ForeColor = System.Drawing.Color.DeepPink;
            this.MemoryProgress.LabelVisible = true;
            this.MemoryProgress.LineProgressThickness = 10;
            this.MemoryProgress.LineThickness = 1;
            this.MemoryProgress.Location = new System.Drawing.Point(656, 663);
            this.MemoryProgress.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MemoryProgress.MaxValue = 100;
            this.MemoryProgress.Name = "MemoryProgress";
            this.MemoryProgress.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MemoryProgress.ProgressColor = System.Drawing.Color.DeepPink;
            this.MemoryProgress.Size = new System.Drawing.Size(115, 115);
            this.MemoryProgress.TabIndex = 6;
            this.MemoryProgress.Value = 100;
            // 
            // BandProgress
            // 
            this.BandProgress.animated = false;
            this.BandProgress.animationIterval = 5;
            this.BandProgress.animationSpeed = 300;
            this.BandProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BandProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BandProgress.BackgroundImage")));
            this.BandProgress.Font = new System.Drawing.Font("Roboto Light", 13.8F);
            this.BandProgress.ForeColor = System.Drawing.Color.Chartreuse;
            this.BandProgress.LabelVisible = true;
            this.BandProgress.LineProgressThickness = 10;
            this.BandProgress.LineThickness = 1;
            this.BandProgress.Location = new System.Drawing.Point(922, 663);
            this.BandProgress.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.BandProgress.MaxValue = 100;
            this.BandProgress.Name = "BandProgress";
            this.BandProgress.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BandProgress.ProgressColor = System.Drawing.Color.Lime;
            this.BandProgress.Size = new System.Drawing.Size(115, 115);
            this.BandProgress.TabIndex = 8;
            this.BandProgress.Value = 100;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(827, 663);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(109, 116);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(555, 663);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 116);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RequestGraph);
            this.panel2.Location = new System.Drawing.Point(47, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 451);
            this.panel2.TabIndex = 11;
            // 
            // RequestGraph
            // 
            this.RequestGraph.animationEnabled = false;
            this.RequestGraph.AxisLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.RequestGraph.AxisXFontColor = System.Drawing.SystemColors.WindowFrame;
            this.RequestGraph.AxisXGridColor = System.Drawing.SystemColors.WindowFrame;
            this.RequestGraph.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RequestGraph.AxisYFontColor = System.Drawing.Color.Gray;
            this.RequestGraph.AxisYGridColor = System.Drawing.Color.Gray;
            this.RequestGraph.AxisYGridThickness = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.RequestGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RequestGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RequestGraph.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestGraph.Location = new System.Drawing.Point(0, 0);
            this.RequestGraph.Margin = new System.Windows.Forms.Padding(6);
            this.RequestGraph.Name = "RequestGraph";
            this.RequestGraph.Size = new System.Drawing.Size(1074, 451);
            this.RequestGraph.TabIndex = 0;
            this.RequestGraph.Theme = Bunifu.DataViz.WinForms.BunifuDataViz._theme.theme1;
            this.RequestGraph.Title = "";
            // 
            // Processes
            // 
            this.Processes.Interval = 500;
            this.Processes.Tick += new System.EventHandler(this.Process_Tick);
            // 
            // Graph
            // 
            this.Graph.Interval = 3000;
            this.Graph.Tick += new System.EventHandler(this.Graph_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "PERFORMANCE";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Location = new System.Drawing.Point(886, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 15);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Purple;
            this.panel4.Location = new System.Drawing.Point(886, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 15);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkOrange;
            this.panel5.Location = new System.Drawing.Point(729, 118);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 15);
            this.panel5.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(123)))), ((int)(((byte)(202)))));
            this.panel6.Location = new System.Drawing.Point(729, 90);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 15);
            this.panel6.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(907, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mail Requests";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(907, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Meridi Requests";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(750, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Juno Requests";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(750, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Minevra Requests";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(534, 612);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Time→";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(21, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 170);
            this.label7.TabIndex = 21;
            this.label7.Text = "↑\r\n\r\nR\r\ne\r\nq\r\nu\r\ne\r\ns\r\nt\r\ns\r\n";
            // 
            // Performance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1150, 800);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MemoryProgress);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BandProgress);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.DataProgress);
            this.Controls.Add(this.CPUProgress);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Performance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performance";
            this.Load += new System.EventHandler(this.Performance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar CPUProgress;
        private Bunifu.Framework.UI.BunifuCircleProgressbar DataProgress;
        private Bunifu.Framework.UI.BunifuCircleProgressbar MemoryProgress;
        private Bunifu.Framework.UI.BunifuCircleProgressbar BandProgress;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer Processes;
        private System.Windows.Forms.Timer Graph;
        private Bunifu.DataViz.WinForms.BunifuDataViz RequestGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}