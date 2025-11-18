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
                    Console.WriteLine("Invalid name");
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
                    Console.WriteLine("Invalid email");
                }
                else
                {
                    _Email = value;
                }
            }
        }

        public List<TaskApp> Tasks { get; set; } = new List<TaskApp>();
        public List<User> Users { get; set; } = new List<User>();

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void AddUserTask(TaskApp task)
        {
            Tasks.Add(task);
        }

        public void RemoveUserTask(int taskId)
        {
            var task = Tasks.FirstOrDefault(x => x.Id == taskId);
            if (task != null)
            {
                Tasks.Remove(task);
            }
        }

        public List<TaskApp> GetActiveUserTasks()
        {
            return Tasks.Where(x => x.Status != Status.Done.ToString()).ToList();
        }
    }
}
