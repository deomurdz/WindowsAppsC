namespace RS_232_Terminal
{
    partial class FormMain
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
            this.butnTextOUT_ON = new System.Windows.Forms.Button();
            this.butnTextRST = new System.Windows.Forms.Button();
            this.lblRev = new System.Windows.Forms.Label();
            this.cboxErrorLED = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxErrorHex = new System.Windows.Forms.TextBox();
            this.rtbHistory = new System.Windows.Forms.RichTextBox();
            this.cboxBaudSelect = new System.Windows.Forms.ComboBox();
            this.labBaudRate = new System.Windows.Forms.Label();
            this.rtbCmd = new System.Windows.Forms.RichTextBox();
            this.butnOpenPort = new System.Windows.Forms.Button();
            this.labComPort = new System.Windows.Forms.Label();
            this.cboxPortSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butnWriteRead = new System.Windows.Forms.Button();
            this.butnClosePort = new System.Windows.Forms.Button();
            this.butnClearText = new System.Windows.Forms.Button();
            this.tboxErrorMsg = new System.Windows.Forms.TextBox();
            this.tlpBiggest = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoopOn = new System.Windows.Forms.Button();
            this.btnSingleOn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbScript = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbLoopCount = new System.Windows.Forms.RichTextBox();
            this.butnClearBuffers = new System.Windows.Forms.Button();
            this.butnAddChecksum = new System.Windows.Forms.Button();
            this.butnTextOUT_OFF = new System.Windows.Forms.Button();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.butnTextADR6 = new System.Windows.Forms.Button();
            this.butnTextFLT = new System.Windows.Forms.Button();
            this.tlpBiggest.SuspendLayout();
            this.SuspendLayout();
            // 
            // butnTextOUT_ON
            // 
            this.butnTextOUT_ON.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butnTextOUT_ON.BackColor = System.Drawing.Color.SandyBrown;
            this.butnTextOUT_ON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnTextOUT_ON.Location = new System.Drawing.Point(715, 266);
            this.butnTextOUT_ON.Margin = new System.Windows.Forms.Padding(0);
            this.butnTextOUT_ON.Name = "butnTextOUT_ON";
            this.butnTextOUT_ON.Size = new System.Drawing.Size(58, 30);
            this.butnTextOUT_ON.TabIndex = 4;
            this.butnTextOUT_ON.Text = "ON";
            this.butnTextOUT_ON.UseVisualStyleBackColor = false;
            this.butnTextOUT_ON.Click += new System.EventHandler(this.butnTextOutOn_Click);
            // 
            // butnTextRST
            // 
            this.butnTextRST.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butnTextRST.BackColor = System.Drawing.Color.SandyBrown;
            this.butnTextRST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnTextRST.Location = new System.Drawing.Point(715, 223);
            this.butnTextRST.Margin = new System.Windows.Forms.Padding(0);
            this.butnTextRST.Name = "butnTextRST";
            this.butnTextRST.Size = new System.Drawing.Size(58, 32);
            this.butnTextRST.TabIndex = 4;
            this.butnTextRST.Text = "RST";
            this.butnTextRST.UseVisualStyleBackColor = false;
            this.butnTextRST.Click += new System.EventHandler(this.butnTextRST_Click);
            // 
            // lblRev
            // 
            this.lblRev.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRev.AutoSize = true;
            this.lblRev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblRev.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRev.ForeColor = System.Drawing.Color.Green;
            this.lblRev.Location = new System.Drawing.Point(734, 7);
            this.lblRev.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lblRev.Name = "lblRev";
            this.lblRev.Size = new System.Drawing.Size(47, 14);
            this.lblRev.TabIndex = 5;
            this.lblRev.Text = "rev 08";
            // 
            // cboxErrorLED
            // 
            this.cboxErrorLED.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboxErrorLED.AutoSize = true;
            this.cboxErrorLED.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cboxErrorLED.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxErrorLED.Location = new System.Drawing.Point(739, 26);
            this.cboxErrorLED.Name = "cboxErrorLED";
            this.cboxErrorLED.Size = new System.Drawing.Size(42, 32);
            this.cboxErrorLED.TabIndex = 5;
            this.cboxErrorLED.Text = "Error";
            this.cboxErrorLED.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(475, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "<ESC>";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tboxErrorHex
            // 
            this.tboxErrorHex.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tboxErrorHex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpBiggest.SetColumnSpan(this.tboxErrorHex, 3);
            this.tboxErrorHex.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxErrorHex.Location = new System.Drawing.Point(653, 69);
            this.tboxErrorHex.MaxLength = 256;
            this.tboxErrorHex.Name = "tboxErrorHex";
            this.tboxErrorHex.ReadOnly = true;
            this.tboxErrorHex.Size = new System.Drawing.Size(128, 25);
            this.tboxErrorHex.TabIndex = 6;
            this.tboxErrorHex.TabStop = false;
            this.tboxErrorHex.Text = "0";
            this.tboxErrorHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtbHistory
            // 
            this.rtbHistory.BackColor = System.Drawing.Color.Wheat;
            this.tlpBiggest.SetColumnSpan(this.rtbHistory, 3);
            this.rtbHistory.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHistory.Location = new System.Drawing.Point(20, 228);
            this.rtbHistory.Margin = new System.Windows.Forms.Padding(5);
            this.rtbHistory.Name = "rtbHistory";
            this.tlpBiggest.SetRowSpan(this.rtbHistory, 6);
            this.rtbHistory.Size = new System.Drawing.Size(293, 483);
            this.rtbHistory.TabIndex = 2;
            this.rtbHistory.TabStop = false;
            this.rtbHistory.Text = "";
            this.rtbHistory.TextChanged += new System.EventHandler(this.rtbHistory_TextChanged);
            // 
            // cboxBaudSelect
            // 
            this.cboxBaudSelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpBiggest.SetColumnSpan(this.cboxBaudSelect, 3);
            this.cboxBaudSelect.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxBaudSelect.FormattingEnabled = true;
            this.cboxBaudSelect.Location = new System.Drawing.Point(566, 30);
            this.cboxBaudSelect.Name = "cboxBaudSelect";
            this.cboxBaudSelect.Size = new System.Drawing.Size(78, 24);
            this.cboxBaudSelect.TabIndex = 18;
            this.cboxBaudSelect.SelectedIndexChanged += new System.EventHandler(this.cboxBaudSelect_SelectedIndexChanged);
            // 
            // labBaudRate
            // 
            this.labBaudRate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labBaudRate.AutoSize = true;
            this.labBaudRate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBaudRate.ForeColor = System.Drawing.Color.Black;
            this.labBaudRate.Location = new System.Drawing.Point(486, 34);
            this.labBaudRate.Name = "labBaudRate";
            this.labBaudRate.Size = new System.Drawing.Size(74, 16);
            this.labBaudRate.TabIndex = 4;
            this.labBaudRate.Text = "Baud Rate";
            // 
            // rtbCmd
            // 
            this.rtbCmd.BackColor = System.Drawing.Color.Wheat;
            this.tlpBiggest.SetColumnSpan(this.rtbCmd, 3);
            this.rtbCmd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCmd.Location = new System.Drawing.Point(20, 190);
            this.rtbCmd.Margin = new System.Windows.Forms.Padding(5);
            this.rtbCmd.MaxLength = 256;
            this.rtbCmd.Multiline = false;
            this.rtbCmd.Name = "rtbCmd";
            this.rtbCmd.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbCmd.ShowSelectionMargin = true;
            this.rtbCmd.Size = new System.Drawing.Size(293, 27);
            this.rtbCmd.TabIndex = 10;
            this.rtbCmd.Text = "ADR 6";
            this.rtbCmd.WordWrap = false;
            this.rtbCmd.TextChanged += new System.EventHandler(this.rtbCmd_TextChanged);
            this.rtbCmd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbCmd_KeyDown);
            // 
            // butnOpenPort
            // 
            this.butnOpenPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.butnOpenPort.BackColor = System.Drawing.Color.Lime;
            this.butnOpenPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnOpenPort.Location = new System.Drawing.Point(153, 68);
            this.butnOpenPort.Name = "butnOpenPort";
            this.butnOpenPort.Size = new System.Drawing.Size(70, 28);
            this.butnOpenPort.TabIndex = 3;
            this.butnOpenPort.Text = "OPEN";
            this.butnOpenPort.UseVisualStyleBackColor = false;
            this.butnOpenPort.Click += new System.EventHandler(this.butnOpenPort_Click);
            // 
            // labComPort
            // 
            this.labComPort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labComPort.AutoSize = true;
            this.labComPort.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labComPort.ForeColor = System.Drawing.Color.Black;
            this.labComPort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labComPort.Location = new System.Drawing.Point(78, 34);
            this.labComPort.Name = "labComPort";
            this.labComPort.Size = new System.Drawing.Size(69, 16);
            this.labComPort.TabIndex = 4;
            this.labComPort.Text = "COM Port";
            this.labComPort.Click += new System.EventHandler(this.labComPort_Click);
            // 
            // cboxPortSelect
            // 
            this.cboxPortSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBiggest.SetColumnSpan(this.cboxPortSelect, 3);
            this.cboxPortSelect.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPortSelect.FormattingEnabled = true;
            this.cboxPortSelect.Location = new System.Drawing.Point(153, 30);
            this.cboxPortSelect.Name = "cboxPortSelect";
            this.cboxPortSelect.Size = new System.Drawing.Size(314, 24);
            this.cboxPortSelect.TabIndex = 17;
            this.cboxPortSelect.MouseLeave += new System.EventHandler(this.cboxPortSelect_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(170, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "<ENTER>";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // butnWriteRead
            // 
            this.butnWriteRead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butnWriteRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.butnWriteRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnWriteRead.ForeColor = System.Drawing.Color.Black;
            this.butnWriteRead.Location = new System.Drawing.Point(16, 103);
            this.butnWriteRead.Margin = new System.Windows.Forms.Padding(1);
            this.butnWriteRead.Name = "butnWriteRead";
            this.butnWriteRead.Size = new System.Drawing.Size(133, 42);
            this.butnWriteRead.TabIndex = 4;
            this.butnWriteRead.Text = "WRITE && READ";
            this.butnWriteRead.UseVisualStyleBackColor = false;
            this.butnWriteRead.Click += new System.EventHandler(this.butnWriteRead_Click);
            // 
            // butnClosePort
            // 
            this.butnClosePort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.butnClosePort.BackColor = System.Drawing.Color.Coral;
            this.butnClosePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnClosePort.Location = new System.Drawing.Point(321, 68);
            this.butnClosePort.Name = "butnClosePort";
            this.butnClosePort.Size = new System.Drawing.Size(70, 28);
            this.butnClosePort.TabIndex = 4;
            this.butnClosePort.Text = "CLOSE";
            this.butnClosePort.UseVisualStyleBackColor = false;
            this.butnClosePort.Click += new System.EventHandler(this.butnClosePort_Click);
            // 
            // butnClearText
            // 
            this.butnClearText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butnClearText.BackColor = System.Drawing.Color.LightSteelBlue;
            this.butnClearText.FlatAppearance.BorderSize = 0;
            this.butnClearText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnClearText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butnClearText.Location = new System.Drawing.Point(244, 105);
            this.butnClearText.Name = "butnClearText";
            this.butnClearText.Size = new System.Drawing.Size(70, 27);
            this.butnClearText.TabIndex = 4;
            this.butnClearText.Text = "CLR  TEXT";
            this.butnClearText.UseVisualStyleBackColor = false;
            this.butnClearText.Click += new System.EventHandler(this.butnClearText_Click);
            // 
            // tboxErrorMsg
            // 
            this.tboxErrorMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tboxErrorMsg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpBiggest.SetColumnSpan(this.tboxErrorMsg, 3);
            this.tboxErrorMsg.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxErrorMsg.Location = new System.Drawing.Point(652, 105);
            this.tboxErrorMsg.Multiline = true;
            this.tboxErrorMsg.Name = "tboxErrorMsg";
            this.tboxErrorMsg.Size = new System.Drawing.Size(128, 38);
            this.tboxErrorMsg.TabIndex = 8;
            // 
            // tlpBiggest
            // 
            this.tlpBiggest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tlpBiggest.ColumnCount = 10;
            this.tlpBiggest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpBiggest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.6729F));
            this.tlpBiggest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.4486F));
            this.tlpBiggest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.20561F));
            this.tlpBiggest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.66355F));
            this.tlpBiggest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.00935F));
            this.tlpBiggest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tlpBiggest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tlpBiggest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpBiggest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tlpBiggest.Controls.Add(this.btnLoopOn, 5, 4);
            this.tlpBiggest.Controls.Add(this.btnSingleOn, 3, 4);
            this.tlpBiggest.Controls.Add(this.label4, 4, 4);
            this.tlpBiggest.Controls.Add(this.cboxPortSelect, 2, 1);
            this.tlpBiggest.Controls.Add(this.labBaudRate, 5, 1);
            this.tlpBiggest.Controls.Add(this.cboxBaudSelect, 6, 1);
            this.tlpBiggest.Controls.Add(this.cboxErrorLED, 9, 1);
            this.tlpBiggest.Controls.Add(this.lblRev, 9, 0);
            this.tlpBiggest.Controls.Add(this.rtbScript, 4, 5);
            this.tlpBiggest.Controls.Add(this.labComPort, 1, 1);
            this.tlpBiggest.Controls.Add(this.butnOpenPort, 2, 2);
            this.tlpBiggest.Controls.Add(this.butnClosePort, 4, 2);
            this.tlpBiggest.Controls.Add(this.label2, 1, 4);
            this.tlpBiggest.Controls.Add(this.rtbLoopCount, 9, 4);
            this.tlpBiggest.Controls.Add(this.butnWriteRead, 1, 3);
            this.tlpBiggest.Controls.Add(this.label1, 2, 3);
            this.tlpBiggest.Controls.Add(this.tboxErrorHex, 7, 2);
            this.tlpBiggest.Controls.Add(this.butnClearBuffers, 6, 2);
            this.tlpBiggest.Controls.Add(this.tboxErrorMsg, 7, 3);
            this.tlpBiggest.Controls.Add(this.butnAddChecksum, 6, 3);
            this.tlpBiggest.Controls.Add(this.label3, 5, 3);
            this.tlpBiggest.Controls.Add(this.rtbCmd, 1, 5);
            this.tlpBiggest.Controls.Add(this.rtbHistory, 1, 6);
            this.tlpBiggest.Controls.Add(this.butnTextRST, 9, 6);
            this.tlpBiggest.Controls.Add(this.butnTextOUT_ON, 9, 7);
            this.tlpBiggest.Controls.Add(this.butnTextOUT_OFF, 9, 8);
            this.tlpBiggest.Controls.Add(this.rtbResults, 4, 11);
            this.tlpBiggest.Controls.Add(this.label5, 7, 4);
            this.tlpBiggest.Controls.Add(this.butnClearText, 3, 3);
            this.tlpBiggest.Controls.Add(this.butnTextADR6, 9, 5);
            this.tlpBiggest.Controls.Add(this.butnTextFLT, 9, 9);
            this.tlpBiggest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBiggest.Location = new System.Drawing.Point(0, 0);
            this.tlpBiggest.MinimumSize = new System.Drawing.Size(700, 500);
            this.tlpBiggest.Name = "tlpBiggest";
            this.tlpBiggest.RowCount = 14;
            this.tlpBiggest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpBiggest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpBiggest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpBiggest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpBiggest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlpBiggest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpBiggest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpBiggest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlpBiggest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlpBiggest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpBiggest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tlpBiggest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpBiggest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpBiggest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBiggest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBiggest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBiggest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBiggest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBiggest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBiggest.Size = new System.Drawing.Size(784, 722);
            this.tlpBiggest.TabIndex = 9;
            this.tlpBiggest.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpBiggest_Paint);
            // 
            // btnLoopOn
            // 
            this.btnLoopOn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLoopOn.BackColor = System.Drawing.Color.Tomato;
            this.btnLoopOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoopOn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoopOn.Location = new System.Drawing.Point(576, 146);
            this.btnLoopOn.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoopOn.Name = "btnLoopOn";
            this.btnLoopOn.Size = new System.Drawing.Size(58, 30);
            this.btnLoopOn.TabIndex = 27;
            this.btnLoopOn.Text = "Loop On";
            this.btnLoopOn.UseVisualStyleBackColor = false;
            this.btnLoopOn.Click += new System.EventHandler(this.btnLoopOn_Click);
            // 
            // btnSingleOn
            // 
            this.btnSingleOn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSingleOn.BackColor = System.Drawing.Color.LightGreen;
            this.btnSingleOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleOn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSingleOn.Location = new System.Drawing.Point(250, 146);
            this.btnSingleOn.Margin = new System.Windows.Forms.Padding(0);
            this.btnSingleOn.Name = "btnSingleOn";
            this.btnSingleOn.Size = new System.Drawing.Size(58, 30);
            this.btnSingleOn.TabIndex = 26;
            this.btnSingleOn.Text = "Sing On";
            this.btnSingleOn.UseVisualStyleBackColor = false;
            this.btnSingleOn.Click += new System.EventHandler(this.btnSingleOn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.tlpBiggest.SetColumnSpan(this.label4, 2);
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(386, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Loop Command";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // rtbScript
            // 
            this.rtbScript.BackColor = System.Drawing.Color.Wheat;
            this.tlpBiggest.SetColumnSpan(this.rtbScript, 3);
            this.rtbScript.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbScript.Location = new System.Drawing.Point(323, 190);
            this.rtbScript.Margin = new System.Windows.Forms.Padding(5);
            this.rtbScript.Name = "rtbScript";
            this.tlpBiggest.SetRowSpan(this.rtbScript, 6);
            this.rtbScript.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbScript.ShowSelectionMargin = true;
            this.rtbScript.Size = new System.Drawing.Size(320, 483);
            this.rtbScript.TabIndex = 22;
            this.rtbScript.Text = "OUT 1\nPC 1\nPV 10\nWAIT 1000\nPV 60\nWAIT 1000\nOUT 0\n";
            this.rtbScript.WordWrap = false;
            this.rtbScript.TextChanged += new System.EventHandler(this.rtbScript_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.tlpBiggest.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(51, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Single Command";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // rtbLoopCount
            // 
            this.rtbLoopCount.BackColor = System.Drawing.Color.White;
            this.rtbLoopCount.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLoopCount.Location = new System.Drawing.Point(710, 151);
            this.rtbLoopCount.Margin = new System.Windows.Forms.Padding(5);
            this.rtbLoopCount.MaxLength = 256;
            this.rtbLoopCount.Multiline = false;
            this.rtbLoopCount.Name = "rtbLoopCount";
            this.rtbLoopCount.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbLoopCount.ShowSelectionMargin = true;
            this.rtbLoopCount.Size = new System.Drawing.Size(67, 22);
            this.rtbLoopCount.TabIndex = 29;
            this.rtbLoopCount.Text = "10";
            this.rtbLoopCount.WordWrap = false;
            // 
            // butnClearBuffers
            // 
            this.butnClearBuffers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.butnClearBuffers.BackColor = System.Drawing.Color.LightSteelBlue;
            this.butnClearBuffers.Location = new System.Drawing.Point(566, 68);
            this.butnClearBuffers.Name = "butnClearBuffers";
            this.butnClearBuffers.Size = new System.Drawing.Size(71, 27);
            this.butnClearBuffers.TabIndex = 21;
            this.butnClearBuffers.Text = "CLR BUF";
            this.butnClearBuffers.UseVisualStyleBackColor = false;
            this.butnClearBuffers.Click += new System.EventHandler(this.butnClearBuffers_Click);
            // 
            // butnAddChecksum
            // 
            this.butnAddChecksum.BackColor = System.Drawing.Color.LightSteelBlue;
            this.butnAddChecksum.Location = new System.Drawing.Point(566, 105);
            this.butnAddChecksum.Name = "butnAddChecksum";
            this.butnAddChecksum.Size = new System.Drawing.Size(71, 27);
            this.butnAddChecksum.TabIndex = 21;
            this.butnAddChecksum.Text = "NO CS";
            this.butnAddChecksum.UseVisualStyleBackColor = false;
            this.butnAddChecksum.Click += new System.EventHandler(this.butnAddChecksum_Click);
            // 
            // butnTextOUT_OFF
            // 
            this.butnTextOUT_OFF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butnTextOUT_OFF.BackColor = System.Drawing.Color.SandyBrown;
            this.butnTextOUT_OFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnTextOUT_OFF.Location = new System.Drawing.Point(715, 305);
            this.butnTextOUT_OFF.Margin = new System.Windows.Forms.Padding(0);
            this.butnTextOUT_OFF.Name = "butnTextOUT_OFF";
            this.butnTextOUT_OFF.Size = new System.Drawing.Size(58, 32);
            this.butnTextOUT_OFF.TabIndex = 4;
            this.butnTextOUT_OFF.Text = "OFF";
            this.butnTextOUT_OFF.UseVisualStyleBackColor = false;
            this.butnTextOUT_OFF.Click += new System.EventHandler(this.butnTextOutOff_Click);
            // 
            // rtbResults
            // 
            this.rtbResults.BackColor = System.Drawing.Color.Wheat;
            this.tlpBiggest.SetColumnSpan(this.rtbResults, 3);
            this.rtbResults.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResults.Location = new System.Drawing.Point(323, 683);
            this.rtbResults.Margin = new System.Windows.Forms.Padding(5);
            this.rtbResults.MaxLength = 256;
            this.rtbResults.Multiline = false;
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbResults.ShowSelectionMargin = true;
            this.rtbResults.Size = new System.Drawing.Size(320, 28);
            this.rtbResults.TabIndex = 28;
            this.rtbResults.Text = "OK";
            this.rtbResults.WordWrap = false;
            this.rtbResults.TextChanged += new System.EventHandler(this.rtbResults_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tlpBiggest.SetColumnSpan(this.label5, 2);
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(653, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Count:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // butnTextADR6
            // 
            this.butnTextADR6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butnTextADR6.BackColor = System.Drawing.Color.SandyBrown;
            this.butnTextADR6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnTextADR6.Location = new System.Drawing.Point(715, 185);
            this.butnTextADR6.Margin = new System.Windows.Forms.Padding(0);
            this.butnTextADR6.Name = "butnTextADR6";
            this.butnTextADR6.Size = new System.Drawing.Size(58, 32);
            this.butnTextADR6.TabIndex = 4;
            this.butnTextADR6.Text = "ADR  6";
            this.butnTextADR6.UseVisualStyleBackColor = false;
            this.butnTextADR6.Click += new System.EventHandler(this.butnTextADR6_Click);
            // 
            // butnTextFLT
            // 
            this.butnTextFLT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butnTextFLT.BackColor = System.Drawing.Color.SandyBrown;
            this.butnTextFLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnTextFLT.Location = new System.Drawing.Point(715, 346);
            this.butnTextFLT.Margin = new System.Windows.Forms.Padding(0);
            this.butnTextFLT.Name = "butnTextFLT";
            this.butnTextFLT.Size = new System.Drawing.Size(58, 28);
            this.butnTextFLT.TabIndex = 19;
            this.butnTextFLT.Text = "FLT?";
            this.butnTextFLT.UseVisualStyleBackColor = false;
            this.butnTextFLT.Click += new System.EventHandler(this.butnTextFLT_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 722);
            this.Controls.Add(this.tlpBiggest);
            this.MinimumSize = new System.Drawing.Size(540, 489);
            this.Name = "FormMain";
            this.Text = "RS-232 Terminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMain_KeyPress);
            this.tlpBiggest.ResumeLayout(false);
            this.tlpBiggest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butnTextOUT_ON;
		private System.Windows.Forms.Button butnTextRST;
		private System.Windows.Forms.Label lblRev;
		private System.Windows.Forms.TableLayoutPanel tlpBiggest;
		private System.Windows.Forms.TextBox tboxErrorMsg;
		private System.Windows.Forms.Button butnClearText;
		private System.Windows.Forms.Button butnClosePort;
		private System.Windows.Forms.Button butnWriteRead;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboxPortSelect;
		private System.Windows.Forms.Label labComPort;
		private System.Windows.Forms.Button butnOpenPort;
		private System.Windows.Forms.RichTextBox rtbCmd;
		private System.Windows.Forms.Label labBaudRate;
		private System.Windows.Forms.ComboBox cboxBaudSelect;
		private System.Windows.Forms.RichTextBox rtbHistory;
		private System.Windows.Forms.TextBox tboxErrorHex;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox cboxErrorLED;
		private System.Windows.Forms.Button butnTextOUT_OFF;
		private System.Windows.Forms.Button butnTextFLT;
		private System.Windows.Forms.Button butnAddChecksum;
		private System.Windows.Forms.Button butnClearBuffers;
        private System.Windows.Forms.RichTextBox rtbScript;
        private System.Windows.Forms.Button butnTextADR6;
        private System.Windows.Forms.Button btnLoopOn;
        private System.Windows.Forms.Button btnSingleOn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.RichTextBox rtbLoopCount;
        private System.Windows.Forms.Label label5;
    }
}

