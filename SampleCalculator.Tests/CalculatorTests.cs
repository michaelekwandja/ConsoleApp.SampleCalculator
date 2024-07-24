namespace SampleCalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Utility_Calculation_AddNumbers()
        {
            // Arrange
            var num1 = 10; 
            var num2 = 7;
            var expected = 17;
            var answer = Utility.AddNumbers(num1, num2);
            
            // Act
            Utility.AddNumbers(num1, num2);

            // Assert
            Assert.AreEqual(expected, answer);
        }
        [TestMethod]
        public void Utility_Calculation_SubtractNumbers()
        {
            // Arrange
            var num1 = 10;
            var num2 = 7;
            var expected = 3;
            var answer = Utility.SubtractNumbers(num1, num2);

            // Act
            Utility.SubtractNumbers(num1, num2);

            // Assert
            Assert.AreEqual(expected, answer);
        }
        [TestMethod]
        public void Utility_Calculation_MultiplyNumbers()
        {
            // Arrange
            var num1 = 10;
            var num2 = 7;
            var expected = 70;
            var answer = Utility.Product(num1, num2);

            // Act
            Utility.Product(num1, num2);

            // Assert
            Assert.AreEqual(expected, answer);
        }
        [TestMethod]
        public void Utility_Calculation_DivideNumbers()
        {
            // Arrange
            var num1 = 20;
            var num2 = 10;
            var expected = 2;
            var answer = Utility.Quotient(num1, num2);

            // Act
            Utility.Quotient(num1, num2);

            // Assert
            Assert.AreEqual(expected, answer);
        }
    }
}