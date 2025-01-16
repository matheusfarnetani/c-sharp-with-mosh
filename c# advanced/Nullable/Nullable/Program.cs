namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<DateTime> date = null;
            DateTime? date = null;

            Console.WriteLine($"{date.GetValueOrDefault()}");
            //Console.WriteLine($"{date.HasValue()}");
            //Console.WriteLine($"{date.Value()}");

            date = new DateTime(2014, 1, 1);
            DateTime date2 = date.GetValueOrDefault();

            Console.WriteLine(date2);

            DateTime? date3 = date2;
            Console.WriteLine(date3.GetValueOrDefault());

            // Null Coalescing Operators
            DateTime? d1 = null;
            //DateTime d2;
            //if (d1 != null)
            //    d2 = date.GetValueOrDefault();
            //else
            //    d2 = DateTime.Today;]
            DateTime d2 = d1 ?? DateTime.Today; // shorten way of writing comments
            DateTime d3 = (d1 != null) ? d1.GetValueOrDefault(): DateTime.Today; // same as above, but bigger

            Console.WriteLine(d2);
        }
    }
}