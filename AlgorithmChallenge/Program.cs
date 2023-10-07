using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> price = new List<int>() { 2};
            List<int> query = new List<int>() { 8,4,3,10,6 };
            List<long> list = countMinimumOperations(price, query);
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public static List<long> countMinimumOperations(List<int> price, List<int> query)
        {
            int result = 0;
            List<long> list = new List<long>();

            for (int i = 0; i < query.Count; i++)
            {
                foreach (int item in price)
                {
                    result += Math.Abs(query[i] - item);
                }

                list.Add(result);
                result = 0;
            }

            return list;
        }

    }
}
