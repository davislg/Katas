//
// File Name: OddHandler.cs
//
// Description:
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzKata.Handlers {
  public class OddHandler : IInputHandler{
    public bool CanProcess(int input) {
      return (input & 1) == 1;
    }

    public string Process(int input) {
      return "Odd";
    }
  }
}
