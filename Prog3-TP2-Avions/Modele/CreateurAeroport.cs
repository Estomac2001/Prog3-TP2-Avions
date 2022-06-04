using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
   public class CreateurAeroport
    {
        private static CreateurAeroport m_instance;

        public static CreateurAeroport Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new CreateurAeroport();
                }
                return m_instance;
            }

        }

        public Aeroport creerAeroport(string nom, Coordonnees position, int minPassagers, int maxPassagers, int minCargo, int maxCargo)
        {
            return new Aeroport
            {
                Nom = nom,
                Position = position,
                MinPassagers = minPassagers,
                MaxPassagers = maxPassagers,
                MinCargo = minCargo,
                MaxCargo = maxCargo
            };
        }
    }
}
