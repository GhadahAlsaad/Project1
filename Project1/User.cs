namespace Project1
{
    public class User
    {
        public int Id { get; set; }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if (value.Length < 3)
                {
                    _Name = "Invalid name";
                }
                else
                {
                    _Name = value;
                }
            }
        }
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set
            {
                if (!value.Contains("@") || !value.Contains("."))
                {
                    _Email = "Invalid email";
                }
                else
                {
                    _Email = value;
                }
            }
        }
        public List<TaskApp> Tasks { get; set; } = new List<TaskApp>();
        public List<User> Users { get; set; } = new List<User>();

        
        public void AddUserTask(TaskApp task)
        {
            Tasks.Add(task);
        }

        public void RemoveUserTask(int taskId)
        {
            Tasks.RemoveAll(x => x.Id == taskId);
        }

        public List<TaskApp> GetActiveUserTasks()
        {
            return Tasks.Where(x => x.Status != Status.Done.ToString()).ToList();
        }
        public void MarkAsDone(int taskId)
        {
            var task = Tasks.First(x => x.Id == taskId);
            if (task.Status == Project1.Status.Done.ToString())
            {
                Console.WriteLine("Invalid..Task is already done.");
                return;
            }
            task.Status = Project1.Status.Done.ToString();
        }

        public List<TaskApp> Search(string title, Status? status)
        {
            var result = Tasks.Where(x=> (string.IsNullOrEmpty(title)? x.Title.Contains(title.Trim().ToLower()) : true) 
            && (status.HasValue ? x.Status == status.ToString() : true)).ToList();
            return result;
        }
    }
}
