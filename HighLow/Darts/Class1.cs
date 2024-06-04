using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    public class Chara
    {
        //フィールドの定義
        protected string name;
        protected int number;

        //コンストラクタ設定
        public Chara(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
        public int Number
        {
            set { number = value; }
            get { return number; }
        }

        public void show()
        {
            Console.WriteLine("こんにちは{0}さん", this.name);
        }

        public void show(string name, int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("{0}はHigh選択しました", name);
                    break;

                case 2:
                    Console.WriteLine("{0}はLowを選択しました", name);
                    break;
            }

        }

        //public int num()
        //{
        //    Random rnd = new Random();
        //    int num = rnd.Next(1, 14);
        //    return num;
        //}
    }
}