
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Reflection;
using System.IO;

namespace NMS_GateCollector
{
    public partial class Position
    {
        public Int16 x;
        public Int16 y;
        public Int16 z;
    }

    public partial class GateData
    {
        public string GateAddress;
        public int Galaxy;
        public Int16 PlanetPosition;
        public Int16 SolarSystemIndex;
        public Position Position;
    }

    public partial class Planet
    {
        public string GateAddress { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Discoverer { get; set; }
        public string GalaxyName { get; set; }
    }

    public partial class Position
    {
        public Position(string data)
        {           
            x = Convert.ToInt16(data.Substring(5, 3), 16);
            y = Convert.ToInt16(data.Substring(2, 3), 16);
            z = Convert.ToInt16(data.Substring(0, 2), 16);
        }
    }

    public partial class GateData
    {
        public GateData(Ua ua)
        {
            GateAddress = ua.String.Substring(2, 4) + ua.String.Substring(8, 8);
            Galaxy = Convert.ToInt16(ua.String.Substring(6, 2));
            //int.TryParse(ua.String.Substring(2, 6), out Galaxy);
            PlanetPosition = Convert.ToInt16(GateAddress.Substring(0, 1), 16);
            SolarSystemIndex = Convert.ToInt16(GateAddress.Substring(1, 3), 16);
            Position = new Position(GateAddress);
        }
    }

    public partial class Planet
    { 
        public Planet(Record worldData)
        {
            GateAddress = worldData.Dd.GateData.GateAddress;
            Id = worldData.Dd.Ua.String;
            Name = worldData.Dm.Cn;
            Discoverer = worldData.Ows.Usn;
            GalaxyName = Properties.Resources.ResourceManager.GetString(string.Format("Gal{0}", worldData.Dd.GateData.Galaxy));
        }
    }

    class PlanetEqualityComparator : IEqualityComparer<Planet>
    {
        public bool Equals(Planet x, Planet y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(Planet obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
