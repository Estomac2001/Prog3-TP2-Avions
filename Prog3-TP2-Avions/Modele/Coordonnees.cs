using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Generateur
{
    public class Coordonnees
    {
        public Coordonnees()
        {

        }

        [XmlElement]
        public int X
        {
            get;
            set;
        }

        [XmlElement]
        public int Y
        {
            get;
            set;
        }
    }
}
