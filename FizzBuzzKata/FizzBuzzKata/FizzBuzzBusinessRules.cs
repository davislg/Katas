//
// File Name: FizzBuzzBusinessRules.cs
//
// Description:
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzBuzzKata.Handlers;

namespace FizzBuzzKata {
  public class FizzBuzzBusinessRules {

    public static IList<IInputHandler> GetHandlers() {
        return new List<IInputHandler>() {
        new DivisibleBy3And4Handler(),
        new DivisibleBy3And5Handler(),
        new DivisibleBy3Handler(),
        new DivisibleBy5Handler(),
        new EvenHandler(),
        new OddHandler(),
        new DefaultHandler()
      };
    }
  }
}
