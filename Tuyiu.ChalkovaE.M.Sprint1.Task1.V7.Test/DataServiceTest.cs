using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tuyiu.ChalkovaE.M.Sprint1.Task1.V7.Lib;

namespace Tuyiu.ChalkovaE.M.Sprint1.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double verst = 100;
            double wait = 106.68;

            var res = ds.VerstsToKilometers(verst);
            Assert.AreEqual(wait, res);

        }
    }
}
