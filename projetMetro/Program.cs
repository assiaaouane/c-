using MetroAPILibrary;
using System;
using System.Collections.Generic;

namespace projetMetro
{
    class Program
    {
        static void Main(string[] args)
        {

         /*   ConnexionApi connex = new ConnexionApi();
            //appel methode connexion:
         String jsonApi = connex.connexion("https://data.metromobilite.fr/api/linesNear/json?x=5.727760&y=45.185538&dist=1000&details=true");
            DeserializJsonApi deserializ = new DeserializJsonApi();
            Dictionary<String, Arret> DicoJsonApi = deserializ.Deserializ(jsonApi);
*/

            MetroAPI library = new MetroAPI();
            Dictionary<String, Arret> DicoJsonApi = library.DicoArrets();
            
            foreach (KeyValuePair<string, Arret> arret in DicoJsonApi)
            {
                Console.WriteLine(arret.Key);
                foreach(string line in arret.Value.lines)
                {
                    Console.WriteLine(line);
                }               
            }
        }
    }
}
