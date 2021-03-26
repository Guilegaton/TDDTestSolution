using System;
using System.Collections.Generic;
using System.Text;

namespace TDDTestSolution.Interfaces
{
    public interface IOddEvenService
    {
        string CheckRange(uint range);
        string CheckNumber(uint number);
    }
}
