using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReplacement
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            string word = "??c???er";
            string substr = "deciph";
            string result = getSmallestString(word, substr);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static string getSmallestString(string word, string substr)
        {
            string result = null;
            List<int> index = new List<int>();

            char[] cword = word.ToCharArray();
            char[] csub = substr.ToCharArray();

            //hangi indexlerin ? olduğu bulunur
            for (int i = 0; i < cword.Length; i++)
            {
                if (cword[i] == '?')
                {
                    index.Add(i);
                }
            }

            for (int j = 0; j < cword.Length; j++)
            {
                for (int z = 0; z < csub.Length; z++)
                {
                    if (cword[j] == csub[z])
                    {
                        Array.Clear(cword, index[0], index.Count + 1);
                        Array.Copy(csub, cword, index.Count + 1);
                        result = new string(cword);
                        //todo break ten sonra for dan direkt çıkması lazım
                        break;
                    }
                    //else
                    //{
                    //    result = "-1";
                    //}
                }
            }
            return result;
        }
    }
}
