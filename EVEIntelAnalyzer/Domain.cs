using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EVELogMonitor;

namespace EVEIntelAnalyzer
{
    public class SolarSystem
    {
        private static Dictionary<string, SolarSystem> SolarSystems = new Dictionary<string, SolarSystem>();
        public static SolarSystem GetSystem(string name)
        {
            if (SolarSystems.ContainsKey(name))
            {
                return SolarSystems[name];
            }
            else
            {
                SolarSystem system = new SolarSystem();
                system.name = name;
                SolarSystems[name] = system;
                return system;
            }
        }


        private string name;
        public IList<Intel> intel = new List<Intel>();

        public string Name 
        {
            get {return name; } 
        }
        public void Add(Intel intel)
        {
            this.intel.Add(intel);
        }
        public void Remove(Intel intel)
        {
            this.intel.Remove(intel);
        }

        private SolarSystem()
        {
        }

        public override string ToString()
        {
            return name;
        }
    }

    /*
    public class Player
    {
        public string name;
        public string ship;

        public IList<Intel> intel = new List<Intel>();

        public override string ToString()
        {
            return name;
        }
    }*/

    public class Intel
    {
        private SolarSystem system;

        public string Players { get; set; }
        public bool Clear { get; set; }
        public bool NoVisual { get; set; }

        public SolarSystem System
        {
            get { return this.system; }
            set {
                if (this.system != null)
                {
                    this.system.Remove(this);
                }
                this.system = value;
                this.system.Add(this);
            }
        }
        
        public string SystemName
        {
            get
            {
                if (System != null)
                {
                    return System.Name;
                }
                else
                {
                    return null;
                }
            }
        }

        public string Location { get; set; }
        public DateTime Timestamp {
            get { return LogMessage.Timestamp; } 
        }
        public LogChannel Channel
        {
            get { return LogMessage.Channel; }
        }
        public string ReportedBy
        {
            get { return LogMessage.Name; }
        }
        public string Message
        {
            get { return LogMessage.Message; }
        }

        public LogMessage LogMessage { get; set; }

        public override string ToString()
        {
            return Message;
        }
    }
}
