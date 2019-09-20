using System;
using System.Collections.Generic;
using System.Linq;

namespace Remv.main
{
    public class Remover
    {
        public List<int> RemoveSmallest(List<int> number)
        {
            if (number.Count == 0) return number;
            else number.Remove(number.Min());

            return number;
        }
    }
}
