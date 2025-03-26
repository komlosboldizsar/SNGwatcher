namespace SNGwatcher
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tableLayoutStatus = new TableLayoutPanel();
            labelCnMargin = new Label();
            labelIdealRange = new Label();
            groupBoxStatus = new GroupBox();
            groupBoxReceiver = new GroupBox();
            tableLayoutReceiver = new TableLayoutPanel();
            labelReceiverType = new Label();
            labelReceiverAddress = new Label();
            groupBoxRemote = new GroupBox();
            tableLayoutRemote = new TableLayoutPanel();
            labelRemoteBaseUrl = new Label();
            labelRemoteId = new Label();
            labelRemoteLastUpdate = new Label();
            labelRemoteLastSuccessfulUpdate = new Label();
            labelReceiverStatus = new Label();
            valueCnMargin = new Label();
            valueIdealRange = new Label();
            valueReceiverType = new Label();
            valueReceiverAddress = new Label();
            valueReceiverStatus = new Label();
            valueRemoteBaseUrl = new Label();
            valueRemoteId = new Label();
            valueRemoteLastUpdate = new Label();
            valueRemoteLastSuccessfulUpdate = new Label();
            valueRemoteLastUpdateStatus = new Label();
            tableLayoutStatus.SuspendLayout();
            groupBoxStatus.SuspendLayout();
            groupBoxReceiver.SuspendLayout();
            tableLayoutReceiver.SuspendLayout();
            groupBoxRemote.SuspendLayout();
            tableLayoutRemote.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutStatus
            // 
            tableLayoutStatus.AutoSize = true;
            tableLayoutStatus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutStatus.ColumnCount = 4;
            tableLayoutStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutStatus.Controls.Add(labelCnMargin, 1, 0);
            tableLayoutStatus.Controls.Add(labelIdealRange, 1, 1);
            tableLayoutStatus.Controls.Add(valueIdealRange, 1, 1);
            tableLayoutStatus.Controls.Add(valueCnMargin, 2, 0);
            tableLayoutStatus.Dock = DockStyle.Fill;
            tableLayoutStatus.Location = new Point(10, 27);
            tableLayoutStatus.Name = "tableLayoutStatus";
            tableLayoutStatus.RowCount = 2;
            tableLayoutStatus.RowStyles.Add(new RowStyle());
            tableLayoutStatus.RowStyles.Add(new RowStyle());
            tableLayoutStatus.Size = new Size(760, 59);
            tableLayoutStatus.TabIndex = 0;
            // 
            // labelCnMargin
            // 
            labelCnMargin.AutoSize = true;
            labelCnMargin.Dock = DockStyle.Right;
            labelCnMargin.Font = new Font("Consolas", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelCnMargin.Location = new Point(200, 0);
            labelCnMargin.Name = "labelCnMargin";
            labelCnMargin.Padding = new Padding(0, 3, 10, 3);
            labelCnMargin.Size = new Size(177, 35);
            labelCnMargin.TabIndex = 0;
            labelCnMargin.Text = "C/N margin:";
            labelCnMargin.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelIdealRange
            // 
            labelIdealRange.AutoSize = true;
            labelIdealRange.Dock = DockStyle.Right;
            labelIdealRange.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdealRange.Location = new Point(263, 35);
            labelIdealRange.Name = "labelIdealRange";
            labelIdealRange.Padding = new Padding(0, 3, 10, 3);
            labelIdealRange.Size = new Size(114, 24);
            labelIdealRange.TabIndex = 1;
            labelIdealRange.Text = "Ideal range:";
            labelIdealRange.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBoxStatus
            // 
            groupBoxStatus.AutoSize = true;
            groupBoxStatus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxStatus.Controls.Add(tableLayoutStatus);
            groupBoxStatus.Dock = DockStyle.Top;
            groupBoxStatus.Location = new Point(10, 5);
            groupBoxStatus.Margin = new Padding(3, 3, 3, 10);
            groupBoxStatus.Name = "groupBoxStatus";
            groupBoxStatus.Padding = new Padding(10, 7, 10, 10);
            groupBoxStatus.Size = new Size(780, 96);
            groupBoxStatus.TabIndex = 1;
            groupBoxStatus.TabStop = false;
            groupBoxStatus.Text = "Status";
            // 
            // groupBoxReceiver
            // 
            groupBoxReceiver.AutoSize = true;
            groupBoxReceiver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxReceiver.Controls.Add(tableLayoutReceiver);
            groupBoxReceiver.Dock = DockStyle.Top;
            groupBoxReceiver.Location = new Point(10, 101);
            groupBoxReceiver.Margin = new Padding(3, 3, 3, 10);
            groupBoxReceiver.Name = "groupBoxReceiver";
            groupBoxReceiver.Padding = new Padding(10, 7, 10, 10);
            groupBoxReceiver.Size = new Size(780, 115);
            groupBoxReceiver.TabIndex = 2;
            groupBoxReceiver.TabStop = false;
            groupBoxReceiver.Text = "Receiver";
            // 
            // tableLayoutReceiver
            // 
            tableLayoutReceiver.AutoSize = true;
            tableLayoutReceiver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutReceiver.ColumnCount = 3;
            tableLayoutReceiver.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutReceiver.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutReceiver.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutReceiver.Controls.Add(labelReceiverType, 0, 0);
            tableLayoutReceiver.Controls.Add(labelReceiverAddress, 0, 1);
            tableLayoutReceiver.Controls.Add(labelReceiverStatus, 0, 2);
            tableLayoutReceiver.Controls.Add(valueReceiverType, 1, 0);
            tableLayoutReceiver.Controls.Add(valueReceiverAddress, 1, 1);
            tableLayoutReceiver.Controls.Add(valueReceiverStatus, 1, 2);
            tableLayoutReceiver.Dock = DockStyle.Fill;
            tableLayoutReceiver.Location = new Point(10, 27);
            tableLayoutReceiver.Name = "tableLayoutReceiver";
            tableLayoutReceiver.RowCount = 3;
            tableLayoutReceiver.RowStyles.Add(new RowStyle());
            tableLayoutReceiver.RowStyles.Add(new RowStyle());
            tableLayoutReceiver.RowStyles.Add(new RowStyle());
            tableLayoutReceiver.Size = new Size(760, 78);
            tableLayoutReceiver.TabIndex = 0;
            // 
            // labelReceiverType
            // 
            labelReceiverType.AutoSize = true;
            labelReceiverType.Dock = DockStyle.Left;
            labelReceiverType.Location = new Point(3, 0);
            labelReceiverType.Name = "labelReceiverType";
            labelReceiverType.Padding = new Padding(0, 3, 0, 3);
            labelReceiverType.Size = new Size(43, 26);
            labelReceiverType.TabIndex = 0;
            labelReceiverType.Text = "Type:";
            labelReceiverType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelReceiverAddress
            // 
            labelReceiverAddress.AutoSize = true;
            labelReceiverAddress.Dock = DockStyle.Left;
            labelReceiverAddress.Location = new Point(3, 26);
            labelReceiverAddress.Name = "labelReceiverAddress";
            labelReceiverAddress.Padding = new Padding(0, 3, 0, 3);
            labelReceiverAddress.Size = new Size(65, 26);
            labelReceiverAddress.TabIndex = 1;
            labelReceiverAddress.Text = "Address:";
            labelReceiverAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBoxRemote
            // 
            groupBoxRemote.AutoSize = true;
            groupBoxRemote.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxRemote.Controls.Add(tableLayoutRemote);
            groupBoxRemote.Dock = DockStyle.Top;
            groupBoxRemote.Location = new Point(10, 216);
            groupBoxRemote.Name = "groupBoxRemote";
            groupBoxRemote.Padding = new Padding(10, 7, 10, 10);
            groupBoxRemote.Size = new Size(780, 141);
            groupBoxRemote.TabIndex = 3;
            groupBoxRemote.TabStop = false;
            groupBoxRemote.Text = "Remote";
            // 
            // tableLayoutRemote
            // 
            tableLayoutRemote.AutoSize = true;
            tableLayoutRemote.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutRemote.ColumnCount = 4;
            tableLayoutRemote.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutRemote.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutRemote.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutRemote.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutRemote.Controls.Add(labelRemoteBaseUrl, 0, 0);
            tableLayoutRemote.Controls.Add(labelRemoteId, 0, 1);
            tableLayoutRemote.Controls.Add(labelRemoteLastUpdate, 0, 2);
            tableLayoutRemote.Controls.Add(labelRemoteLastSuccessfulUpdate, 0, 3);
            tableLayoutRemote.Controls.Add(valueRemoteBaseUrl, 1, 0);
            tableLayoutRemote.Controls.Add(valueRemoteId, 1, 1);
            tableLayoutRemote.Controls.Add(valueRemoteLastUpdate, 1, 2);
            tableLayoutRemote.Controls.Add(valueRemoteLastSuccessfulUpdate, 1, 3);
            tableLayoutRemote.Controls.Add(valueRemoteLastUpdateStatus, 2, 2);
            tableLayoutRemote.Dock = DockStyle.Fill;
            tableLayoutRemote.Location = new Point(10, 27);
            tableLayoutRemote.Name = "tableLayoutRemote";
            tableLayoutRemote.RowCount = 4;
            tableLayoutRemote.RowStyles.Add(new RowStyle());
            tableLayoutRemote.RowStyles.Add(new RowStyle());
            tableLayoutRemote.RowStyles.Add(new RowStyle());
            tableLayoutRemote.RowStyles.Add(new RowStyle());
            tableLayoutRemote.Size = new Size(760, 104);
            tableLayoutRemote.TabIndex = 0;
            // 
            // labelRemoteBaseUrl
            // 
            labelRemoteBaseUrl.AutoSize = true;
            labelRemoteBaseUrl.Dock = DockStyle.Left;
            labelRemoteBaseUrl.Location = new Point(3, 0);
            labelRemoteBaseUrl.Name = "labelRemoteBaseUrl";
            labelRemoteBaseUrl.Padding = new Padding(0, 3, 0, 3);
            labelRemoteBaseUrl.Size = new Size(73, 26);
            labelRemoteBaseUrl.TabIndex = 0;
            labelRemoteBaseUrl.Text = "Base URL:";
            labelRemoteBaseUrl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelRemoteId
            // 
            labelRemoteId.AutoSize = true;
            labelRemoteId.Dock = DockStyle.Left;
            labelRemoteId.Location = new Point(3, 26);
            labelRemoteId.Name = "labelRemoteId";
            labelRemoteId.Padding = new Padding(0, 3, 0, 3);
            labelRemoteId.Size = new Size(27, 26);
            labelRemoteId.TabIndex = 1;
            labelRemoteId.Text = "ID:";
            labelRemoteId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelRemoteLastUpdate
            // 
            labelRemoteLastUpdate.AutoSize = true;
            labelRemoteLastUpdate.Dock = DockStyle.Left;
            labelRemoteLastUpdate.Location = new Point(3, 52);
            labelRemoteLastUpdate.Name = "labelRemoteLastUpdate";
            labelRemoteLastUpdate.Padding = new Padding(0, 3, 0, 3);
            labelRemoteLastUpdate.Size = new Size(89, 26);
            labelRemoteLastUpdate.TabIndex = 2;
            labelRemoteLastUpdate.Text = "Last update:";
            labelRemoteLastUpdate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelRemoteLastSuccessfulUpdate
            // 
            labelRemoteLastSuccessfulUpdate.AutoSize = true;
            labelRemoteLastSuccessfulUpdate.Dock = DockStyle.Left;
            labelRemoteLastSuccessfulUpdate.Location = new Point(3, 78);
            labelRemoteLastSuccessfulUpdate.Name = "labelRemoteLastSuccessfulUpdate";
            labelRemoteLastSuccessfulUpdate.Padding = new Padding(0, 3, 0, 3);
            labelRemoteLastSuccessfulUpdate.Size = new Size(158, 26);
            labelRemoteLastSuccessfulUpdate.TabIndex = 3;
            labelRemoteLastSuccessfulUpdate.Text = "Last successful update:";
            labelRemoteLastSuccessfulUpdate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelReceiverStatus
            // 
            labelReceiverStatus.AutoSize = true;
            labelReceiverStatus.Dock = DockStyle.Left;
            labelReceiverStatus.Location = new Point(3, 52);
            labelReceiverStatus.Name = "labelReceiverStatus";
            labelReceiverStatus.Padding = new Padding(0, 3, 0, 3);
            labelReceiverStatus.Size = new Size(52, 26);
            labelReceiverStatus.TabIndex = 2;
            labelReceiverStatus.Text = "Status:";
            labelReceiverStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valueCnMargin
            // 
            valueCnMargin.AutoSize = true;
            valueCnMargin.Dock = DockStyle.Left;
            valueCnMargin.Font = new Font("Consolas", 15F, FontStyle.Bold, GraphicsUnit.Point);
            valueCnMargin.Location = new Point(383, 0);
            valueCnMargin.Name = "valueCnMargin";
            valueCnMargin.Padding = new Padding(10, 0, 0, 0);
            valueCnMargin.Size = new Size(163, 35);
            valueCnMargin.TabIndex = 2;
            valueCnMargin.Text = "[--.-- dB]";
            valueCnMargin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valueIdealRange
            // 
            valueIdealRange.AutoSize = true;
            valueIdealRange.Dock = DockStyle.Left;
            valueIdealRange.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            valueIdealRange.Location = new Point(383, 35);
            valueIdealRange.Name = "valueIdealRange";
            valueIdealRange.Padding = new Padding(10, 0, 0, 0);
            valueIdealRange.Size = new Size(178, 24);
            valueIdealRange.TabIndex = 3;
            valueIdealRange.Text = "[--.--] - [--.--] dB";
            valueIdealRange.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valueReceiverType
            // 
            valueReceiverType.AutoSize = true;
            valueReceiverType.Dock = DockStyle.Left;
            valueReceiverType.Location = new Point(203, 0);
            valueReceiverType.Name = "valueReceiverType";
            valueReceiverType.Padding = new Padding(0, 3, 0, 3);
            valueReceiverType.Size = new Size(69, 26);
            valueReceiverType.TabIndex = 3;
            valueReceiverType.Text = "[RX8200]";
            valueReceiverType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valueReceiverAddress
            // 
            valueReceiverAddress.AutoSize = true;
            valueReceiverAddress.Dock = DockStyle.Left;
            valueReceiverAddress.Location = new Point(203, 26);
            valueReceiverAddress.Name = "valueReceiverAddress";
            valueReceiverAddress.Padding = new Padding(0, 3, 0, 3);
            valueReceiverAddress.Size = new Size(92, 26);
            valueReceiverAddress.TabIndex = 4;
            valueReceiverAddress.Text = "[192.168.1.1]";
            valueReceiverAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valueReceiverStatus
            // 
            valueReceiverStatus.AutoSize = true;
            valueReceiverStatus.Dock = DockStyle.Left;
            valueReceiverStatus.Location = new Point(203, 52);
            valueReceiverStatus.Name = "valueReceiverStatus";
            valueReceiverStatus.Padding = new Padding(0, 3, 0, 3);
            valueReceiverStatus.Size = new Size(39, 26);
            valueReceiverStatus.TabIndex = 5;
            valueReceiverStatus.Text = "[OK]";
            valueReceiverStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valueRemoteBaseUrl
            // 
            valueRemoteBaseUrl.AutoSize = true;
            tableLayoutRemote.SetColumnSpan(valueRemoteBaseUrl, 2);
            valueRemoteBaseUrl.Dock = DockStyle.Left;
            valueRemoteBaseUrl.Location = new Point(203, 0);
            valueRemoteBaseUrl.Name = "valueRemoteBaseUrl";
            valueRemoteBaseUrl.Padding = new Padding(0, 3, 0, 3);
            valueRemoteBaseUrl.Size = new Size(197, 26);
            valueRemoteBaseUrl.TabIndex = 4;
            valueRemoteBaseUrl.Text = "[https://sngwatcher.org.info]";
            valueRemoteBaseUrl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valueRemoteId
            // 
            valueRemoteId.AutoSize = true;
            valueRemoteId.Dock = DockStyle.Left;
            valueRemoteId.Location = new Point(203, 26);
            valueRemoteId.Name = "valueRemoteId";
            valueRemoteId.Padding = new Padding(0, 3, 0, 3);
            valueRemoteId.Size = new Size(67, 26);
            valueRemoteId.TabIndex = 5;
            valueRemoteId.Text = "[hun999]";
            valueRemoteId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valueRemoteLastUpdate
            // 
            valueRemoteLastUpdate.AutoSize = true;
            valueRemoteLastUpdate.Dock = DockStyle.Left;
            valueRemoteLastUpdate.Location = new Point(203, 52);
            valueRemoteLastUpdate.Name = "valueRemoteLastUpdate";
            valueRemoteLastUpdate.Padding = new Padding(0, 3, 0, 3);
            valueRemoteLastUpdate.Size = new Size(153, 26);
            valueRemoteLastUpdate.TabIndex = 6;
            valueRemoteLastUpdate.Text = "[2000-01-01 12:00:00]";
            valueRemoteLastUpdate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valueRemoteLastSuccessfulUpdate
            // 
            valueRemoteLastSuccessfulUpdate.AutoSize = true;
            valueRemoteLastSuccessfulUpdate.Dock = DockStyle.Left;
            valueRemoteLastSuccessfulUpdate.Location = new Point(203, 78);
            valueRemoteLastSuccessfulUpdate.Name = "valueRemoteLastSuccessfulUpdate";
            valueRemoteLastSuccessfulUpdate.Padding = new Padding(0, 3, 0, 3);
            valueRemoteLastSuccessfulUpdate.Size = new Size(153, 26);
            valueRemoteLastSuccessfulUpdate.TabIndex = 7;
            valueRemoteLastSuccessfulUpdate.Text = "[2000-01-01 12:00:00]";
            valueRemoteLastSuccessfulUpdate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // valueRemoteLastUpdateStatus
            // 
            valueRemoteLastUpdateStatus.AutoSize = true;
            valueRemoteLastUpdateStatus.Dock = DockStyle.Left;
            valueRemoteLastUpdateStatus.Location = new Point(403, 52);
            valueRemoteLastUpdateStatus.Name = "valueRemoteLastUpdateStatus";
            valueRemoteLastUpdateStatus.Padding = new Padding(0, 3, 0, 3);
            valueRemoteLastUpdateStatus.Size = new Size(39, 26);
            valueRemoteLastUpdateStatus.TabIndex = 8;
            valueRemoteLastUpdateStatus.Text = "[OK]";
            valueRemoteLastUpdateStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 388);
            Controls.Add(groupBoxRemote);
            Controls.Add(groupBoxReceiver);
            Controls.Add(groupBoxStatus);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Padding = new Padding(10, 5, 10, 10);
            Text = "SNGwatch";
            tableLayoutStatus.ResumeLayout(false);
            tableLayoutStatus.PerformLayout();
            groupBoxStatus.ResumeLayout(false);
            groupBoxStatus.PerformLayout();
            groupBoxReceiver.ResumeLayout(false);
            groupBoxReceiver.PerformLayout();
            tableLayoutReceiver.ResumeLayout(false);
            tableLayoutReceiver.PerformLayout();
            groupBoxRemote.ResumeLayout(false);
            groupBoxRemote.PerformLayout();
            tableLayoutRemote.ResumeLayout(false);
            tableLayoutRemote.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutStatus;
        private GroupBox groupBoxStatus;
        private GroupBox groupBoxReceiver;
        private TableLayoutPanel tableLayoutReceiver;
        private Label labelReceiverType;
        private Label labelReceiverAddress;
        private GroupBox groupBoxRemote;
        private TableLayoutPanel tableLayoutRemote;
        private Label labelRemoteBaseUrl;
        private Label labelRemoteId;
        private Label labelRemoteLastUpdate;
        private Label labelCnMargin;
        private Label labelIdealRange;
        private Label labelRemoteLastSuccessfulUpdate;
        private Label valueCnMargin;
        private Label valueIdealRange;
        private Label labelReceiverStatus;
        private Label valueReceiverType;
        private Label valueReceiverAddress;
        private Label valueReceiverStatus;
        private Label valueRemoteBaseUrl;
        private Label valueRemoteId;
        private Label valueRemoteLastUpdate;
        private Label valueRemoteLastSuccessfulUpdate;
        private Label valueRemoteLastUpdateStatus;
    }
}