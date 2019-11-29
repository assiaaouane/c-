using System;
using System.Collections.Generic;
using MetroAPILibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MetroAPIUnitTest
{
    [TestClass]
    public class MetroAPITest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string fakeJson = "[{\"id\":\"SEM: 0844\",\"name\":\"GRENOBLE, CHAMPS - ELYSEES\",\"lon\":5.71025,\"lat\":45.17794,\"zone\":\"SEM_GENCHAMPSEL\",\"lines\":[\"SEM: 12\"]},{\"id\":\"SEM: 0846\",\"name\":\"GRENOBLE, SALENGRO\",\"lon\":5.70893,\"lat\":45.17557,\"zone\":\"SEM_GENSALENGRO\",\"lines\":[\"SEM: 12\"]},{\"id\":\"SEM: 0847\",\"name\":\"GRENOBLE, SALENGRO\",\"lon\":5.70887,\"lat\":45.17566,\"zone\":\"SEM_GENSALENGRO\",\"lines\":[\"SEM: 12\"]}]";
            FakeJsonApi fake = new FakeJsonApi(fakeJson);
            MetroAPI target = new MetroAPI(fake);
            Dictionary<String, Arret> result = target.DicoArrets();

            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.ContainsKey("GRENOBLE, CHAMPS - ELYSEES"));
            Assert.IsTrue(result.ContainsKey("GRENOBLE, SALENGRO"));

            Assert.AreEqual(1, result["GRENOBLE, CHAMPS - ELYSEES"].lines.Count);
            Assert.AreEqual("SEM: 12", result["GRENOBLE, CHAMPS - ELYSEES"].lines[0]);

            Assert.AreEqual(1, result["GRENOBLE, SALENGRO"].lines.Count);
            Assert.AreEqual("SEM: 12", result["GRENOBLE, SALENGRO"].lines[0]);
        }

        [TestMethod]
        public void TestMethod()
        {
            //FakeJsonApi fake = new FakeJsonApi();
            MetroAPI target = new MetroAPI(fake);
            Dictionary<String, Arret> result = target.DicoArrets();
        }
    }
}
