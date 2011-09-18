using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EVEIntelAnalyzer
{
    public class IntelPresentation
    {
        public Intel Intel { get; set; }

        public IntelPresentation(Intel intel)
        {
            this.Intel = intel;
        }


        public override string ToString()
        {
            string message = "";

            if (Intel != null)
            {
                message += Intel.System != null ? GetRed(Intel.Red) : "";
                message += GetSystem(Intel.System);
                message += (message != "" ? " > " : "") + GetRawIntel(Intel);
            }

            return message;
        }


        public string ToSpeach()
        {
            string message = "";

            if (Intel != null)
            {

                if (Intel.System != null && Intel.System.Name != null)
                {
                    if (!Intel.Clear)
                    {
                        message += GetRed(Intel.Red);
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

        private string GetRed(Player red)
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
        }

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
            string rawIntel = Intel.Message.Message;
            if (rawIntel.Length > 50)
            {
                rawIntel = rawIntel.Substring(0, 50);
            }
            return "Intel: " + rawIntel;
        }
    }
}
