using System;
using System.Collections.Generic;
using System.Text;

using MetroAPILibrary;

namespace MetroAPIUnitTest
{
    public class FakeJsonApi : IConnexionApi
    {
        private string _jsonToReturn;

        public FakeJsonApi(string jsonToReturn)
        {
            _jsonToReturn = jsonToReturn;
        }

        public string Connexion(string URL)
        {
            return _jsonToReturn;
        }     
    }
}
