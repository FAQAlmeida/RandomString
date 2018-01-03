using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da string: ");
            string str = Console.ReadLine();
            if (int.TryParse(str, out int g))
            {
                MkString ms = new MkString();
                
                str = ms.MakeString(Convert.ToInt32(str));
                Console.WriteLine(str);
                using (StreamWriter outputFile = new StreamWriter(@"C:\Users\otavi\Desktop\RandomString\WriteLines.txt"))
                {
                    foreach (char ch in str)
                        outputFile.Write(ch);
                }
            }
            Console.ReadKey();
        }
    }
}
