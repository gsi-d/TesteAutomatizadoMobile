using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using teste.PageObject;

namespace teste
{
    [TestClass]
    public class Service : TestInitialize
    {
        private ServicePage servicePage;
        [TestInitialize]
        public void Initialization1()
        {
            servicePage = new ServicePage(driver);
        }
        [TestMethod]
        public void EntraJogo()
        {
            servicePage.Adicao();
            servicePage.Deslizar();
            servicePage.testeBetaVirtualLoomMobile();
            driver.Quit();
        }
    }
}
