using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Generateur
{
    public class Aeroport
    {
        
        public Aeroport()
        {

        }

        /*
        [XmlIgnore]
        public List<Vehicule> Vehicules
        {
            get;
            set;

        }

        [XmlIgnore]
        public Coordonnees Position
        {
            get;
            set;

        }
        */

        [XmlElement]
        public string Nom
        {
            get;
            set;
        }

        [XmlElement]
        public int MaxPassagers
        {
            get;
            set;
        }

        [XmlElement]
        public int MinPassagers
        {
            get;
            set;
        }

        [XmlElement]
        public int MaxCargo
        {
            get;
            set;
        }

        [XmlElement]
        public int MinCargo
        {
            get;
            set;
        }

        public void serialiser(string fichier)
        {
           
        }

    }
}
