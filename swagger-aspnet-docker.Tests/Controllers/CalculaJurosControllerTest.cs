using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using swagger_aspnet_docker;
using swagger_aspnet_docker.Controllers;

namespace swagger_aspnet_docker.Tests.Controllers
{
    [TestClass]
    public class CalculaJurosControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Organizar
            CalculaJurosController controller = new CalculaJurosController();

            // Agir
            string result = controller.Get(100, 5);

            // Declarar
            Assert.AreEqual("105,10", result);
        }
    }
}
