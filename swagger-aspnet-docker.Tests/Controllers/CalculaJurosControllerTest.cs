using Microsoft.VisualStudio.TestTools.UnitTesting;
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
