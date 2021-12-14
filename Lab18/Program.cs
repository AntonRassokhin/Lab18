using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку со скобками:");
            string inputString = Convert.ToString(Console.ReadLine());
            char[] arrayString = inputString.ToArray();

            Stack<char> stack = new Stack<char>();
            stack.Push('0'); //иначе при попытке ввести сначала закрытую скобку - 38 строка ругается на пустой стэк

            foreach (char a in arrayString)
            {
                if (a == '(')
                {
                    stack.Push(')');
                }

                if (a == '{')
                {
                    stack.Push('}');
                }

                if (a == '[')
                {
                    stack.Push(']');
                }

                if (a == stack.Peek())
                {
                    stack.Pop();
                }
            }

            stack.Pop(); //удаляем первый введенный '0'

            if (stack.Count == 0)
            {
                Console.WriteLine("Строка корректна.");
            }
            else
            {
                Console.WriteLine("Строка не корректна.");    
            }



            Console.ReadKey();


        }
    }
}
