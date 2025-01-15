namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Mosh Hamedani ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: '{0}'", firstName);
            Console.WriteLine("LastName: '{0}'", lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: '{0}'", names[0]);
            Console.WriteLine("LastName: '{0}'", names[1]);

            Console.WriteLine(fullName.Replace("Mosh", "Moshfegh"));

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));
        }
    }
}