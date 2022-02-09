using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var primes = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 31 };

            var query = from val in primes where val < 13 select val;

            foreach (var val in query)
            {
                //Console.WriteLine(val);
            }

            var methodQuery = primes.Where(x => x < 13);
            foreach (var val in methodQuery)
            {
                //Console.WriteLine(val);
            }


            var query2 = from method in typeof(double).GetMethods()
                         orderby method.Name
                         group method by method.Name into groups
                         select new { MethodName = groups.Key, NumberOfOVerloads = groups.Count() };


            foreach (var val in query2)
            {
                //Console.WriteLine(val);
            }
            //Operators

            var list1 = Enumerable.Empty<int>();
            var list2 = Enumerable.Range(1,20);

            bool list1Empty = list1.Any();
            bool list2Empty = list2.Any();

            //Console.WriteLine(list2Empty +" " +  list1Empty);

            //Console.WriteLine("List 2 has 12?: " +  list2.Contains(12));
            //Console.WriteLine("List 2 has 30?: " +  list2.Contains(30));

            var big = Enumerable.Range(1,20);
            var little = big.Take(5).Select(x => x * 10);
            foreach (var val in little)
            {
                Console.WriteLine(val);
            }

            string[] ids = { "1", "2", "3" };
            string[] names = { "Joe", "Harris", "Carl" };
            var namesWithIds = ids.Zip(names, (id, name) => id + ": " + name);
            foreach (var nameWithId in namesWithIds)
            {
                Console.WriteLine(nameWithId);
            }
        }
    }
}
