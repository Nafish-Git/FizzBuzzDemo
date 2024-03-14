using System;
using System.Collections.Generic;

namespace FizzBuzzAPIDemo
{
    public interface IFizzBuzzProcessor
    {
        public IEnumerable<FizzBuzzResponse> ProcessData(int?[] values);
    }

    public class FizzBuzzProcessor : IFizzBuzzProcessor
    {
        public IEnumerable<FizzBuzzResponse> ProcessData(int?[] values)
        {
            List<FizzBuzzResponse> fizzBuzzResponses = new List<FizzBuzzResponse>();
            foreach (int? i in values)
            {
                FizzBuzzResponse fizzBuzzResponse = new FizzBuzzResponse();

                if (i.HasValue)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                        fizzBuzzResponse.InputData = Convert.ToString(i);
                        fizzBuzzResponse.OutPutData = "FizzBuzz";
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                        fizzBuzzResponse.InputData = Convert.ToString(i);
                        fizzBuzzResponse.OutPutData = "Fizz";
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                        fizzBuzzResponse.InputData = Convert.ToString(i);
                        fizzBuzzResponse.OutPutData = "Buzz";
                    }
                    else
                    {
                        fizzBuzzResponse.InputData = Convert.ToString(i);
                        fizzBuzzResponse.OutPutData = "Divided 1 by 3";
                        fizzBuzzResponses.Add(fizzBuzzResponse);
                        fizzBuzzResponse = new FizzBuzzResponse();
                        fizzBuzzResponse.InputData = Convert.ToString(i);
                        fizzBuzzResponse.OutPutData = "Divided 1 by 5";
                    }
                }
                else
                {
                    fizzBuzzResponse.InputData = Convert.ToString(i);
                    fizzBuzzResponse.OutPutData = "Invalid Item";
                }

                fizzBuzzResponses.Add(fizzBuzzResponse);
            }

            return fizzBuzzResponses;
        }
    }
}
