namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
            text.FontName = "Comic Sans";
            Console.WriteLine(text.FontName);
        }
    }
}