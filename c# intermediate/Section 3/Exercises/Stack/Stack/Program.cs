namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine($"Stack count before clearing: {stack.Count}");

            Console.WriteLine($"Peek: {stack.Peek()}");
            Console.WriteLine($"Pop: {stack.Pop()}");
            Console.WriteLine($"Pop: {stack.Pop()}");
            Console.WriteLine($"Pop: {stack.Pop()}");
            //Console.WriteLine($"Pop: {stack.Pop()}");

            stack.Clear();

            Console.WriteLine($"Stack count after clearing: {stack.Count}");
        }
    }
}