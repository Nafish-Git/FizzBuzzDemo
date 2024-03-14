using FizzBuzzAPIDemo;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using Xunit;

namespace FizzBuzzAPIDemoTest
{
    public class FizzBuzzTest
    {
        private readonly IFizzBuzzProcessor _iFizzBuzzProcessor;
        public FizzBuzzTest()
        {
            _iFizzBuzzProcessor = new FizzBuzzProcessor();
        }
        [Fact]
        public void TestToVerifyNumberDividedBy3()
        {
            string[] numarr = { "3", "6", "9" };
            var fizzBuzzResponses = _iFizzBuzzProcessor.ProcessData(numarr);

            var OutPutData = fizzBuzzResponses
                    .Where(c => c.OutPutData == "Fizz")
                    .Select(c => c.OutPutData).FirstOrDefault();

            Assert.NotNull(fizzBuzzResponses);
            Assert.Equal(3, fizzBuzzResponses.Count());
            Assert.Equal("Fizz", OutPutData);
        }
        [Fact]
        public void TestToVerifyNumberDividedBy5()
        {
            string[] numarr = { "5", "10", "25" };
            var fizzBuzzResponses = _iFizzBuzzProcessor.ProcessData(numarr);

            var OutPutData = fizzBuzzResponses
                    .Where(c => c.OutPutData == "Buzz")
                    .Select(c => c.OutPutData).FirstOrDefault();

            Assert.NotNull(fizzBuzzResponses);
            Assert.Equal(3, fizzBuzzResponses.Count());
            Assert.Equal("Buzz", OutPutData);
        }
        [Fact]
        public void TestToVerifyNumberDividedBy_3_And_5()
        {
            string[] numarr = {"15" , "30", "45" };
            var fizzBuzzResponses = _iFizzBuzzProcessor.ProcessData(numarr);

            var OutPutData = fizzBuzzResponses
                    .Where(c => c.OutPutData == "FizzBuzz")
                    .Select(c => c.OutPutData).FirstOrDefault();

            Assert.NotNull(fizzBuzzResponses);
            Assert.Equal(3, fizzBuzzResponses.Count());
            Assert.Equal("FizzBuzz", OutPutData);
        }
        [Fact]
        public void TestToVerifyArrayHavingNullValue()
        {
            string[] numarr = { "5", null, "25" };
            var fizzBuzzResponses = _iFizzBuzzProcessor.ProcessData(numarr);

            var OutPutData = fizzBuzzResponses
                    .Where(c => c.OutPutData == "Invalid Item")
                    .Select(c => c.OutPutData).FirstOrDefault();

            Assert.NotNull(fizzBuzzResponses);
            Assert.Equal(3, fizzBuzzResponses.Count());
            Assert.Equal("Invalid Item", OutPutData);
        }
        [Fact]
        public void TestToVerifyArrayHavingMixValue()
        {
            string[] numarr = { "3", null, "5", "15", "1" };
            var fizzBuzzResponses = _iFizzBuzzProcessor.ProcessData(numarr);

            var OutPutData3 = fizzBuzzResponses
                    .Where(c => c.OutPutData == "Divided 1 by 3")
                    .Select(c => c.OutPutData).FirstOrDefault();

            var OutPutData5 = fizzBuzzResponses
            .Where(c => c.OutPutData == "Divided 1 by 5")
            .Select(c => c.OutPutData).FirstOrDefault();
            var OutPutDataFizz = fizzBuzzResponses
            .Where(c => c.OutPutData == "Fizz")
            .Select(c => c.OutPutData).FirstOrDefault();
             var OutPutDataBuzz = fizzBuzzResponses
            .Where(c => c.OutPutData == "Buzz")
            .Select(c => c.OutPutData).FirstOrDefault();
            var OutPutDataFizzBuzz = fizzBuzzResponses
            .Where(c => c.OutPutData == "FizzBuzz")
            .Select(c => c.OutPutData).FirstOrDefault();
                        var OutPutDataInvalid = fizzBuzzResponses
            .Where(c => c.OutPutData == "Invalid Item")
            .Select(c => c.OutPutData).FirstOrDefault();

            Assert.NotNull(fizzBuzzResponses);
            Assert.Equal(6, fizzBuzzResponses.Count());
            Assert.Equal("Divided 1 by 3", OutPutData3);
            Assert.Equal("Divided 1 by 5", OutPutData5);
            Assert.Equal("Fizz", OutPutDataFizz);
            Assert.Equal("Buzz", OutPutDataBuzz);
            Assert.Equal("FizzBuzz", OutPutDataFizzBuzz);
            Assert.Equal("Invalid Item", OutPutDataInvalid);
        }
    }
}
