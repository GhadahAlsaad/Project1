namespace Project1
{
    public class WorkTask : TaskApp
    {
        public string Company;
        public List<TaskApp> Tasks { get; set; } = new List<TaskApp>();

        public override void MarkAsDone()
        {
            if (Status == Project1.Status.Done.ToString())
            {
                Console.WriteLine("Task already done.");
                return;
            }
            Status = Project1.Status.Done.ToString();
        }

        public override void AddTask(TaskApp task)
        {
            Tasks.Add(task);
        }

        public override string ListAllTasks()
        {
           
        }
    }
}
