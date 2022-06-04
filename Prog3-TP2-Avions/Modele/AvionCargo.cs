using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Generateur
{
     public class AvionCargo : VehiculeTransport
    {
        
        public AvionCargo()
        {

        }

        [XmlElement]
        public float Max
        {
            get;
            set;
        }

        [XmlElement]
        public float Min
        {
            get;
            set;
        }
    }
}
