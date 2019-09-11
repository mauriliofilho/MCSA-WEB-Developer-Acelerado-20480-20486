using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LineOnCode.Store.Tests
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void MeuPrimeiroTeste()
        {
            //arrange => ambiente de Teste
            var flag = true;

            ////act => ação que será testada
            //flag = new Random().Next(0, 2) == 1;

            //assert = > Verificar o resultado do teste
            Assert.IsTrue(flag);
        }
    }
}
