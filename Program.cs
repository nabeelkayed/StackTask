using System;

namespace StackTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int?> f = new Stack<int?>(100);

            f.Push(1);
            f.Push(2);

            f.Pop();
            int? x = f.Peak();
            if (!x.HasValue)
            {
                Console.WriteLine("The Peak operation fail because the stack is empty");
            }

            f.Push(3);
            f.Push(4);

            f.Pop();
            f.Peak();

            f.Push(5);
            f.Push(6);

            f.Pop();
            f.Peak();

            f.Push(7);
            f.Push(8);

            f.Pop();
            f.Peak();

            f.Push(9);
            f.Push(10);

            f.Pop();
            f.Peak();

            f.Print();

            f.Clear();
            f.Print();

            int? y = f.Peak();
            if (!y.HasValue)
            {
                Console.WriteLine("The Peak operation fail because the stack is empty");
            }

        }
    }
}
