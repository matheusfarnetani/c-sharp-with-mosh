namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("byte to int");

            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            Console.WriteLine("\nint to byte");

            //int c = 1;
            int c = 1000; // data loss (byte maximun is 255)
            byte j = (byte)c;
            Console.WriteLine(j);

            Console.WriteLine("\nstring to bytes");

            string number = "1234";
            //var number = "1234";
            int z = Convert.ToInt32((string)number);
            Console.WriteLine(z);
            try
            {
                int z2 = Convert.ToByte((string)number);
                Console.WriteLine(z2);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            Console.WriteLine("\nstring to boolean");

            string str = "true";
            try
            {
                bool bo = Convert.ToBoolean((string)str);
                Console.WriteLine(bo);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }
        }
    }
}