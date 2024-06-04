using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("文字数カウント");
            Console.WriteLine("文字を入力してください");

            string text = Console.ReadLine();

            int count = text.Length;

            Console.WriteLine ("文字数 : {0}",count);
        }
    }
}
