namespace Node
{
    partial class Infoboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataProcessed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataRequest = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this._BlockGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrevAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.GridRadius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._StatusTag = new System.Windows.Forms.Label();
            this._ChainErrorMessage = new System.Windows.Forms.Label();
            this.BlockValidator = new System.Windows.Forms.Timer(this.components);
            this.TotalBlocksTag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._BlockGrid)).BeginInit();
            this.GridPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataProcessed
            // 
            this.DataProcessed.AutoSize = true;
            this.DataProcessed.Font = new System.Drawing.Font("Roboto Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataProcessed.ForeColor = System.Drawing.Color.ForestGreen;
            this.DataProcessed.Location = new System.Drawing.Point(79, 695);
            this.DataProcessed.Name = "DataProcessed";
            this.DataProcessed.Size = new System.Drawing.Size(128, 96);
            this.DataProcessed.TabIndex = 7;
            this.DataProcessed.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(38, 657);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Processed Requests:";
            // 
            // DataRequest
            // 
            this.DataRequest.Interval = 1000;
            this.DataRequest.Tick += new System.EventHandler(this.DataRequest_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(59, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Saved Blocks:";
            // 
            // _BlockGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this._BlockGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._BlockGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._BlockGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this._BlockGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._BlockGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._BlockGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._BlockGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._BlockGrid.ColumnHeadersHeight = 60;
            this._BlockGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeStamp,
            this.PrevAddress,
            this.BlockHash});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._BlockGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this._BlockGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._BlockGrid.DoubleBuffered = true;
            this._BlockGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._BlockGrid.EnableHeadersVisualStyles = false;
            this._BlockGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this._BlockGrid.HeaderForeColor = System.Drawing.Color.White;
            this._BlockGrid.Location = new System.Drawing.Point(0, 0);
            this._BlockGrid.Name = "_BlockGrid";
            this._BlockGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._BlockGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this._BlockGrid.RowHeadersVisible = false;
            this._BlockGrid.RowHeadersWidth = 60;
            this._BlockGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this._BlockGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this._BlockGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._BlockGrid.RowTemplate.DividerHeight = 2;
            this._BlockGrid.RowTemplate.Height = 30;
            this._BlockGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._BlockGrid.Size = new System.Drawing.Size(1055, 528);
            this._BlockGrid.TabIndex = 14;
            // 
            // TimeStamp
            // 
            this.TimeStamp.HeaderText = "TimeStamp";
            this.TimeStamp.MinimumWidth = 6;
            this.TimeStamp.Name = "TimeStamp";
            // 
            // PrevAddress
            // 
            this.PrevAddress.HeaderText = "PrevAddress";
            this.PrevAddress.MinimumWidth = 6;
            this.PrevAddress.Name = "PrevAddress";
            // 
            // BlockHash
            // 
            this.BlockHash.HeaderText = "BlockHash";
            this.BlockHash.MinimumWidth = 6;
            this.BlockHash.Name = "BlockHash";
            // 
            // GridPanel
            // 
            this.GridPanel.Controls.Add(this._BlockGrid);
            this.GridPanel.Location = new System.Drawing.Point(43, 98);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(1055, 528);
            this.GridPanel.TabIndex = 15;
            // 
            // GridRadius
            // 
            this.GridRadius.ElipseRadius = 0;
            this.GridRadius.TargetControl = this.GridPanel;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(904, 657);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Blockchain Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(508, 657);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Blocks:";
            // 
            // _StatusTag
            // 
            this._StatusTag.AutoSize = true;
            this._StatusTag.Font = new System.Drawing.Font("Roboto Light", 22F);
            this._StatusTag.ForeColor = System.Drawing.Color.MediumOrchid;
            this._StatusTag.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._StatusTag.Location = new System.Drawing.Point(860, 686);
            this._StatusTag.Name = "_StatusTag";
            this._StatusTag.Size = new System.Drawing.Size(185, 44);
            this._StatusTag.TabIndex = 16;
            this._StatusTag.Text = "<unknow>";
            // 
            // _ChainErrorMessage
            // 
            this._ChainErrorMessage.AutoSize = true;
            this._ChainErrorMessage.Font = new System.Drawing.Font("Roboto Light", 10F);
            this._ChainErrorMessage.ForeColor = System.Drawing.Color.Red;
            this._ChainErrorMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._ChainErrorMessage.Location = new System.Drawing.Point(864, 755);
            this._ChainErrorMessage.Name = "_ChainErrorMessage";
            this._ChainErrorMessage.Size = new System.Drawing.Size(0, 20);
            this._ChainErrorMessage.TabIndex = 17;
            // 
            // BlockValidator
            // 
            this.BlockValidator.Interval = 5000;
            this.BlockValidator.Tick += new System.EventHandler(this.BlockValidation);
            // 
            // TotalBlocksTag
            // 
            this.TotalBlocksTag.AutoSize = true;
            this.TotalBlocksTag.Font = new System.Drawing.Font("Roboto Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBlocksTag.ForeColor = System.Drawing.Color.Yellow;
            this.TotalBlocksTag.Location = new System.Drawing.Point(518, 695);
            this.TotalBlocksTag.Name = "TotalBlocksTag";
            this.TotalBlocksTag.Size = new System.Drawing.Size(132, 96);
            this.TotalBlocksTag.TabIndex = 18;
            this.TotalBlocksTag.Text = "----";
            this.TotalBlocksTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Infoboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1150, 800);
            this.Controls.Add(this.TotalBlocksTag);
            this.Controls.Add(this._ChainErrorMessage);
            this.Controls.Add(this._StatusTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataProcessed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Infoboard";
            this.Text = "DatabaseServer";
            this.Load += new System.EventHandler(this.DatabaseServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this._BlockGrid)).EndInit();
            this.GridPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DataProcessed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer DataRequest;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid _BlockGrid;
        private System.Windows.Forms.Panel GridPanel;
        private Bunifu.Framework.UI.BunifuElipse GridRadius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _StatusTag;
        private System.Windows.Forms.Label _ChainErrorMessage;
        private System.Windows.Forms.Timer BlockValidator;
        private System.Windows.Forms.Label TotalBlocksTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrevAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockHash;
    }
}