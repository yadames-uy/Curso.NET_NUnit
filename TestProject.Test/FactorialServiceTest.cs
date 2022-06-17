using TestExample;

namespace TestProject.Test
{
    public class FactorialServiceTest
    {
        [Test]
        public void TestFactorialZero()
        {
            //Arrange
            FactorialService service = new FactorialService();

            //Act
            var result = service.Calcular(0);

            //Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void TestFactorialFive()
        {
            FactorialService service = new FactorialService();

            var result = service.Calcular(5);

            Assert.AreEqual(120, result);
        }
    }
}