using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplianceCrawlerDirectoryReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "x/","../","y/","z/"};
            int adim=minimumSteps(list);
            
            Console.WriteLine(adim);
            Console.ReadKey();
        }

        public static int minimumSteps(List<string> loggedMoves)
        {
            int adim = 0;
            for (int i = 1; i < loggedMoves.Count; i++)
            {
                if (loggedMoves[i] != "./")
                {
                    adim++;
                }
            }
            adim--;
            return adim;
        }
    }
}
