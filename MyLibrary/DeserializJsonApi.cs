using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace MetroAPILibrary
{
    class DeserializJsonApi
    {
        public Dictionary<String, Arret>  Deserializ( string jsonApi)
        {

            List<Arret> arrets = JsonConvert.DeserializeObject<List<Arret>>(jsonApi);
            Dictionary<String, Arret> collectionArrets =
               new Dictionary<String, Arret>();

            //recuperation/affichage des données :
            foreach (Arret arret in arrets)

            {
                if (!collectionArrets.ContainsKey(arret.name))
                {
                    collectionArrets.Add(arret.name, arret);
                }
                else
                {
                    foreach (string line in arret.lines)
                    {
                        if (!collectionArrets[arret.name].lines.Contains(line))
                        {
                            collectionArrets[arret.name].lines.Add(line);
                        }
                    }

                }

            }
            return collectionArrets;

        }
    }
}
