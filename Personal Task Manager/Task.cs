public sealed class Task
{
	public Guid Id { get; } = Guid.NewGuid();
	public required string Title { get; set; }
	public string? Description { get; set; }
	public string? Category { get; set; }
	public TaskPriority? Priority { get; set; }
	public DateTime? DueDate { get; set; }
	public required TaskStatus Status { get; set; }

}

public sealed class TaskManager
{
	private readonly List<Task> tasks = new();

	public void Add(Task task)
	{
		tasks.Add(task);
	}

	public bool Remove(Task task)
	{
		return tasks.RemoveAll(t => t.Id == task.Id) > 0;;
	}

	public Task? GetById(Guid id)
	{
		return tasks.FirstOrDefault(t => t.Id == id);
	}

	public IReadOnlyList<Task> GetAll()
	{
		return tasks.AsReadOnly();
	}

	public IReadOnlyList<Task> GetSorted()
	{
		return tasks
			.OrderBy(t => t.DueDate ?? DateTime.MaxValue) // Tasks without a due date are sorted last
			.ThenBy(t => t.Priority ?? TaskPriority.Low) // Tasks without a priority are treated as Low
			.ThenBy(t => t.Title) // Finally, sort by title alphabetically
			.ToList();
	}
}

public enum TaskStatus
{
	Pending,
	Completed
}

public enum TaskPriority
{
	Low,
	Medium,
	High
}