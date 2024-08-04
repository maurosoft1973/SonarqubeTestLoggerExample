using SonarqubeTestLoggerExample;

namespace TestProject2
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calculator = new Calculator();

            //Act
            int total = calculator.Diff(5, 0);

            //Assert
            Assert.AreEqual(5, total);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var calculator = new Calculator();

            //Act
            int total = calculator.Diff(5, 5);

            //Assert
            Assert.AreEqual(0, total);
        }
    }
}