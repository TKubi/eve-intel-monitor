using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EVEIntelAnalyzer
{
    public class IntelPresentation
    {
        public Intel Intel { get; set; }
        public string System { get { return GetSystem(Intel.System); } set { } }
        public string Players { get { return Intel.Players; } set { } }
        public string RawIntel { get { return Intel.Message; } set { } }


        public IntelPresentation(Intel intel)
        {
            this.Intel = intel;
        }


        public override string ToString()
        {
            string message = "";

            if (Intel != null)
            {
                message += Intel.System != null ? Intel.Players : "";
                message += GetSystem(Intel.System);
                message += (message != "" ? " > " : "") + GetRawIntel(Intel);
            }


            return message;
        }

        private string BuildSpeekSolarSystem(string system)
        {
            string speakSystem = "";
            for (int i = 0; i < system.Length; i++)
            {
                char letter = system[i];
                char nextLetter = i + 1 < system.Length ? system[i + 1] : '\0';

                if (char.IsLetter(letter))
                {
                    speakSystem += system[i];
                    if (char.IsLetter(nextLetter))
                    {
                        speakSystem += ". ";
                    }
                }

                // only if this and next charecter is a numbe, put a separator
                else if (char.IsNumber(letter))
                {
                    speakSystem += system[i];
                    if (char.IsNumber(nextLetter) || nextLetter == '-')
                    {
                        speakSystem += IntelSettings.Default.SystemNameNumberSeparator; // ", ";
                    }
                }

                // if this is a '-' put a verbal transaction of '-' (i.e. tac)
                else if (letter == '-')
                {
                    speakSystem += IntelSettings.Default.SystemNameDash; // " tac ";
                }
            }
            return speakSystem;
        }

        private string ToSpeechOld()
        {
            string message = "";

            if (Intel != null)
            {

                if (Intel.System != null && Intel.System.Name != null)
                {
                    if (!Intel.Clear)
                    {
                        message += Intel.Players;
                    }

                    // convert the system name into "spelled by letter" with '-' spelled as 'tac'.
                    string system = Intel.System.Name;
                    string speakSystem = "";

                    for (int i = 0; i < system.Length; i++)
                    {
                        char letter = system[i];
                        if (char.IsLetter(letter))
                        {
                            speakSystem += system[i] + ". ";
                        }
                        else if (char.IsNumber(letter))
                        {
                            speakSystem += system[i] + ", ";
                        }
                        else if (letter == '-')
                        {
                            speakSystem += " tac ";
                        }
                    }

                    if (Intel.Clear)
                    {
                        message += speakSystem + " is clear.";
                    }
                    else
                    {
                        message += " in " + speakSystem;

                        if (Intel.NoVisual)
                        {
                            message += " no visual";
                        }
                    }

                }
                else
                {
                    message += GetRawIntel(Intel);
                }
            }

            return message;
        }

        private string ToSpeechNew()
        {
            string message = "";

            if (Intel != null)
            {


                if (Intel.System != null && Intel.System.Name != null)
                {
                    if (!Intel.Clear)
                    {
                        message += Intel.Players;
                    }

                    // convert the system name into "spelled by letter" and '-' spelled as 'tac', 
                    // based on settings.
                    string speakSystem = BuildSpeekSolarSystem(Intel.System.Name);

                    if (Intel.Clear)
                    {
                        message += speakSystem + " is clear.";
                    }
                    else
                    {
                        message += " in " + speakSystem;

                        if (Intel.NoVisual)
                        {
                            message += " no visual.";
                        }
                    }

                }
                else
                {
                    message += GetRawIntel(Intel);
                }
            }

            return message;
        }

        public string ToSpeech()
        {
            if (IntelSettings.Default.ReadUseOldSpeechGeneration)
            {
                return ToSpeechOld();
            }
            else
            {
                return ToSpeechNew();
            }
        }

        /*
        private string GetPlayer(Player red)
        {
            if (red != null)
            {
                string name = red.name != null ? red.name : "Intel";
                string ship = red.ship != null ? " flying " + red.ship : "";
                return name + ship;
            }
            else
            {
                return "red";
            }
        }*/

        private string GetSystem(SolarSystem system)
        {
            if (system != null)
            {
                string name = system.Name != null ? system.Name : "Unknown system";
                return " in " + name;
            }
            else
            {
                return "";
            }
        }

        private string GetRawIntel(Intel intel)
        {
            string rawIntel = Intel.Message;
            if (rawIntel.Length > 50)
            {
                rawIntel = rawIntel.Substring(0, 50);
            }
            return "Intel: " + rawIntel;
        }
    }
}

/*
 * 
   string message = "";

    if (Intel != null)
    {
        string systemName = GetSystem(Intel.System);
        message += (message != "" ? " >> " : "") + GetRawIntel(Intel);

        string playerNames = Players != null ? Players : "unknown";
        string systemName = system != null ? System.Name : "unknown";

        if (!Intel.Clear)
        {
            if (NoVisual)
            {
                return Intel.Players + " at " + GetSystem(Intel.System) + " [No Visual] >> " + Message;
            }
            else
            {
                return Intel.Players + " at " + GetSystem(Intel.System) + " (" + Location + ") >> " + Message;
            }
        }
        else
        {
            return GetSystem(Intel.System) + " [Clear] >> " + LogMessage;
        }
 * 
 */

