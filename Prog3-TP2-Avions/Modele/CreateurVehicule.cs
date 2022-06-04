using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
    public class CreateurVehicule
    {
        private static CreateurVehicule m_instance;

        public static CreateurVehicule Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new CreateurVehicule();
                }
                return m_instance;
            }
        }

        
        public AvionPassagers creerAvionPassagers(string nom, int vitesse, int entretien, int min, int max) 
        {
            return new AvionPassagers
            {
                Nom = nom,
                Vitesse = vitesse,
                Entretien = entretien,
                Min = min,
                Max = max
            };
        }
        public AvionCargo creerAvionCargo(string nom, int vitesse, int entretien, float min, float max) 
        {
            return new AvionCargo
            {
                Nom = nom,
                Vitesse = vitesse,
                Entretien = entretien,
                Min = min,
                Max = max
            };
        }
        public AvionObservateur creerAvionObservateur(string nom, int vitesse, int entretien) 
        {
            return new AvionObservateur
            {
                Nom = nom,
                Vitesse = vitesse,
                Entretien = entretien
            };
        }
        public AvionCiterne creerAvionCiterne(string nom, int vitesse, int entretien) 
        {
            return new AvionCiterne
            {
                Nom = nom,
                Vitesse = vitesse,
                Entretien = entretien
            };
        }
        public HelicoptereSecours creerHelicoptereSecours(string nom, int vitesse, int entretien) 
        {
            return new HelicoptereSecours
            {
                Nom = nom,
                Vitesse = vitesse,
                Entretien = entretien
            };
        }
        
    }
}
