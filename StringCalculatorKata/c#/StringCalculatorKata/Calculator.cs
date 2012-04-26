// Copyright (C) 2012 AdvancedMD Software, Inc.
//
// This source code contains information that is proprietary to
// AdvancedMD Software. Reproduction by any means in whole or
// in part without prior written permission from AdvancedMD Software
// is strictly prohibited. All Rights Reserved.
//
// File Name: Calculator.cs
//
// Description:
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StringCalculatorKata {
  public class Calculator {

    /// <summary>
    /// The method can take 0, 1 or 2 numbers, and will return their sum 
    /// (for an empty string it will return 0) for example “” or “1” or “1,2”.
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public int Add(string numbers) {
      // Check for empty string and return 0.
      if (String.IsNullOrEmpty(numbers)) {
        return 0;
      }

      // Check for negatives.
      var negativeList = Regex.Matches(numbers, @"(-\d+)");
      if (negativeList.Count > 0) {
        var stringList = new StringBuilder();
        foreach (var item in negativeList) {
          stringList.AppendFormat("{0} ", item);
        }
        throw new ArgumentException("Negatives not allowed.",
          new Exception(
            String.Format("Negative Numbers: {0}", stringList
        )));
      }

      // Check for valid number.
      //var numberList = Regex.Split(numbers, @"\D+");
      var numberList = Regex.Matches(numbers, @"(-?)(\d+)");
      var result = default(int);
      foreach (var item in numberList) {
        if (!((Match)item).Value.Equals(String.Empty)) {
          var number = Int32.Parse(((Match)item).Value);
          if (number < 1000) {
            result += number;
          }
        }
      }
      return result;
    }


  }
}
