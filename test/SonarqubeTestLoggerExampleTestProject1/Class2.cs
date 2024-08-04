using SonarqubeTestLoggerExample;

namespace TestProject1
{
    [TestClass]
    public class Class2
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calculator = new Calculator();

            //Act
            int total = calculator.Sum(1, 1);

            //Assert
            Assert.AreEqual(2, total);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var calculator = new Calculator();

            //Act
            int total = calculator.Sum(5, 0);

            //Assert
            Assert.AreEqual(5, total);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var calculator = new Calculator();

            //Act
            int total = calculator.Sum(0, 10);

            //Assert
            Assert.AreEqual(10, total);
        }
    }
}