namespace StackOverflowPost
{
    partial class Program
    {
        class StackOverflowPost
        {
            // Properties
            public string Title { get; private set; }
            public string Author { get; set; }
            public string Description { get; set; }
            public DateTime CreatedAt { get; private set; }
            public int Votes { get; private set; }
            public int Views { get; private set; }
            readonly public List<string> _comments;

            public StackOverflowPost(string title, DateTime createdAt, int votes = 0, int views = 0)
            {
                // Check inputs
                if (string.IsNullOrWhiteSpace(title))
                    throw new ArgumentException("Title cannot be null or empty");
                if (createdAt > DateTime.Now)
                    throw new ArgumentException("Creation date cannot be in the future.");

                this.Title = title;
                this.CreatedAt = createdAt;
                this.Votes = votes;
                this.Views = views;
                _comments = new List<string>();
            }

            // Increment Views
            public void View()
            {
                Views++;
            }

            // Up-vote method
            public void UpVote()
            {
                Votes++;
            }

            // Dow-vote method
            public void DownVote()
            {
                Votes--;
            }

            public void AddComment(string comment)
            {
                if (string.IsNullOrWhiteSpace(comment))
                    throw new ArgumentException("Comment cannot be null or empty.");

                _comments.Add(comment);
            }

            public void DisplayComments()
            {
                if (_comments.Count == 0)
                {
                    Console.WriteLine("No comments yet.");
                    return;
                }

                Console.WriteLine("Comments:");
                foreach (var comment in _comments)
                {
                    Console.WriteLine($"- {comment}");
                }
            }

            public override string ToString()
            {
                return $"Post Title: {Title}\nCreated At:{CreatedAt}\nVotes:{Votes}\nViews: {Views}";
            }
        }
    }
}