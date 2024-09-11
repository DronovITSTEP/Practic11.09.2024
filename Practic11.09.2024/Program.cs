using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic11._09._2024
{
    internal class Program
    {
        static void Swap(ref int i,ref int j)
        {
            int temp = i; 
            i = j; 
            j = temp;
        }
        static void Swap2(out int i, out int j)
        {
            i = 5;
            j = 3;
            int temp = i;
            i = j;
            j = temp;
        }

        /*static void Print(int n)
        {
            Console.WriteLine(n);
        }
        static void Print(int n, int n2)
        {
            Console.WriteLine(n);
            Console.WriteLine(n2);
        }*/
        static void Print(params int[] n)
        {
            foreach (int i in n) 
                Console.Write(i);
        }

        static void Main(string[] args)
        {
            /*Example expl = new Example(45);         
            Console.WriteLine(expl.Sum2());
            Console.WriteLine(expl.Sum());
            Console.WriteLine(expl.Num);
            Console.WriteLine(expl.Str);

            Маркер маркер = new Маркер();
            Маркер маркер2 = new Маркер("красный");
            Маркер маркер3 = new Маркер(5);
            маркер.Show();
            Console.WriteLine(маркер.Цвет);
            Console.WriteLine(маркер2.Цвет);
            Console.WriteLine(маркер3.Цвет);*/

            /*int i;
            int j;
            Swap(ref i, ref j);
            Swap2(out i, out j);
            Console.WriteLine($"i = {i},j = {j} ");*/

            /* int n = 0;
             string str;
             str = Console.ReadLine();
             bool flag = true;
             foreach (char c in str) {
                 if (char.IsLetter(c)) {
                     flag = false;
                 }
             }
             if (flag){
                 n = int.Parse(str);
                 Console.WriteLine(n);
            }*/

            /* int n;
             if (int.TryParse(Console.ReadLine(),out n))
             {
                 Console.WriteLine(n);
             }*/
            //ref, out;
            Random random = new Random(6);
            int t = random.Next();
            Console.WriteLine(t);
        }
    }
}
