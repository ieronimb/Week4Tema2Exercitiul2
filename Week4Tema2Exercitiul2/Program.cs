using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Tema2Exercitiul2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack newStack = new Stack(5);
            newStack.push("Constantin");
            newStack.push("Elena");
            newStack.push("Dumitru");
            newStack.push("Ieronim");
            newStack.push("Andreea");
            Console.WriteLine("\n");

            //Push next row (from end to top)
            Console.WriteLine(newStack.peek() + " name is at the top o the stack");

            //Pop
            while (!newStack.isEmpty())
            {
                string names = newStack.pop();
                Console.WriteLine("The name is {0}", names);
            }
        }
    }
}
