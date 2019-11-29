using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroAPILibrary
{
    public class MetroAPI
    {
        private IConnexionApi connex;

        public MetroAPI()
        {
            connex = new ConnexionApi();
        }

        public MetroAPI(IConnexionApi connexionApi)
        {
            connex = connexionApi;
        }

        public Dictionary<String, Arret> DicoArrets(string url)
        {
            //appel methode connexion:
            String jsonApi = connex.Connexion(url);

            DeserializJsonApi deserializ = new DeserializJsonApi();
            Dictionary<String, Arret> DicoJsonApi = deserializ.Deserializ(jsonApi);
            return DicoJsonApi;
        }
    }
}
