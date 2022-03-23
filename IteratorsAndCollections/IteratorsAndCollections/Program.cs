using System;
using System.Collections.Generic;

namespace IteratorsAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (int elem in new EvenNumbersEnumaration(InfiniteLoopGenerator.Generate()))
            {
                Console.WriteLine(elem);
                if (elem > 100)
                {
                    break;
                }
            }


            /*
            int n = 100;

            foreach( int elem in new EvenNumbersEnumaration(Fbonacci.Generate(n)))
            {
                Console.WriteLine(elem);
                if (elem > 100)
                {
                    break;
                }
            }
            */



            return;






            TupleOfThreeIntegers collection = new TupleOfThreeIntegers(1, 2, 3);


            foreach(int elem in collection)
            {
                Console.WriteLine(elem);
                Console.WriteLine("---------------------------");
            }

            /*equivalent to
            *****************************************
            IEnumerator<int> enumarator = collection.GetEnumerator();
            enumarator.Reset();
            while (enumarator.MoveNext())
            {
                Console.WriteLine(enumarator.Current);
            }*/




        }
    }
}
