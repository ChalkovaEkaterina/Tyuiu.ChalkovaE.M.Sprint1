using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tuyiu.ChalkovaE.M.Sprint1.Task5.V1.Lib;

namespace Tuyiu.ChalkovaE.M.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x1 = 1;
            double y1 = 3;
            double x2 = 1;
            double y2 = 5;
            DataService ds = new DataService();
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);

            int result = Convert.ToInt32(res);
            int wait = 2;
            Assert.AreEqual(wait, result);
        }
    }
}
