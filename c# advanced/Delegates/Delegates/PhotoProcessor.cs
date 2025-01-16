namespace Delegates
{
    public class PhotoProcessor
    {
        public void Process(string path, Action<Photo> filterHandler)
        {
            // Action returns void and Func return value
            //System.Action<>
            //System.Func<>

            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}