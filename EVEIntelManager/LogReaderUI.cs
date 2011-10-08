using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EVELogMonitor;
using System.Security.Cryptography;

namespace EVEIntelManager
{
    public partial class LogReaderUI : UserControl
    {
        private HashSet<byte[]> messageHash = new HashSet<byte[]>();

        private HashSet <LogFileMonitor> monitors = new HashSet<LogFileMonitor>();

        public LogReaderUI()
        {
            InitializeComponent();
        }

        public int TimerInterval {
            get { return refreshTimer.Interval; }
            set { refreshTimer.Interval = value; }
        }

        public void Add(LogFileMonitor monitor) { 
            if (monitor != null)
            {
                monitors.Add(monitor);

                monitor.ChangedLogMessage += SetLogMessage;
                monitor.ChangedLogChannel += SetLogChannel;

                FileChannel fileChannel = monitor.FileChannel;

                SetLogChannel(fileChannel.Channel);

                if (!refreshTimer.Enabled)
                {
                    Start();
                }
            }
        }

        public void Remove(LogFileMonitor monitor)
        {
            if (monitor != null)
            {
                if (monitors.Remove(monitor))
                {
                    monitor.ChangedLogMessage -= SetLogMessage;
                    monitor.ChangedLogChannel -= SetLogChannel;
                }

                if (monitors.Count == 0 && refreshTimer.Enabled)
                {
                    Stop();
                }
            }
        }


        public void Start()
        {
            monitorToggle.Text = "&Pause";
            refreshTimer.Start();
        }
        
        public void Stop()
        {
            monitorToggle.Text = "&Continue";
            refreshTimer.Stop();
        }
        
        private void SetLogChannel(LogChannel channel)
        {
            if (channel.ChannelName != null)
            {
                labelChannel.Text = channel.ChannelName;
            }
            else
            {
                labelChannel.Text = "Unknown";
            }

            if (channel.Listener != null)
            {
                labelListener.Text = channel.Listener;
            }
            else
            {
                labelListener.Text = "Unknown";
            }
        }

        private bool VerifyHash(LogMessage message)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                string textToHash = (message.Name + message.Timestamp + message.Message);
                byte[] hash = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(textToHash));
                if (messageHash.Contains(hash))
                {
                    return false;
                }
                else
                {
                    messageHash.Add(hash);
                    return true;
                }
            }

        }

        private void SetLogMessage(LogMessage message)
        {
            if (InvokeRequired)
            {
                this.Invoke((NotifyLogMessage)SetLogMessage, message);
                return;
            }

            if (VerifyHash(message))
            {
                if (eventList.Items.Count > 0)
                {
                    eventList.Items.Insert(0, message);
                }
                else
                {
                    eventList.Items.Add(message);
                }
            }
            else
            {
                Console.WriteLine("Detected duplicate message: " + message);
            }
        }

        public void WriteMessage(string message)
        {
            if (eventList.Items.Count > 0)
            {
                eventList.Items.Insert(0, message);
            }
            else
            {
                eventList.Items.Add(message);
            }
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            eventList.Items.Clear();
            messageHash.Clear();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (eventList.CheckedItems.Count != 0)
            {
                while (eventList.CheckedItems.Count > 0)
                {
                    eventList.Items.Remove(eventList.CheckedItems[0]);
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            eventList.Items.Clear();
            messageHash.Clear();

            this.refreshBackgroundWorker.RunWorkerAsync();
        }

        private void monitorToggle_Click(object sender, EventArgs e)
        {
            if (!refreshTimer.Enabled)
            {
                Start();
            }
            else
            {
                Stop();
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            foreach (LogFileMonitor monitor in monitors) {
                monitor.Refresh(false);
            }
        }

        private void refreshBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (LogFileMonitor monitor in monitors)
            {
                monitor.Refresh(true);
            }
        }
    }
}
