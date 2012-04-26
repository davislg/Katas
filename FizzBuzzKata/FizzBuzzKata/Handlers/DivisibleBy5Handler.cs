//
// File Name: DivisibleBy3Handler.cs
//
// Description:
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzKata.Handlers {
  public class DivisibleBy5Handler : IInputHandler {
    public bool CanProcess(int input) {
      return (input % 5 == 0);
    }

    public string Process(int input) {
      return "Buzz";
    }
  }
}
