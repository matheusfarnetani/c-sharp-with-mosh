namespace ExceptionHandling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access YouTube web service
                // Read the data
                // Create a list of Video objects
                throw new Exception("Opps some low leve Youtube error."); // Simulate
            }
            catch (Exception ex)
            {
                throw new YouTubeException("Could not fetch the videos from YouTube.", ex); // Log
            }

            return new List<Video>();
        }
    }
}