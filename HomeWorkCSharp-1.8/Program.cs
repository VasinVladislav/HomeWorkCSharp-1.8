using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_1._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.8. Составить программу вывода на экран в одну строку четырех любых чисел с одним пробелом между ними.
            Random rnd = new Random();
            int valueOne = rnd.Next();
            int valueTwo = rnd.Next();
            int valueThree = rnd.Next();
            int valueFour = rnd.Next();
            Console.WriteLine($"{valueOne}{valueTwo} {valueThree}{valueFour}");
        }
    }
}
