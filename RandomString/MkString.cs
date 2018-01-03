using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomString
{
    class MkString
    {
        Dicionario dict = new Dicionario();
        Random rnd = new Random();
        Random rnd2 = new Random();
        public string MakeString(int i)
        {
            dict.Init();
            string str = "";
            int g;
            for(int j = 0; j <= i; j++)
            {
                Console.WriteLine(j);
                str += dict.RChar(rnd.Next(0,26), rnd2.Next(0,2));
            }
            return str;
        }
    }
}
