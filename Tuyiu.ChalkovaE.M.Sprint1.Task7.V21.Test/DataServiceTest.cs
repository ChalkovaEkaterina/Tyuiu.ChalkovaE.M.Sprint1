using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tuyiu.ChalkovaE.M.Sprint1.Task7.V21.Lib;

namespace Tuyiu.ChalkovaE.M.Sprint1.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double wait = 1.452;
            double res = ds.Calculate(x, y);
            double i_res = Math.Round(res, 3);
            Assert.AreEqual(i_res, wait);
        }
    }
}
