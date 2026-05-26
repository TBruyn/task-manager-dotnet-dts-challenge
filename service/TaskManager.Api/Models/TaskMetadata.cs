namespace TaskManager.Api.Models;

public record TaskMetadata
{
    public Guid Id { get; init; }
    public required string Title { get; init; }
    public TaskStatus Status { get; init; }
    public DateTime? DueDate { get; init; }

    public static TaskMetadata FromTaskItem(TaskItem task)
    {
        return new TaskMetadata
        {
            Id = task.Id,
            Title = task.Title,
            Status = task.Status,
            DueDate = task.DueDate
        };
    }
}