using Microsoft.AspNetCore.Mvc;
using TaskManager.Api.Models;
using TaskManager.Api.Services;

namespace TaskManager.Api.Controllers;

[ApiController]
[Route("tasks")]
public class TasksController : ControllerBase
{
    private readonly TaskService _taskService;

    public TasksController(TaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpPost]
    public ActionResult<TaskItem> CreateTask([FromBody] CreateTaskRequest createTaskRequest)
    {
        var taskItem = new TaskItem
        {
            Id = Guid.NewGuid(),
            Title = createTaskRequest.Title,
            Description = createTaskRequest.Description,
            Status = createTaskRequest.Status,
            DueDate = createTaskRequest.DueDate
        };

        _taskService.CreateTask(taskItem);

        return CreatedAtAction(
            nameof(GetTaskById),
            new { id = taskItem.Id },
            taskItem
        );
    }

    [HttpGet("{id}")]
    public ActionResult<TaskItem> GetTaskById(Guid id)
    {
        TaskItem? task = _taskService.GetTaskById(id);
        if (task is null)
        {
            return NotFound();
        }
        return Ok(task);
    }
}