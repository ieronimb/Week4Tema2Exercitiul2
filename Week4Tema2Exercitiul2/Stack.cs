using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Tema2Exercitiul2
{
    class Stack
    //M-am inspirat din https://www.lynda.com/C-tutorials/Stack-explained/604241/636309-4.html
    {
        //Variables or fields
        private int maxSize;
        private string[] stackArray;
        private int top;

        //Assign values in Constructor
        public Stack(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1;
        }

        //Push Method
        public void push(string m)
        {
            if (isFull())
            {
                Console.WriteLine("The stack is full");
            }
            else
            {
                top++;
                stackArray[top] = m;
            }
        }
        //Pop Method
        public string pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("The stack is empty");
                return "--";
            }
            else
            {
                int oldTop = top;
                top--;
                return stackArray[oldTop];
            }
        }
        //Peek Method
        public string peek()
        {
            return stackArray[top];
        }

        public bool isEmpty()
        {
            return (top == -1);
        }

        private bool isFull()
        {
            return (maxSize - 1 == top);
        }
    }
}
