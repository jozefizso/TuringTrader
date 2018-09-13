﻿//==============================================================================
// Project:     Trading Simulator
// Name:        LogEntry
// Description: log entry
// History:     2018ix11, FUB, created
//------------------------------------------------------------------------------
// Copyright:   (c) 2017-2018, Bertram Solutions LLC
//              http://www.bertram.solutions
// License:     this code is licensed under GPL-3.0-or-later
//==============================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUB_TradingSim
{
    public class LogEntry
    {
        public Order OrderTicket;
        public Bar BarOfExecution;
        public double FillPrice;
        public double Commission;
    }
}

//==============================================================================
// end of file