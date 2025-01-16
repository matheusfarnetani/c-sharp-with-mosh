namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "Mosh";
            //obj.GetHashCode();

            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);

            // be familiar with CLR
            // DLR sits above CLR
            dynamic excelObject = "mosh";
            excelObject.Optimize();

            dynamic name = "Mosh";
            name = 10;

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b; // c is also dynamic

            int i = 5;
            dynamic d = i; // at run time d will be an integer
            long l = d; // at run time we can put an integer in a long

        }
    }
}