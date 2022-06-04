using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Generateur
{
    public abstract class Vehicule
    {

        public Vehicule()
        {

        }

        [XmlElement]
        public string Nom
        {
            get;
            set;
        }

        [XmlElement]
        public int Vitesse
        {
            get;
            set;
        }

        [XmlElement]
        public int Entretien
        {
            get;
            set;
        }
    }
}
