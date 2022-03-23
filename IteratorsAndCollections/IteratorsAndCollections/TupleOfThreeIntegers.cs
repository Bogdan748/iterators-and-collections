using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndCollections
{
    public class TupleOfThreeIntegers : IEnumerable<int>
    {

        public TupleOfThreeIntegers(int first, int second, int third)
        {
            First = first;
            Secodn = second;
            Third = third;
        }

        public int First { get; }
        public int Secodn { get; }
        public int Third { get; }

        public IEnumerator<int> GetEnumerator()
        {
            return GetEnumeratorInternal();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumeratorInternal();
        }


        private IEnumerator<int> GetEnumeratorInternal()
        {
            Console.WriteLine("Start - GetEnumeratorInternal");

            Console.WriteLine("Get EnumeratorInternal Before Return First");
            yield return First;
            Console.WriteLine("Get EnumeratorInternal After Return First");

            Console.WriteLine("Get EnumeratorInternal Before Return Secodn");
            yield return Secodn;
            Console.WriteLine("Get EnumeratorInternal After Return Secodn");

            Console.WriteLine("Get EnumeratorInternal Before Return Third");
            yield return Third;
            Console.WriteLine("Get EnumeratorInternal After Return Third");
        }
    }
}
