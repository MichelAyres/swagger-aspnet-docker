using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using swagger_aspnet_docker;
using swagger_aspnet_docker.Controllers;

namespace swagger_aspnet_docker.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Organizar
            HomeController controller = new HomeController();

            // Agir
            ViewResult result = controller.Index() as ViewResult;

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
