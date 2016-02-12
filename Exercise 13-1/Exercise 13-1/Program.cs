using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_13_1
{
    interface IConvertible
    {
        string ConvertToCSharp(string stringToConvert);
        string ConvertToVB(string stringToConvert);
    }
}
