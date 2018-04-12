using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
           
            List<int> numbers = new List<int>();
            for (int i=1;i<=42;i++) 
            {
                numbers.Add(i);
            }
            for (int a = 0; a < 6; a++)
            {
                 int r = rand.Next(1, 43);
                 Console.WriteLine(numbers [r]+"");
                numbers.RemoveAt(r);
            }
           
           
            Console.ReadKey();
        }
    }
}
