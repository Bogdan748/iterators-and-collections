using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndCollections
{
    public class EvenNumbersEnumaration : IEnumerable<long>
    {

        private readonly IEnumerable<long> _source;
    
        public EvenNumbersEnumaration (IEnumerable<long> source)
        {
            _source = source ?? Enumerable.Empty<long>();
        }


        public IEnumerator<long> GetEnumerator()
        {
            return GetEnumeratorInternal();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {

            return GetEnumeratorInternal();
        }


        private IEnumerator<long> GetEnumeratorInternal()
        {

            foreach(long number in _source)
            {
                bool isEven = number % 2 == 0;
                if (isEven)
                {
                    yield return number;
                }
            }

        }
        

        
    }
}
