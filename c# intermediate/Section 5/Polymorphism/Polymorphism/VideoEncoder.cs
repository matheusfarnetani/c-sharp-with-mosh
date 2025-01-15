namespace Polymorphism
{

    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _channels;

        public VideoEncoder()
        {
            _channels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            // Video encoding logic
            // ...

            foreach (var channel in _channels)
                channel.Send(new Message());
        }
        
        public void RegisterNotificationChannel(in INotificationChannel channel)
        {
            _channels.Add(channel);
        }
    }
}