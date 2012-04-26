//
// File Name: IInputHandler.cs
//
// Description:
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzKata.Handlers {
  public interface IInputHandler {
    bool CanProcess(int input);
    string Process(int input);
  }
}
