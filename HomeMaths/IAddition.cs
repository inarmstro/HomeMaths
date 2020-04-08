using System;
using System.Collections.Generic;

namespace HomeMaths
{
    public interface IAddition
    {
        List<Tuple<int, int, int>> GenerateAdditionUpto(int maxValue, int numberOfAdditions);
    }
}