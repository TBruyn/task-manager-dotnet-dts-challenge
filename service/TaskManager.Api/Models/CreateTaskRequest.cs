namespace TaskManager.Api.Models;

public record CreateTaskRequest
{
    public required string Title { get; init; }
    public string? Description { get; init; }
    public TaskStatus Status { get; init; } = TaskStatus.Todo;
    public DateTime? DueDate { get; init; }
}