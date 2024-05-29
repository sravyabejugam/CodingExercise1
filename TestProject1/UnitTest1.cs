namespace TestProject1
{
    using CodingExercise.Controllers;
    using CodingExercise.Services;
    using System.Collections;

    public class Tests
    {
        private IFizzBuzz FizzService;
        private FizzBuzzController fizzBuzzController;
        [SetUp]
        public void Setup()
        {
            FizzService = new FizzBuzz();
               

        }

        [Test]
        public void TestForFizz()
        {
            fizzBuzzController = new FizzBuzzController(FizzService);
            ArrayList arr1 = new ArrayList();
            arr1.Add("12");

            var result = fizzBuzzController.Get(arr1);

            foreach (var item in result)
            {
                   
                var item1 = item.ToString();
                Assert.AreEqual("Fizz", item1 );
            }
        }

        [Test]
        public void TestForBuzz()
        {
            fizzBuzzController = new FizzBuzzController(FizzService);
            ArrayList arr1 = new ArrayList();
            arr1.Add("20");

            var result = fizzBuzzController.Get(arr1);

            foreach (var item in result)
            {

                var item1 = item.ToString();
                Assert.AreEqual("Buzz", item1);
            }
        }

        [Test]
        public void TestForFizzBuzz()
        {
            fizzBuzzController = new FizzBuzzController(FizzService);
            ArrayList arr1 = new ArrayList();
            arr1.Add("30");

            var result = fizzBuzzController.Get(arr1);

            foreach (var item in result)
            {

                var item1 = item.ToString();
                Assert.AreEqual("FizzBuzz", item1);
            }
        }


        [Test]
        public void TestForInvalid()
        {
            fizzBuzzController = new FizzBuzzController(FizzService);
            ArrayList arr1 = new ArrayList();
            arr1.Add("ABC");

            var result = fizzBuzzController.Get(arr1);

            foreach (var item in result)
            {

                var item1 = item.ToString();
                Assert.AreEqual("Invalid Item", item1);
            }
        }
    }
}