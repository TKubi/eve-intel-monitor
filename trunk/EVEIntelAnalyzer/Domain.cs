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
    }

    public class Player
    {
        public string name;
        public string ship;

        public IList<Intel> intel = new List<Intel>();
    }

    public class Intel
    {
        private SolarSystem system;

        public Player Red { get; set; }
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

        public string Location { get; set; }
        public LogMessage Message { get; set; }

        public override string ToString()
        {
            string redName = Red != null ? Red.name : "unknown";
            string systemName = system != null ? System.Name : "unknown";

            if (Clear)
            {
                if (NoVisual)
                {
                    return redName + " at " + systemName + " [No Visual] > " + Message;
                }
                else
                {
                    return redName + " at " + systemName + " (" + Location + ") > " + Message;
                }
            }
            else
            {
                return systemName + " [Clear] > " + Message;
            }
        }
    }
}
