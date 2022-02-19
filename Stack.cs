using System;

namespace StackTask
{
    public class Stack<T>
    {
        T[] Stacklist;
        int top = 0;
        int Size;
        public Stack(int Size)
        {
            this.Size = Size;
            Stacklist = new T[Size];
        }
        public void Push(T Item)
        {
            if (IsFullStack())
            {
                Console.WriteLine("Stack is Full");

            }
            else
            {
                Stacklist[top] = Item;
                top++;
                Console.WriteLine($"You have Pushed the Item: {Item} to the Stack");
            }
           
        }

        public T Pop()
        {
            if (IsEmptyStack())
            {
                Console.WriteLine("Stack is Empty");
                return default(T);
            }
            else
            {
                top--;
                Console.WriteLine($"You have Poped one Item from the Stack");
                return Stacklist[top];
            }
            

        }

        public void Print()
        {
            if (IsEmptyStack())
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("The Stack Items is:");
                for (int i = 0; i < top; i++)
                {
                    Console.WriteLine(Stacklist[i]);
                }

            }

        }

        public T Peak()
        {
            if (IsEmptyStack())
            {
                Console.WriteLine("Stack is Empty");
                return default(T);
            }
            else
            {
                Console.WriteLine($"You have Peak one Item from the Stack");
                return Stacklist[top - 1];
            }
        }

        public void Clear()
        {
            top = 0;
            Console.WriteLine($"You have cleared the Stack");

        }

        private bool IsFullStack()
        {
            return top == Size;
        }
        private bool IsEmptyStack()
        {
            return top == 0;
        }
    }
}
