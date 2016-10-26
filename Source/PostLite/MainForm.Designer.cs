namespace PostLite
{
    partial class MainForm
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
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.dgvHeader = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabInput = new System.Windows.Forms.TabControl();
            this.tabBody = new System.Windows.Forms.TabPage();
            this.tabHeaders = new System.Windows.Forms.TabPage();
            this.rtbRequest = new System.Windows.Forms.RichTextBox();
            this.tbResponse = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeader)).BeginInit();
            this.tabInput.SuspendLayout();
            this.tabBody.SuspendLayout();
            this.tabHeaders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(64, 22);
            this.tbUrl.Margin = new System.Windows.Forms.Padding(2);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(545, 20);
            this.tbUrl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbResponse);
            this.groupBox2.Controls.Add(this.lblTime);
            this.groupBox2.Location = new System.Drawing.Point(17, 304);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(682, 210);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Response";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(44, 191);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(34, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Value";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSend.Location = new System.Drawing.Point(618, 15);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(80, 40);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // bgw
            // 
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            // 
            // dgvHeader
            // 
            this.dgvHeader.BackgroundColor = System.Drawing.Color.White;
            this.dgvHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value,
            this.Remove});
            this.dgvHeader.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvHeader.Location = new System.Drawing.Point(6, 6);
            this.dgvHeader.Name = "dgvHeader";
            this.dgvHeader.Size = new System.Drawing.Size(666, 193);
            this.dgvHeader.TabIndex = 6;
            this.dgvHeader.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHeader_CellContentClick);
            this.dgvHeader.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // Key
            // 
            this.Key.HeaderText = "Key";
            this.Key.Name = "Key";
            this.Key.Width = 275;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Value.Width = 275;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "";
            this.Remove.Name = "Remove";
            this.Remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Remove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Remove.Text = "X";
            this.Remove.UseColumnTextForButtonValue = true;
            this.Remove.Width = 40;
            // 
            // tabInput
            // 
            this.tabInput.Controls.Add(this.tabBody);
            this.tabInput.Controls.Add(this.tabHeaders);
            this.tabInput.Location = new System.Drawing.Point(17, 63);
            this.tabInput.Name = "tabInput";
            this.tabInput.SelectedIndex = 0;
            this.tabInput.Size = new System.Drawing.Size(686, 231);
            this.tabInput.TabIndex = 6;
            // 
            // tabBody
            // 
            this.tabBody.Controls.Add(this.rtbRequest);
            this.tabBody.Location = new System.Drawing.Point(4, 22);
            this.tabBody.Name = "tabBody";
            this.tabBody.Padding = new System.Windows.Forms.Padding(3);
            this.tabBody.Size = new System.Drawing.Size(678, 205);
            this.tabBody.TabIndex = 0;
            this.tabBody.Text = "Body";
            this.tabBody.UseVisualStyleBackColor = true;
            // 
            // tabHeaders
            // 
            this.tabHeaders.Controls.Add(this.dgvHeader);
            this.tabHeaders.Location = new System.Drawing.Point(4, 22);
            this.tabHeaders.Name = "tabHeaders";
            this.tabHeaders.Padding = new System.Windows.Forms.Padding(3);
            this.tabHeaders.Size = new System.Drawing.Size(678, 205);
            this.tabHeaders.TabIndex = 1;
            this.tabHeaders.Text = "Headers";
            this.tabHeaders.UseVisualStyleBackColor = true;
            // 
            // rtbRequest
            // 
            this.rtbRequest.AcceptsTab = true;
            this.rtbRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbRequest.Location = new System.Drawing.Point(6, 6);
            this.rtbRequest.Name = "rtbRequest";
            this.rtbRequest.Size = new System.Drawing.Size(666, 193);
            this.rtbRequest.TabIndex = 1;
            this.rtbRequest.Text = "";
            // 
            // tbResponse
            // 
            this.tbResponse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbResponse.Location = new System.Drawing.Point(10, 18);
            this.tbResponse.Name = "tbResponse";
            this.tbResponse.ReadOnly = true;
            this.tbResponse.Size = new System.Drawing.Size(666, 170);
            this.tbResponse.TabIndex = 2;
            this.tbResponse.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(633, 191);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(34, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Value";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(715, 517);
            this.Controls.Add(this.tabInput);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUrl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Post Lite";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeader)).EndInit();
            this.tabInput.ResumeLayout(false);
            this.tabBody.ResumeLayout(false);
            this.tabHeaders.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblTime;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.DataGridView dgvHeader;
        private System.Windows.Forms.TabControl tabInput;
        private System.Windows.Forms.TabPage tabBody;
        private System.Windows.Forms.TabPage tabHeaders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.RichTextBox rtbRequest;
        private System.Windows.Forms.RichTextBox tbResponse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
    }
}

