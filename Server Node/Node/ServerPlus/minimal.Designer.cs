
namespace Node
{
    partial class minimal
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
            this.Header = new System.Windows.Forms.Panel();
            this.Maximize = new System.Windows.Forms.Button();
            this.DataProcessed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TotalBlocksTag = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Black;
            this.Header.Controls.Add(this.Maximize);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(322, 45);
            this.Header.TabIndex = 0;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            // 
            // Maximize
            // 
            this.Maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Maximize.FlatAppearance.BorderSize = 0;
            this.Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximize.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maximize.ForeColor = System.Drawing.Color.White;
            this.Maximize.Location = new System.Drawing.Point(274, 0);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(48, 45);
            this.Maximize.TabIndex = 1;
            this.Maximize.Text = "🗖";
            this.Maximize.UseVisualStyleBackColor = true;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // DataProcessed
            // 
            this.DataProcessed.AutoSize = true;
            this.DataProcessed.Font = new System.Drawing.Font("Roboto Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataProcessed.ForeColor = System.Drawing.Color.ForestGreen;
            this.DataProcessed.Location = new System.Drawing.Point(194, 58);
            this.DataProcessed.Name = "DataProcessed";
            this.DataProcessed.Size = new System.Drawing.Size(128, 96);
            this.DataProcessed.TabIndex = 8;
            this.DataProcessed.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(23, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 37);
            this.label6.TabIndex = 9;
            this.label6.Text = "RUNNING";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TotalBlocksTag
            // 
            this.TotalBlocksTag.AutoSize = true;
            this.TotalBlocksTag.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBlocksTag.ForeColor = System.Drawing.Color.Cyan;
            this.TotalBlocksTag.Location = new System.Drawing.Point(111, 110);
            this.TotalBlocksTag.Name = "TotalBlocksTag";
            this.TotalBlocksTag.Size = new System.Drawing.Size(60, 44);
            this.TotalBlocksTag.TabIndex = 19;
            this.TotalBlocksTag.Text = "----";
            this.TotalBlocksTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(322, 174);
            this.Controls.Add(this.TotalBlocksTag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DataProcessed);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "minimal";
            this.Text = "minimal";
            this.Load += new System.EventHandler(this.minimal_Load);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button Maximize;
        private System.Windows.Forms.Label DataProcessed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TotalBlocksTag;
    }
}