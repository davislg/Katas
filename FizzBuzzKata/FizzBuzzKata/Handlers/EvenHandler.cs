//
// File Name: EvenHandler.cs
//
// Description:
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzKata.Handlers {
  public class EvenHandler : IInputHandler {
    public bool CanProcess(int input) {
      return (input % 2 == 0);
    }

    public string Process(int input) {
      return "Even";
    }
  }
}
