using System.Reflection;

namespace StackOverflowPost
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var post = new StackOverflowPost("Classes", DateTime.Now);
            Console.WriteLine(post);

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.DownVote();

            Console.WriteLine(post);

            post.DisplayComments();

            post.AddComment("Great post!");
            post.AddComment("Very helpful, thanks!");

            post.DisplayComments();
        }
    }
}