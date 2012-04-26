//
// File Name: DefaultHandler.cs
//
// Description:
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzKata.Handlers {
  public class DefaultHandler : IInputHandler {

    public bool CanProcess(int input) {
      return true;
    }

    public string Process(int input) {
      return input.ToString();
    }

  }
}
