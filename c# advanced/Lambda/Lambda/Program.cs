namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // lambda syntax
            // args => expression
            //number => number * number

            // delegates + lambda
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));

            // () => ...
            // x => ...
            // (x, y, z) => ...

            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;

            var result = multiplier(10);
            Console.WriteLine(result);

            // return cheapest book
            var books = new BookRepository().GetBooks();

            var cheapBooks1 = books.FindAll(IsCheaperThan10Dollars);
            foreach (var book in cheapBooks1)
                Console.WriteLine(book.Title);

            var cheapBooks2 = books.FindAll(b => b.Price < 10);
            foreach (var book in cheapBooks2)
                Console.WriteLine(book.Title);
        }

        // Predicate function
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}