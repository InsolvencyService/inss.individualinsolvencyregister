﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.EIIR.DataSync.Infrastructure.Sink.AISearch
{
    public class FailedToSwapIndexException : Exception
    {
        public FailedToSwapIndexException(string message) : base(message) { }
    }
}
