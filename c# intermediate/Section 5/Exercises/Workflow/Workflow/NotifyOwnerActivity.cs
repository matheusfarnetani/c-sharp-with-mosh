namespace Workflow
{
    public class NotifyOwnerActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending email to the video owner...");
        }
    }
}
