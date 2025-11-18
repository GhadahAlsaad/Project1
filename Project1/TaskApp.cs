namespace Project1
{
    public abstract class TaskApp
    {
       public int Id { get; set; }
        public string Status { get; set; }

        private string _Title;
        public string Title
        {
            get
            {
                return _Title;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _Title = "NO Title";
                }
                else
                {
                    _Title = value;
                }
            }
        }
        public string Description { get; set; }

        public DateTime? _DueDate;
        public DateTime? DueDate
        {
            get 
            { 
                return _DueDate; 
            }
            set
            {
                if (value < DateTime.Today)
                {
                    _DueDate = null;
                }
                else
                {
                    _DueDate = value;
                }
            }
        }

        public string GetFormattedDate()
        {
            return _DueDate?.ToString("dd - MM - yyyy");
        }
        public abstract void MarkAsDone();
        public abstract void AddTask(TaskApp task);
        public abstract string ListAllTasks();
    }
}
