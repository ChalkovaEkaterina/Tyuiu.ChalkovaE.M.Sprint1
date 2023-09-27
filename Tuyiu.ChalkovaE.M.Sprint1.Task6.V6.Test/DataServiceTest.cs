using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tuyiu.ChalkovaE.M.Sprint1.Task6.V6.Lib;

namespace Tuyiu.ChalkovaE.M.Sprint1.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Привет, Катя";
            DataService ds = new DataService();
            string res = ds.DeleteFirstLetter(strTest);
            string wait = "ривет, атя";
            Assert.AreEqual(wait, res);
        }
    }
}
