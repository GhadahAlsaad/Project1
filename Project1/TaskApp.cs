namespace Project1
{
    public class TaskApp
    {
       public int Id {  get; private set; }
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

        private DateTime? _DueDate;
        public DateTime? DueDate
        {
            get 
            { 
                return _DueDate;//.ToString("dd - MM - yyyy") بس لازم نعمل بروبيرتي string
            }
            set
            {
                if (value.HasValue)
                {
                    if (value?.Date < DateTime.Now.Date)
                    {
                        _DueDate = null;
                    }
                    else
                    {
                        _DueDate = value;
                    }
                }
            }
        }

        public TaskApp() 
        { 
            Helper.GenerateId();
        }
    }
}
