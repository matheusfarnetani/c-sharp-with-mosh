namespace Workflow
{
    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            foreach (var activity in workflow.GetActivities())
            {
                activity.Execute();
            }
        }
    }
}
