using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lr_4
{
    public interface ISomethingCode
    {
        void RunCode();
        void DelSomethingCode(SomethingCodeHandler somethingCode);
        void AddSomethingCode(SomethingCodeHandler somethingCode);
    }
}