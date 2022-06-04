using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Generateur
{
    static class Generateur
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GenerateurVue form = new GenerateurVue();
            Application.Run(form);

            /**Aeroport aeroport = new Aeroport
            {
                Nom = "patate",
                MinCargo = 1,
                MaxCargo = 5,
                MinPassagers = 1,
                MaxPassagers = 5
            };

            XmlSerializer xs = new XmlSerializer(typeof(Aeroport));
            using (StreamWriter wr = new StreamWriter("aeroport.xml"))
            {
                xs.Serialize(wr, aeroport);
            }



            using (StreamReader rd = new StreamReader("aeroport.xml"))
            {
                Aeroport aero2 = xs.Deserialize(rd) as Aeroport;
                Console.WriteLine("Nom : {0} ", aero2.Nom);
            }*/

            

        }
    }
}
