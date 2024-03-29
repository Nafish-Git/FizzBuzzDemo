﻿using System;
using System.Collections.Generic;

namespace FizzBuzzAPIDemo
{
    public interface IFizzBuzzProcessor
    {
        public IEnumerable<FizzBuzzResponse> ProcessData(string[] values);
    }

    public class FizzBuzzProcessor : IFizzBuzzProcessor
    {
        public IEnumerable<FizzBuzzResponse> ProcessData(string[] values)
        {
            List<FizzBuzzResponse> fizzBuzzResponses = new List<FizzBuzzResponse>();
            foreach (string item in values)
            {
                int i;
                bool isNumeric = int.TryParse(item, out i);

                FizzBuzzResponse fizzBuzzResponse = new FizzBuzzResponse();

                if (isNumeric)
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
                        fizzBuzzResponse.OutPutData = "Divided " + i + " by 3 " + "\r\n" + " Divided " + i + " by 5";
                    }
                }
                else
                {
                    fizzBuzzResponse.InputData = Convert.ToString(item);
                    fizzBuzzResponse.OutPutData = "Invalid Item";
                }

                fizzBuzzResponses.Add(fizzBuzzResponse);
            }

            return fizzBuzzResponses;
        }
    }
}
