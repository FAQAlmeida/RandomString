using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomString
{
    class Dicionario
    {
        private static Dictionary<int, string> dict = new Dictionary<int, string>();       
        
        public void Init()
        {
            dict.Add(0, "a");
            dict.Add(1, "b");
            dict.Add(2, "c");
            dict.Add(3, "d");
            dict.Add(4, "e");
            dict.Add(5, "f");
            dict.Add(6, "g");
            dict.Add(7, "h");
            dict.Add(8, "i");
            dict.Add(9, "j");
            dict.Add(10, "k");
            dict.Add(11, "l");
            dict.Add(12, "m");
            dict.Add(13, "n");
            dict.Add(14, "o");
            dict.Add(15, "p");
            dict.Add(16, "q");
            dict.Add(17, "r");
            dict.Add(18, "s");
            dict.Add(19, "t");
            dict.Add(20, "u");
            dict.Add(21, "v");
            dict.Add(22, "w");
            dict.Add(23, "x");
            dict.Add(24, "y");
            dict.Add(25, "z");
        }

        public string RChar(int a, int b)
        {
            if (b == 0)
            {
                return dict[a];
            }
            else //if(b == 1)
            {
                return dict[a].ToUpper();
            }
        }
    }
}
