// Copyright (C) 2012 AdvancedMD Software, Inc.
//
// This source code contains information that is proprietary to
// AdvancedMD Software. Reproduction by any means in whole or
// in part without prior written permission from AdvancedMD Software
// is strictly prohibited. All Rights Reserved.
//
// File Name: FizzBuzzPattern.cs
//
// Description:
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzBuzzKata.Handlers;

namespace FizzBuzzKata {
  public class FizzBuzzPattern {

    private IEnumerable<IInputHandler> handlers;

    public FizzBuzzPattern(IEnumerable<IInputHandler> handlers) {
      this.handlers = handlers;
    }

    public string Process(int number) {
      //foreach (var item in handlers) {
      //  if (item.CanProcess(number)) {
      //    return item.Process(number);
      //  }
      //}
      var handler = handlers.Where(h => h.CanProcess(number)).First();
      if (handler == null) {
        throw new ArgumentException("Unhandled input");
      }
      return handler.Process(number);
    }

    public string ProcessRange(int begin, int end) {
      var outputList = new StringBuilder();

      for (int i = begin; i <= end; i++) {
        outputList.Append(Process(i));
        if (i != end) {
          outputList.Append(",");
        }
      }

      return outputList.ToString();
    }

  }

}
