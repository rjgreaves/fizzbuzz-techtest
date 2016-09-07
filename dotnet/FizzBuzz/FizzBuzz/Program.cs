using System;
using System.Collections.Generic;

namespace FizzBuzz
{
  class Program
  {
      static void Main(string[] args)
      {
          var value = ParameterParser.GetValue(args);

          if (value == null)
          {
              Console.Write("You must pass in a numeric value as the first parameter.");
              return;
          }

          Console.Write(FizzBuzz.GetResult(value.Value));

      }
  }
}


