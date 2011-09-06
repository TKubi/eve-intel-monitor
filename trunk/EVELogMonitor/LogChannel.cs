using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EVELogMonitor
{
    public class LogChannel
    {
        private string channelID;
        private string channelName;
        private string listener;
        private DateTime sessionStarted;

        public string ChannelID
        {
            set { this.channelID = value; }
            get { return this.channelID; }
        }

        public string ChannelName
        {
            set { this.channelName = value; }
            get { return this.channelName; }
        }

        public string Listener
        {
            set { this.listener = value; }
            get { return this.listener; }
        }

        public DateTime SessionStarted
        {
            set { this.sessionStarted = value; }
            get { return this.sessionStarted; }
        }

    }
}
