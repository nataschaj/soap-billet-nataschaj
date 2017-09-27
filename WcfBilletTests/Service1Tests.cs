using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfBillet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billet;

namespace WcfBillet.Tests
{ //comment
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetBilPrisTest()
        {
            var bil = new Bil();
            int pris = bil.Pris();
            Assert.AreEqual(240, pris);
        }

        [TestMethod()]
        public void GetMCPrisTest()
        {
            var mc = new MC();
            int pris = mc.Pris();
            Assert.AreEqual(125, pris);
        }

        [TestMethod()]
        public void GetBilBrobizzTest()
        {
            var bil = new Bil();
            bil.Brobizz = true;
            Assert.AreEqual(228, bil.Pris());
        }

       

        //[TestMethod()]
        //public void GetDataTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void GetDataUsingDataContractTest()
        //{
        //    Assert.Fail();
        //}


    }
}