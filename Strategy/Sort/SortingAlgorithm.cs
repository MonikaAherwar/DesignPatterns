using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Sort
{
    internal class SortingAlgorithm
    {
        ISortingAlgorithm _algorithm;

        internal SortingAlgorithm(ISortingAlgorithm algorithm)
        {
            _algorithm = algorithm;
        }

        internal void Sort()
        {
            _algorithm.Sort();
        }
    }
}
