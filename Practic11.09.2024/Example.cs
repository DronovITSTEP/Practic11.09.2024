using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Practic11._09._2024
{
    partial class Example
    {
        int n, a, b;
        public int Num { get; set; }
        public Example(int n): this(n, 0, 0){}
        public Example(int n, int b, int a)
        {
            this.n = n;
            this.a = a;
            this.b = b;
        }
        public Example(): this(0,0,0){}
        public int Sum2()
        {
            return Num + 10;
        }
    }
    partial class Example
    {
        private int _num;
        public int Sum()
        {
            return _num + 10;
        }
    }
    class Маркер
    {
        public string Цвет { get; set; }
        public Маркер()
        {
            Цвет = "черный";
        }
        public Маркер (string text)
        {
            Show(text);
        }
        public void Show(int height, int width, string text)
        {}
        public void Show(string text)
        {
            Цвет = text;
        }
        public void Show()
        {
            Цвет = Console.ReadLine();
        }
    }
}
