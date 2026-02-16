Task addTask()
{
	string? title = null;
	string? description = null;
	string? category = null;
	TaskPriority? priority = null;
	DateTime? dueDate = null;

	void printTaskProgress(int step, string? errorMessage = null)
	{
		Console.Clear();
		char completedSymbol(int index) => index <= step ? 'x' : ' ';

		Console.WriteLine($"[{completedSymbol(1)}] Title: {title}");
		Console.WriteLine($"[{completedSymbol(2)}] Description: {description}");
		Console.WriteLine($"[{completedSymbol(3)}] Category: {category}");
		Console.WriteLine($"[{completedSymbol(4)}] Priority: {priority}");
		Console.WriteLine($"[{completedSymbol(5)}] Due Date: {dueDate}");
		Console.WriteLine();
		if (errorMessage != null)
		{
			Console.WriteLine($"Error: {errorMessage}");
		}
	}

	string? errorMessage = null;
	for (int i = 0; i <= 5; i++)
	{
		printTaskProgress(i, errorMessage);
		errorMessage = null;
		switch (i)
		{
			case 0:
				Console.Write("Enter Title: ");
				title = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(title))
				{
					errorMessage = "Title is required. Please enter a valid title.";
					i--;
				}
				break;
			case 1:
				Console.Write("Enter Description: ");
				description = Console.ReadLine();
				break;
			case 2:
				Console.Write("Enter Category: ");
				category = Console.ReadLine();
				break;
			case 3:
				Console.Write("Enter Priority (Low, Medium, High): ");
				string? priorityInput = Console.ReadLine();
				if (Enum.TryParse(priorityInput, true, out TaskPriority parsedPriority))
					priority = parsedPriority;
				else
				{
					errorMessage = "Invalid priority. Please enter Low, Medium, or High.";
					i--;
				}
				break;
			case 4:
				Console.Write("Enter Due Date (yyyy-MM-dd): ");
				string? dueDateInput = Console.ReadLine();
				if (DateTime.TryParse(dueDateInput, out DateTime parsedDueDate)) // TODO: Accept NULL as a valid input for no due date
					dueDate = parsedDueDate;
				else
				{
					errorMessage = "Invalid date format. Please enter a date in the format yyyy-MM-dd.";
					i--;
				}
				break;
			case 5:
				Console.WriteLine("Task created successfully!");
				break; ;
		}
	}
	return new Task
	{
		Title = title!,
		Description = description,
		Category = category,
		Priority = priority,
		DueDate = dueDate,
		Status = TaskStatus.Pending
	};
}

void printTask(Task task)
{
	Console.WriteLine($"Title: {task.Title}");
	Console.WriteLine($"Description: {task.Description}");
	Console.WriteLine($"Category: {task.Category}");
	Console.WriteLine($"Priority: {task.Priority}");
	Console.WriteLine($"Due Date: {task.DueDate}");
	Console.WriteLine($"Status: {task.Status}");
	Console.WriteLine();
}

List<Task> tasks = new List<Task>();
while (true)
{
	Console.WriteLine("1. Add Task");
	Console.WriteLine("2. View Tasks");
	Console.WriteLine("3. Exit");
	Console.Write("Choose an option: ");
	string? choice = Console.ReadLine();

	switch (choice)
	{
		case "1":
			Task newTask = addTask();
			tasks.Add(newTask);
			break;
		case "2":
			if (tasks.Count == 0)
			{
				Console.WriteLine("No tasks available.");
			}
			else
			{
				foreach (var task in tasks)
				{
					printTask(task);
				}
			}
			break;
		case "3":
			return;
		default:
			Console.WriteLine("Invalid option. Please choose 1, 2, or 3.");
			break;
	}
}