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

                if (ChangedIntelActive != null)
                {
                    ChangedIntelActive(this.active);
                }
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
                    intel.LogMessage = message;

                    string formattedMessage = message.Message;

                    foreach (string word in IntelSettings.Default.DetectIgroreWords)
                    {
                        formattedMessage = formattedMessage.Replace(word, "");
                    }
                    /*(string formattedMessage = message.Message.Replace("at ", "").
                                                   Replace("near ", "").
                                                   Replace("in ", "").
                                                   Replace("the ", "").
                                                   Replace("a ", "");
                    */

                    string[] systemKeywords = null;

                    foreach (string systemKeyword in IntelSettings.Default.DetectSystem)
                    {
                        if (formattedMessage.Contains(systemKeyword)) {
                            systemKeywords = systemKeyword.Split(' ');
                            break;
                        }
                    }

                    string[] messageParts = formattedMessage.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    if (systemKeywords != null)
                    {
                        for (int i = 0; i < messageParts.Length; i++)
                        {
                            if (systemKeywords[0] == messageParts[i] && i - 1 >= 0)
                            {
                                intel.System = SolarSystem.GetSystem(messageParts[i - 1]);
                            }
                            else if (systemKeywords.Contains(messageParts[i]))
                            {
                                // ignore the rest of the solar system keyword
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
                            else if (i + 1 < messageParts.Length && !systemKeywords.Contains(messageParts[i + 1]))
                            {
                                intel.Players += (intel.Players != "" ? " " : "") + messageParts[i];
                            }
                        }

                    }
                    if (ChangedIntel != null)
                    {
                        ChangedIntel(intel);
                        // since we alrady matched this intel, we do not want to keep searching
                    }
                    return;
                }
            }
        }
    }
}
