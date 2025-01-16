namespace LINQ
{
    // Stands for: Language Integrated Query

    // You can Query
    // • Objects in memory, eg collection (LINQ to objects)
    // • Databases (LINQ to Entities)
    // • XML (LINQ to XML)
    // • ADO.NET Data Sets (LINQ to Data Sets)
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if (book.Price < 10)
            //        cheapBooks.Add(book);
            //}

            // LINQ Extension Methods
            var cheapBooks = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title);

            var stringCheapBooks = cheapBooks
                .Select(b => b.Title);

            foreach (var book in cheapBooks)
                Console.WriteLine($"{book.Title} {book.Price}");
            Console.WriteLine();
            foreach (var book in stringCheapBooks)
                Console.WriteLine(book);

            // LINQ Query Operators
            var cheaperBooksQuery = from b in books
                                    where b.Price < 10
                                    orderby b.Title
                                    select b.Title;

            Console.WriteLine();
            foreach (var book in cheaperBooksQuery)
                Console.WriteLine(book);

            // Other example
            var linqBook1 = books.Single(b => b.Title == "ASP.NET MVC");
            var linqBook2 = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");
            var linqBook3 = books.First(b => b.Title == "C# Advanced Topics");
            var linqBook4 = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");
            var linqBook5 = books.Skip(2).Take(3);
            var count = books.Count();
            var max = books.Max(b => b.Price);
            var min = books.Min(b => b.Price);
            var sum = books.Sum(b => b.Price);
            var avrg = books.Average(b => b.Price);

            Console.WriteLine();
            Console.WriteLine(linqBook1.Title);
            Console.WriteLine(linqBook2 == null);
            Console.WriteLine(linqBook3.Title);
            Console.WriteLine(linqBook4.Price);
            foreach (var book in linqBook5)
                Console.WriteLine($"Title: {book.Title} - Price: {book.Price}");
            Console.WriteLine($"Total of {count} books.");
            Console.WriteLine($"The heighest price is ${max}");
            Console.WriteLine($"The chepeast price is ${min}");
            Console.WriteLine($"The total price is ${sum}");
            Console.WriteLine($"The average price is ${avrg}");

            /*
             * .Where();
             * .Single();
             * .SingleOrDefault();
             * 
             * .First();
             * .FirstOrDefault();
             * .LastorDefault();
             * 
             * .Min();
             * .Max();
             * .Count();
             * .Sum();
             * .Average();
             * 
             * .Skip();
             * .Take();
             * */
        }
    }
}