namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@".\folder1");
            var files = Directory.GetFiles(@"C:\Users\mathe.SOUS\OneDrive\Documentos\udemy\c# basics", "*.sln", SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);

            Console.WriteLine();

            var directories = Directory.GetDirectories(@"C:\Users\mathe.SOUS\OneDrive\Documentos\udemy\c# basics", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");

            Console.WriteLine();

            var directoryInfo = new DirectoryInfo(directories[0]);
            foreach (var file in directoryInfo.GetFiles())
                Console.WriteLine(file);

            Console.WriteLine();

            foreach (var dir in directoryInfo.GetDirectories())
                Console.WriteLine(dir);
        }
    }
}