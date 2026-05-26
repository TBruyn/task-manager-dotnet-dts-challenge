namespace TaskManager.Api.Models;

public class TaskItem
{
    public Guid Id {get; set;}
    public DateTime CreatedAt {get; set;} = DateTime.Now;
    public required string Title {get; set;}
    public string? Description {get; set;}
    public TaskStatus Status {get; set;} = TaskStatus.Todo;
    public DateTime? DueDate {get; set;}

}