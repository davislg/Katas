// Copyright (C) 2012 AdvancedMD Software, Inc.
//
// This source code contains information that is proprietary to
// AdvancedMD Software. Reproduction by any means in whole or
// in part without prior written permission from AdvancedMD Software
// is strictly prohibited. All Rights Reserved.
//
// File Name: Command.cs
//
// Description:
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandDesignPattern {
  public abstract class Command {
    public abstract void Execute();
    public abstract void UnExecute();
  }
}
