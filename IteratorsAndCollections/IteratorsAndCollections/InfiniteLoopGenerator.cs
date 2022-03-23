using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndCollections
{
    public static class InfiniteLoopGenerator
    {
        public static IEnumerable<long> Generate()
        {
            long start = 0;
            while (true)
            {
                yield return start;
                start++;
            }
        }
    }
}
