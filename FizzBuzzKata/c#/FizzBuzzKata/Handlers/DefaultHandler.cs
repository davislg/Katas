// Copyright (C) 2012 AdvancedMD Software, Inc.
//
// This source code contains information that is proprietary to
// AdvancedMD Software. Reproduction by any means in whole or
// in part without prior written permission from AdvancedMD Software
// is strictly prohibited. All Rights Reserved.
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
