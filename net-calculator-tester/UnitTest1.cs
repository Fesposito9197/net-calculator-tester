using net_calculator;
using NUnit.Framework;

namespace net_calculator_tester
{
    [TestFixture]
    public class Tests
    {
        Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        [TestCase((float)6.5, (float)7.6)]
        [TestCase((float)8.9, (float)4.5)]

        public void TestAdd(float num1, float num2)
        {

            var somma = calc.Add(num1, num2);
            Assert.Pass();

        }

        [Test]
        [TestCase((float)4.5,(float)5.6)]
        [TestCase((float)99.7, (float)80.7)]

        public void TestSubstract(float num1, float num2)
        {
            var sottrazione = calc.Subtract(num1, num2);
            Assert.Pass();
        }

        [Test]
        [TestCase((float)5.6, (float)6.7)]
        [TestCase((float)80.9, (float)90.9)]
        public void TestDivide(float num1, float num2)
        {
            var divisione = calc.Divide(num1, num2);
            Assert.Pass();
        }


        [Test]
        [TestCase((float)5.6, (float)6.7)]
        [TestCase((float)6.7, (float)8.7)]
        public void TestMultiply(float num1, float num2)
        {
            var moltiplicazione = calc.Multiply(num1, num2);
            Assert.Pass();
        }
         
    }
}