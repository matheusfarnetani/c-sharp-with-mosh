namespace FileAndFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @".\newText.txt";
            File.Delete(path);
            File.Copy(@".\text.txt", @".\newText.txt", true);

            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);
            Console.WriteLine(content);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }
        }
    }
}