using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Task
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
}

class Program
{
    static List<Task> tasks = new List<Task>();

    static void Main()
    {
        LoadTasksFromFile();

        bool running = true;
        while (running)
        {
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Edit Task");
            Console.WriteLine("3. Delete Task");
            Console.WriteLine("4. View Tasks for Today");
            Console.WriteLine("5. View Tasks for Tomorrow");
            Console.WriteLine("6. View Tasks for This Week");
            Console.WriteLine("7. View All Tasks");
            Console.WriteLine("8. View Pending Tasks");
            Console.WriteLine("9. View Completed Tasks");
            Console.WriteLine("10. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddTask();
                    break;
                case 2:
                    EditTask();
                    break;
                case 3:
                    DeleteTask();
                    break;
                case 4:
                    ViewTasksForToday();
                    break;
                case 5:
                    ViewTasksForTomorrow();
                    break;
                case 6:
                    ViewTasksForThisWeek();
                    break;
                case 7:
                    ViewAllTasks();
                    break;
                case 8:
                    ViewPendingTasks();
                    break;
                case 9:
                    ViewCompletedTasks();
                    break;
                case 10:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }

        SaveTasksToFile();
    }

    static void LoadTasksFromFile()
    {
        if (File.Exists("tasks.json"))
        {
            string json = File.ReadAllText("tasks.json");
            tasks = JsonConvert.DeserializeObject<List<Task>>(json);
        }
    }

    static void SaveTasksToFile()
    {
        string json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
        File.WriteAllText("tasks.json", json);
    }

    static void AddTask()
    {
        Console.Write("Enter task title: ");
        string title = Console.ReadLine();
        Console.Write("Enter task description: ");
        string description = Console.ReadLine();
        Console.Write("Enter due date (yyyy-MM-dd): ");
        DateTime dueDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);

        Task newTask = new Task { Title = title, Description = description, DueDate = dueDate };
        tasks.Add(newTask);
        Console.WriteLine("Task added successfully.");
    }

    static void EditTask()
    {
        ViewAllTasks();
        Console.Write("Enter the index of the task you want to edit: ");
        int index = Convert.ToInt32(Console.ReadLine());

        if (index >= 0 && index < tasks.Count)
        {
            Console.Write("Enter new task title: ");
            tasks[index].Title = Console.ReadLine();
            Console.Write("Enter new task description: ");
            tasks[index].Description = Console.ReadLine();
            Console.Write("Enter new due date (yyyy-MM-dd): ");
            tasks[index].DueDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);
            Console.WriteLine("Task edited successfully.");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }
    static void DeleteTask()
    {
        ViewAllTasks();
        Console.Write("Enter the index of the task you want to delete: ");
        int index = Convert.ToInt32(Console.ReadLine());

        if (index >= 0 && index < tasks.Count)
        {
            tasks.RemoveAt(index);
            Console.WriteLine("Task deleted successfully.");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    static void ViewTasksForToday()
    {
        DateTime today = DateTime.Today;
        foreach (var task in tasks)
        {
            if (task.DueDate == today)
            {
                Console.WriteLine($"{task.Title} - {task.Description} - Due Date: {task.DueDate:yyyy-MM-dd}");
            }
        }
    }

    static void ViewTasksForTomorrow()
    {
        DateTime tomorrow = DateTime.Today.AddDays(1);
        foreach (var task in tasks)
        {
            if (task.DueDate == tomorrow)
            {
                Console.WriteLine($"{task.Title} - {task.Description} - Due Date: {task.DueDate:yyyy-MM-dd}");
            }
        }
    }

    static void ViewTasksForThisWeek()
    {
        DateTime startOfWeek = DateTime.Today.AddDays((int)DateTime.Today.DayOfWeek - 1);
        DateTime endOfWeek = startOfWeek.AddDays(7);

        foreach (var task in tasks)
        {
            if (task.DueDate >= startOfWeek && task.DueDate <= endOfWeek)
            {
                Console.WriteLine($"{task.Title} - {task.Description} - Due Date: {task.DueDate:yyyy-MM-dd}");
            }
        }
    }

    static void ViewAllTasks()
    {
        foreach (var task in tasks)
        {
            Console.WriteLine($"{task.Title} - {task.Description} - Due Date: {task.DueDate:yyyy-MM-dd}");
        }
    }

    static void ViewPendingTasks()
    {
        foreach (var task in tasks)
        {
            if (task.DueDate > DateTime.Today)
            {
                Console.WriteLine($"{task.Title} - {task.Description} - Due Date: {task.DueDate:yyyy-MM-dd}");
            }
        }
    }

    static void ViewCompletedTasks()
    {
        foreach (var task in tasks)
        {
            if (task.DueDate < DateTime.Today)
            {
                Console.WriteLine($"{task.Title} - {task.Description} - Due Date: {task.DueDate:yyyy-MM-dd}");
            }
        }
    }
}
