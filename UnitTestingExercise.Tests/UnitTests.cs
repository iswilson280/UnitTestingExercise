using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int number1, int number2, int number3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object

            Calculator instance = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            instance.Add(number1, number2, number3);

            //Assert
                //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,5,5)]//Add test data <-------
        [InlineData(5, 5, 0)]//Add test data <-------

        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange-- create instance - prep code

           var instance = new Calculator();

            //Act
            var actual = instance.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 25)]//Add test data <-------
        [InlineData(0, 5, 0)]//Add test data <-------

        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var instance = new Calculator();
            //Act
           var actual= instance.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 1)]//Add test data <-------
        [InlineData(25, 5, 5)]//Add test data <-------

        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var instance = new Calculator();
            //Act
            var actual = instance.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
