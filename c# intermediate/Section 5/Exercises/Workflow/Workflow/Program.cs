using System;

namespace Workflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.AddActivity(new UploadVideoActivity());
            workflow.AddActivity(new CallVideoEncodingServiceActivity());
            workflow.AddActivity(new NotifyOwnerActivity());
            workflow.AddActivity(new UpdateVideoStatusActivity());

            var engine = new WorkflowEngine();
            engine.Run(workflow);
        }
    }
}