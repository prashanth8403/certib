namespace Node
{
    partial class Calculation
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
            this.StartButton = new System.Windows.Forms.Button();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.AutoTag = new System.Windows.Forms.Label();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.StartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Crimson;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(431, 316);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(163, 56);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ResultText
            // 
            this.ResultText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultText.Location = new System.Drawing.Point(101, 203);
            this.ResultText.Multiline = true;
            this.ResultText.Name = "ResultText";
            this.ResultText.ReadOnly = true;
            this.ResultText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultText.Size = new System.Drawing.Size(929, 567);
            this.ResultText.TabIndex = 1;
            // 
            // AutoTag
            // 
            this.AutoTag.AutoSize = true;
            this.AutoTag.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.AutoTag.ForeColor = System.Drawing.Color.Orange;
            this.AutoTag.Location = new System.Drawing.Point(96, 145);
            this.AutoTag.Name = "AutoTag";
            this.AutoTag.Size = new System.Drawing.Size(199, 29);
            this.AutoTag.TabIndex = 25;
            this.AutoTag.Text = "Computing Result";
            // 
            // StartPanel
            // 
            this.StartPanel.Controls.Add(this.StartButton);
            this.StartPanel.Location = new System.Drawing.Point(53, 126);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(1034, 670);
            this.StartPanel.TabIndex = 26;
            // 
            // Calculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1150, 825);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.AutoTag);
            this.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculation";
            this.Text = "Calculation";
            this.Load += new System.EventHandler(this.Calculation_Load);
            this.StartPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.Label AutoTag;
        private System.Windows.Forms.Panel StartPanel;
    }
}