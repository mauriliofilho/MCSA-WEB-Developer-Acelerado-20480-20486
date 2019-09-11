using LineOnCode.Store.UI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LineOnCode.Store.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        //Dado um Home Controller
        public void OMetodoIndexDeveraRetornarUmaView()
        {
            //arrange
            var homeCtrl = new HomeController();

            //act
            var result = homeCtrl.Index() as ViewResult;

            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual(typeof(ViewResult), result.GetType());
        }
    }
}
