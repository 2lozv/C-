using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("High&Lowゲーム");

            Console.WriteLine("");

            Chara me = new Chara("ふうか");
            me.show();

            Console.WriteLine("");

            Console.WriteLine("Start!");

            int score = 0;

            while (true)
            {
                score++;

                Console.WriteLine("");

                //最初の数字を表示
                Random rnd = new Random();
                int num = rnd.Next(1, 14);
                Console.WriteLine("↑↑↑↑↑ {0} ↓↓↓↓↓", num);

                Console.WriteLine("");

                Console.WriteLine("High? Low?");

                Console.WriteLine("");

                //入力内容を待つ
                Console.WriteLine("1→High　2→Low");

                Console.WriteLine("");

                me.Number = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                //入力内容を確認
                me.show(me.Name, me.Number);

                Console.WriteLine("");

                Console.WriteLine("数字を表示");
                Console.ReadKey();

                Console.WriteLine("");

                Random rnd2 = new Random();
                int num2 = rnd2.Next(1, 14);
                Console.WriteLine("【{0}】", num2);

                Console.WriteLine("");

                //条件分岐
                if (num == num2)
                {
                    Console.WriteLine("DRAW");
                    continue;
                }
                else if (num < num2)
                {
                    if (me.Number == 1)
                    {
                        Console.WriteLine("High 正解です！");
                    }
                    else
                    {
                        Console.WriteLine("High 選択ミス！ゲーム終了");
                        break;
                    }
                }
                else if (num > num2)
                {
                    if (me.Number == 2)
                    {
                        Console.WriteLine("Low 正解です！");
                    }
                    else
                    {
                        Console.WriteLine("Low ミス！ゲーム終了");
                        break;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("{0}のスコア:{1}点", me.Name,score);
            
        }
    }
}
