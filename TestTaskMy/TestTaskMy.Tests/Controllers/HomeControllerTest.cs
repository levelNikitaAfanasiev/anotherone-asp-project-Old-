using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTaskMy;
using TestTaskMy.Controllers;

namespace TestTaskMy.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void ProductList()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.ProductList() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
