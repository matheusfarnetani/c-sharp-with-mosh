using CSharpFundamentals.Math;

namespace CSharpFundamentals
{

    class Program
    {
        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }

        static void Main(string[] args)
        {
            //classes
            Console.WriteLine("Classes");
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            //static methods
            var result = calculator.Add(5, 10);
            Console.WriteLine(result);


            //arrays
            Console.WriteLine("\nArrays");
            var numbers = new int[3] { 1, 2, 3 };
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "Jack", "John", "Mary" };

            //strings
            Console.WriteLine("\nStrings");

            var firstName = "Mosh";
            var lastName = "Hamedani";

            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);

            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);

            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);
            var text2 = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";

            Console.WriteLine(text2);

            //enums
            Console.WriteLine("\nenums");

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);

            //reference types and value types
            Console.WriteLine("\nReference types and Value types");

            //value types
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            //reference types
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;

            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

            var num = 1;
            Increment(num);
            Console.WriteLine(num);

            var person = new Person2() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int num)
        {
            num += 10;
        }

        public static void MakeOld(Person2 person)
        {
            person.Age += 10;
        }
    }
}