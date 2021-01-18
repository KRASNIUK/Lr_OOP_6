using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lr_4
{
    public interface ITrapezoid
    {
         int downBase { get; }
         int rightSyte { get; }
         int leftSyte { get; }
         int h { get; }

         int upBase { get; }
         int S { get; }
    }
}