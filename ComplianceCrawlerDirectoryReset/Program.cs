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
            List<string> list = new List<string>() { "x/", "../", "./", "y/", "y/", "../", "z/", "./", "x/", "../", "./", "y/", "y/", "../", "./", "y/", "y/", "y/", "y/", "y/", "y/", "adil/" }; ;
            int adim=minimumSteps(list);
            
            Console.WriteLine(adim);
            Console.ReadKey();
        }

        public static int minimumSteps(List<string> loggedMoves)
        {
            int adim = 0;
            for (int i = 0; i < loggedMoves.Count; i++)
            {
                if (loggedMoves[i] == "../")
                {
                    adim--;
                }
                else if (loggedMoves[i] =="./")
                {
                    adim = adim;
                }
                else
                {
                    adim++;
                }
            }
            return adim;
        }
    }
}
