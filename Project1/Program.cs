using Project1;

var user1 = new User()
{
    Id = 1,
    Name = "ghadah",
    Email = "ghadahalsaad3@gmail.com"
};
Console.WriteLine($"Id : {user1.Id}, Name : {user1.Name}, Email : {user1.Email}");

var task1 = new TaskApp()
{
    Title = "Test1",
    Description = "Test1",
    DueDate = DateTime.Now,
    Status = Project1.Status.Pending.ToString()
};
var task2 = new TaskApp()
{
    Title = "Test2",
    Description = "Test2",
    DueDate = DateTime.Now,
    Status = Project1.Status.Pending.ToString()
};
var task3 = new TaskApp()
{
    Title = "Test3",
    Description = "Test3",
    DueDate = DateTime.Now,
    Status = Project1.Status.Pending.ToString()
};

user1.AddUserTask(task1);
user1.AddUserTask(task2);
user1.AddUserTask(task3);
user1.RemoveUserTask(task1.Id);
user1.MarkAsDone(task2.Id);
var activeTask = user1.GetActiveUserTasks();

string title = "";
var status = Status.Done;
var searchResult = user1.Search(title, status);

