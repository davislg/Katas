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
  public class DivisibleBy3And4Handler : IInputHandler {
    public bool CanProcess(int input) {
      return (input % 3 == 0 && input % 4 == 0);
    }

    public string Process(int input) {
      return "FizzFuzz";
    }
  }
}
