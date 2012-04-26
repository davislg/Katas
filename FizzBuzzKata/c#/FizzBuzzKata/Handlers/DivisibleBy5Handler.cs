// Copyright (C) 2012 AdvancedMD Software, Inc.
//
// This source code contains information that is proprietary to
// AdvancedMD Software. Reproduction by any means in whole or
// in part without prior written permission from AdvancedMD Software
// is strictly prohibited. All Rights Reserved.
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
