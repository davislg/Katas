using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzKata {
  public class FizzBuzz {

    public string Do(int number) {
      var isEven         = number % 2 == 0;
      var isDivisibleBy3 = number % 3 == 0;
      var isDivisibleBy5 = number % 5 == 0;
      var result         = number.ToString();

      if (isEven) {
        result = "Even";
      }
      else if (isDivisibleBy3 && isDivisibleBy5) {
        result = "FizzBuzz";
      }
      else if (isDivisibleBy3) {
        result = "Fizz";
      }
      else if (isDivisibleBy5) {
        result = "Buzz";
      } 

      return result;
    }

    public string DoRange(int begin, int end) {
      var outputList = new StringBuilder();

      for (int i = begin; i <= end; i++) {
        outputList.Append(Do(i));
        if (i != end) {
          outputList.Append(",");
        }
      }
      
      return outputList.ToString();
    }

  }
}
