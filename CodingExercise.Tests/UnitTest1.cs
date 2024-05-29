namespace CodingExercise.Tests
{
    using CodingExercise.Controllers;
    using CodingExercise.Services;
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetTestFizz()
        {
            private readonly IFizzBuzz _fizzBuzz;
            var _controller = new FizzBuzzController(_fizzBuzz);
            Assert.Pass();
        }
    }
}