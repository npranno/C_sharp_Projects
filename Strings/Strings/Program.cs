using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "nick";
            //string quote = "the man said \"hello\", Nick.\nHow are you?\n \t Good!";
            ////for files
            //string file = @"C:\Users\npran";

            //bool trueOrFalse = name.Contains("nick");
            //trueOrFalse = name.EndsWith("b");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(name);
            //Console.WriteLine(length);
            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(quote);
            //Console.ReadLine();

            //string name = "Nick";
            //name = "Joe";

            StringBuilder sb = new StringBuilder();

            sb.Append("my name is nick");

            Console.WriteLine(sb);
            Console.ReadLine();
            
        }
    }
}
