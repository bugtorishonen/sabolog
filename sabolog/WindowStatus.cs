using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace sabolog
{
    /// <summary>
    /// 現在のウィンドウ状態を取得するクラス。
    /// </summary>
    class WindowStatus
    {
        public class WindowStatusObj
        {
            public DateTime TakenAt { get; set; }
            public string TitleBar { get; set; }
            public string AppName { get; set; }
            public TimeSpan IdleTime { get; set; }

            public WindowStatusObj(DateTime takenAt, string titleBar, string appName, TimeSpan idleTime)
            {
                this.TakenAt = takenAt;
                this.TitleBar = titleBar;
                this.AppName = appName;
                this.IdleTime = idleTime;
            }
        }

        struct LASTINPUTINFO
        {
            public uint cbSize;
            public uint dwTime;
        }
        [DllImport("user32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);


        /// <summary>
        /// 現在の状態を取得する。
        /// </summary>
        public WindowStatusObj Tick()
        {
            DateTime takenAt = DateTime.Now;

            //アクティブウィンドウ取得
            string titleBar = null;
            string appName = null;
            IntPtr fgWinHandle = GetForegroundWindow();
            if (fgWinHandle != IntPtr.Zero)
            {
                StringBuilder windowtextsb = new StringBuilder(1024);
                if (GetWindowText(fgWinHandle, windowtextsb, windowtextsb.Capacity) > 0)
                {
                    titleBar = windowtextsb.ToString();
                }

                try
                {
                    uint processid;
                    GetWindowThreadProcessId(fgWinHandle, out processid);
                    if (processid != 0)
                    {
                        System.Diagnostics.Process windowprocess = System.Diagnostics.Process.GetProcessById((int)processid);
                        appName = windowprocess.MainModule.FileName;
                        windowprocess.Dispose();
                    }
                }
                catch (Exception)
                {

                }

            }

            //アイドル時間取得
            TimeSpan idleTime = new TimeSpan(0);
            LASTINPUTINFO lii = new LASTINPUTINFO();
            lii.cbSize = (uint)Marshal.SizeOf(lii);
            if (GetLastInputInfo(ref lii))
            {
                uint idlemsec = (uint)Environment.TickCount - lii.dwTime;
                idleTime = new TimeSpan((long)idlemsec * 10000);//100nsec unit
            }

            return new WindowStatusObj(takenAt, titleBar, appName, idleTime);
        }
    }
}
