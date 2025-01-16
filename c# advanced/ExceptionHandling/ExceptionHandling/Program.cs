namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            try
            {
                var result = calculator.Divide(5, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Can't divide by zero:\n\n\"{ex}\"");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine($"Sorry, an unexpected error occurred:\n\n\"{ex}\"");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Sorry, an unexpected error occurred:\n\n\"{ex}\"");
            }

            // remeber to close/dispose openfiles/connections/etc
            //StreamReader streamReader = null;
            //try
            //{
            //    streamReader = new StreamReader(@"c:\file.zip");
            //    var content = streamReader.ReadToEnd();
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"\n\nSorry, an unexpected error occurred:\n\n\"{ex}\"");
            //}
            //finally
            //{
            //    if (streamReader != null)
            //        streamReader.Dispose();
            //}

            try
            {
                using (var streamReader = new StreamReader(@"c:\file.zip"))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"\n\nSorry, an unexpected error occurred:\n\n\"{ex}\"");
            }

            var api = new YouTubeApi();
            try
            {
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"\n\nSorry, an unexpected error occurred:\n\n\"{ex.Message}\n{ex.InnerException}\"");
            }
        }
    }
}