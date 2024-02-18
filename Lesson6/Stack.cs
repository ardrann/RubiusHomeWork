using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    internal class Stack<T>
    {
        public List<T> Elements = new List<T>();

        public void Push(T element)
        {
            Elements.Add(element);
        }

        public bool IsEmpty()
        {
            if (Elements.Count == 0)
                return true;
            else
                return false;
        }

        public T Pop() 
        {
            if (!IsEmpty())
            {
                var lastElement = Elements.Last();
                Elements.Remove(lastElement);
                return lastElement;
            }
            else
            {
                Console.WriteLine("Стек пуст. Вы не можете удалять элементы");
                return default(T);
            }
        }

        public T Peek()
        {
            if (!IsEmpty())
            {
                var lastElement = Elements.Last();
                return lastElement;
            }
            else
            {
                Console.WriteLine("Стек пуст. Вы не можете удалять элементы");
                return default(T);
            }
        }
        
        public void Clear()
        {
            Elements.Clear();
            Console.WriteLine("Стек очищен");
        }

        public override string ToString()
        {
            if (!IsEmpty())
            {   
                StringBuilder answer = new StringBuilder();
                answer.Append("Элементы в стеке по порядку: ");
                foreach (var element in Elements)
                {
                    answer.Append($"{element}; ");
                }
                return answer.ToString();
            }
            else 
            {
                return "Стек пуст.";
            }
        }
    }
}
