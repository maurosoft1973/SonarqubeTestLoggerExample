using SonarqubeTestLoggerExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void Test1()
        {
            var calculator = new Calculator();

            //Act
            int total = calculator.Sum(0, 0);

            //Assert
            Assert.AreEqual(0, total);
        }

        [TestMethod]
        public void Test2()
        {
            var calculator = new Calculator();

            //Act
            int total = calculator.Sum(1, 1);

            //Assert
            Assert.AreEqual(2, total);
        }

        [TestMethod]
        public void Test3()
        {
            var calculator = new Calculator();

            //Act
            int total = calculator.Sum(5, 0);

            //Assert
            Assert.AreEqual(5, total);
        }


        [TestMethod]
        public void Test4()
        {
            var calculator = new Calculator();

            //Act
            int total = calculator.Sum(0, 5);

            //Assert
            Assert.AreEqual(5, total);
        }
    }
}
