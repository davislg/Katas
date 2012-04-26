// Copyright (C) 2012 AdvancedMD Software, Inc.
//
// This source code contains information that is proprietary to
// AdvancedMD Software. Reproduction by any means in whole or
// in part without prior written permission from AdvancedMD Software
// is strictly prohibited. All Rights Reserved.
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
