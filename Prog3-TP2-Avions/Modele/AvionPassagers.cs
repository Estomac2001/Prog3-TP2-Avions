using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Generateur
{
    public class AvionPassagers : VehiculeTransport
    {
        
        public AvionPassagers()
        {

        }

       [XmlElement]
        public int Max
        {
            get;
            set;
        }

        [XmlElement]
        public int Min
        {
            get;
            set;
        }
    }
}
