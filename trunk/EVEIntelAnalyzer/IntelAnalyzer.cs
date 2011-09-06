using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EVELogMonitor;
using System.Text.RegularExpressions;
using System.Media;

namespace EVEIntelAnalyzer
{
    public delegate void NotifyIntel(Intel intel);
    public delegate void NotifyIntelActive(bool state);

    public class IntelAnalyzer
    {
        private bool active;

        public string[] MatchStrings { get; set; }
        public bool Active
        {
            get
            {
                return active;
            }
            set
            {
                this.active = value;
                ChangedIntelActive(this.active);
            }
        }

        public event NotifyIntel ChangedIntel;
        public event NotifyIntelActive ChangedIntelActive;

        public IntelAnalyzer()
        {
        }

        public void Add(LogFileMonitor monitor)
        {
            // first remove the event listener just in case
            monitor.ChangedLogMessage -= NotifyLogMessage;
            monitor.ChangedLogMessage += NotifyLogMessage;
        }

        public void Remove(LogFileMonitor monitor)
        {
            monitor.ChangedLogMessage -= NotifyLogMessage;
        }

        public void NotifyLogMessage(LogMessage message)
        {
            if (!Active)
            {
                return;
            }

            foreach (string searchText in MatchStrings)
            {
                Match match = Regex.Match(message.Message, ".*" + searchText + ".*",
                              RegexOptions.IgnorePatternWhitespace | RegexOptions.IgnoreCase);

                if (match.Success)
                {
                    Intel intel = new Intel();
                    intel.Message = message;

                    string formattedMessage = message.Message.Replace("at ", "").
                                                   Replace("near ", "").
                                                   Replace("in ", "").
                                                   Replace("the ", "");

                    string[] messageParts = formattedMessage.Split(' ');
                    if (messageParts.Contains("Solar") && messageParts.Contains("System"))
                    {
                        for (int i = 0; i < messageParts.Length; i++)
                        {
                            if (messageParts[i] == "Solar" && i - 1 >= 0)
                            {
                                intel.System = SolarSystem.GetSystem(messageParts[i - 1]);
                                intel.Red = new Player();
                                for (int j = 0; j < i - 1; j++)
                                {
                                    if (messageParts[j] != "")
                                    {
                                        intel.Red.name += messageParts[j] + " ";
                                    }
                                }
                            }
                            else if (messageParts[i].ToLower() == "nv")
                            {
                                intel.NoVisual = true;
                                intel.Location = "No Visual";
                            }
                            else if (messageParts[i].ToLower() == "clear" || messageParts[i].ToLower() == "clr")
                            {
                                intel.Clear = true;
                                intel.Location = "Clear";
                            }
                        }

                    }

                    ChangedIntel(intel);
                    // since we alrady matched this intel, we do not want to keep searching
                    return;
                }
            }
        }
    }
}
