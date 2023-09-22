using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tuyiu.ChalkovaE.M.Sprint1.Task1.V19.Lib;

namespace Tuyiu.ChalkovaE.M.Sprint1.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 20;
            var res = ds.ConvertInchToKm(x);
            Assert.AreEqual(0.000508, res);

        }
    }
}
