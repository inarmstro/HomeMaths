using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeMaths
{
    public class Addition: IAddition
    {

        public List<Tuple<int, int, int>> GenerateAdditionUpto(int maxValue, int numberOfAdditions)
        {
            var rand = new Random();
            var calculations = new List<Tuple<int, int, int>>();
            
            for (ushort s = 0; s < numberOfAdditions;)
            {
                var x = rand.Next(0, maxValue);
                var calc = new Tuple<int, int, int>(x, maxValue - x, maxValue);
                if (!calculations.Contains(calc))
                {
                    calculations.Add(calc);
                    s++;
                }
            }
            
            return calculations;
        }
    }
}