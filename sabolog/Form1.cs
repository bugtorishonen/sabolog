using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace sabolog
{
    public partial class Form1 : Form
    {
        WindowStatus winst;
        StreamWriter logdst;
        int logFlushCtr = 0;
        int logFlushSpan = 10;//ログ書き込み何回毎にファイルをflushするか。
        bool exitProgram = false;
        int maxListViewLog = 5;

        public Form1()
        {
            InitializeComponent();
            winst = new WindowStatus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //設定ロード
            textBoxLogDestination.Text = Properties.Settings.Default.LogDestination;
            numericUpDownLogInterval.Value = (decimal)Properties.Settings.Default.TakeInterval;
            checkBoxSaveUtf8.Checked = Properties.Settings.Default.SaveUtf8;

            string logdstpath = Properties.Settings.Default.LogDestination;
            if (string.IsNullOrEmpty(logdstpath))
            {
                logdstpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "sabolog.csv");
            }

            try
            {
                if (Properties.Settings.Default.SaveUtf8)
                {
                    logdst = new StreamWriter(logdstpath, true, Encoding.UTF8);
                }
                else
                {
                    logdst = new StreamWriter(logdstpath, true, Encoding.Default);//システムデフォルトのエンコーディング(shift-jis)
                }

                timerTakeLog.Interval = Properties.Settings.Default.TakeInterval * 1000;
                timerTakeLog.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot open log file. Fix log destination and restart.", "Sabolog", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timerTakeLog_Tick(object sender, EventArgs e)
        {
            var logobj = winst.Tick();
            appendLog(logobj, logdst);
            appendListView(logobj);
            logFlushCtr--;
            if (logFlushCtr <= 0)
            {
                logdst.Flush();
                logFlushCtr = logFlushSpan;
            }

        }

        private void appendLog(WindowStatus.WindowStatusObj logobj, StreamWriter logdst)
        {
            logdst.WriteLine("{0},{1},{2},{3}", logobj.TakenAt.ToString(), escapeCsvString(logobj.TitleBar), escapeCsvString(logobj.AppName), logobj.IdleTime.TotalSeconds.ToString());
        }

        private void appendListView(WindowStatus.WindowStatusObj logobj)
        {
            var lvitem = new ListViewItem();
            lvitem.Text = logobj.TakenAt.ToString();
            lvitem.SubItems.Add(logobj.TitleBar);
            lvitem.SubItems.Add(logobj.AppName);
            lvitem.SubItems.Add(logobj.IdleTime.TotalSeconds.ToString());
            listViewRecentLog.Items.Add(lvitem);
            if (listViewRecentLog.Items.Count > maxListViewLog)
            {
                listViewRecentLog.Items.RemoveAt(0);
            }
        }

        private string escapeCsvString(string s)
        {
            if (s == null)
            {
                return "";
            }
            else
            {
                return "\"" + s.Replace("\"", "\"\"") + "\"";
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (logdst != null)
            {
                logdst.Dispose();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !exitProgram)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitProgram = true;
            this.Close();
        }

        private void buttonSaveRestart_Click(object sender, EventArgs e)
        {
            //設定をセーブしアプリケーションを再起動
            Properties.Settings.Default.LogDestination = textBoxLogDestination.Text;
            Properties.Settings.Default.TakeInterval = (int)numericUpDownLogInterval.Value;
            Properties.Settings.Default.SaveUtf8 = checkBoxSaveUtf8.Checked;
            Properties.Settings.Default.Save();

            Application.Restart();
        }

        private void buttonBrowseLogDestination_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxLogDestination.Text = saveFileDialog1.FileName;
            }
        }
    }
}
