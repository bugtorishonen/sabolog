namespace sabolog
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerTakeLog = new System.Windows.Forms.Timer(this.components);
            this.listViewRecentLog = new System.Windows.Forms.ListView();
            this.columnHeaderDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTitleBar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAppName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIdleTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogDestination = new System.Windows.Forms.TextBox();
            this.buttonBrowseLogDestination = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownLogInterval = new System.Windows.Forms.NumericUpDown();
            this.checkBoxSaveUtf8 = new System.Windows.Forms.CheckBox();
            this.buttonSaveRestart = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStripNotifyIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLogInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // timerTakeLog
            // 
            this.timerTakeLog.Interval = 1000;
            this.timerTakeLog.Tick += new System.EventHandler(this.timerTakeLog_Tick);
            // 
            // listViewRecentLog
            // 
            this.listViewRecentLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDateTime,
            this.columnHeaderTitleBar,
            this.columnHeaderAppName,
            this.columnHeaderIdleTime});
            this.listViewRecentLog.Location = new System.Drawing.Point(12, 12);
            this.listViewRecentLog.Name = "listViewRecentLog";
            this.listViewRecentLog.Size = new System.Drawing.Size(616, 151);
            this.listViewRecentLog.TabIndex = 0;
            this.listViewRecentLog.UseCompatibleStateImageBehavior = false;
            this.listViewRecentLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDateTime
            // 
            this.columnHeaderDateTime.Text = "Date";
            this.columnHeaderDateTime.Width = 120;
            // 
            // columnHeaderTitleBar
            // 
            this.columnHeaderTitleBar.Text = "Title";
            this.columnHeaderTitleBar.Width = 200;
            // 
            // columnHeaderAppName
            // 
            this.columnHeaderAppName.Text = "Application";
            this.columnHeaderAppName.Width = 200;
            // 
            // columnHeaderIdleTime
            // 
            this.columnHeaderIdleTime.Text = "Idle Time";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStripNotifyIcon;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SaboLog";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStripNotifyIcon
            // 
            this.contextMenuStripNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStripNotifyIcon.Name = "contextMenuStripNotifyIcon";
            this.contextMenuStripNotifyIcon.Size = new System.Drawing.Size(97, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log destination:";
            // 
            // textBoxLogDestination
            // 
            this.textBoxLogDestination.Location = new System.Drawing.Point(103, 169);
            this.textBoxLogDestination.Name = "textBoxLogDestination";
            this.textBoxLogDestination.Size = new System.Drawing.Size(444, 19);
            this.textBoxLogDestination.TabIndex = 3;
            // 
            // buttonBrowseLogDestination
            // 
            this.buttonBrowseLogDestination.Location = new System.Drawing.Point(553, 167);
            this.buttonBrowseLogDestination.Name = "buttonBrowseLogDestination";
            this.buttonBrowseLogDestination.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseLogDestination.TabIndex = 4;
            this.buttonBrowseLogDestination.Text = "Browse...";
            this.buttonBrowseLogDestination.UseVisualStyleBackColor = true;
            this.buttonBrowseLogDestination.Click += new System.EventHandler(this.buttonBrowseLogDestination_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Log taking interval [sec]:";
            // 
            // numericUpDownLogInterval
            // 
            this.numericUpDownLogInterval.Location = new System.Drawing.Point(144, 197);
            this.numericUpDownLogInterval.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownLogInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLogInterval.Name = "numericUpDownLogInterval";
            this.numericUpDownLogInterval.Size = new System.Drawing.Size(48, 19);
            this.numericUpDownLogInterval.TabIndex = 6;
            this.numericUpDownLogInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxSaveUtf8
            // 
            this.checkBoxSaveUtf8.AutoSize = true;
            this.checkBoxSaveUtf8.Location = new System.Drawing.Point(222, 198);
            this.checkBoxSaveUtf8.Name = "checkBoxSaveUtf8";
            this.checkBoxSaveUtf8.Size = new System.Drawing.Size(103, 16);
            this.checkBoxSaveUtf8.TabIndex = 7;
            this.checkBoxSaveUtf8.Text = "Save as UTF-8";
            this.checkBoxSaveUtf8.UseVisualStyleBackColor = true;
            // 
            // buttonSaveRestart
            // 
            this.buttonSaveRestart.Location = new System.Drawing.Point(490, 194);
            this.buttonSaveRestart.Name = "buttonSaveRestart";
            this.buttonSaveRestart.Size = new System.Drawing.Size(138, 23);
            this.buttonSaveRestart.TabIndex = 8;
            this.buttonSaveRestart.Text = "Save && Restart";
            this.buttonSaveRestart.UseVisualStyleBackColor = true;
            this.buttonSaveRestart.Click += new System.EventHandler(this.buttonSaveRestart_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.Filter = "Comma Separated Values|*.csv|All Files|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 240);
            this.Controls.Add(this.buttonSaveRestart);
            this.Controls.Add(this.checkBoxSaveUtf8);
            this.Controls.Add(this.numericUpDownLogInterval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBrowseLogDestination);
            this.Controls.Add(this.textBoxLogDestination);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewRecentLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SaboLog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStripNotifyIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLogInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerTakeLog;
        private System.Windows.Forms.ListView listViewRecentLog;
        private System.Windows.Forms.ColumnHeader columnHeaderDateTime;
        private System.Windows.Forms.ColumnHeader columnHeaderTitleBar;
        private System.Windows.Forms.ColumnHeader columnHeaderAppName;
        private System.Windows.Forms.ColumnHeader columnHeaderIdleTime;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogDestination;
        private System.Windows.Forms.Button buttonBrowseLogDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownLogInterval;
        private System.Windows.Forms.CheckBox checkBoxSaveUtf8;
        private System.Windows.Forms.Button buttonSaveRestart;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

