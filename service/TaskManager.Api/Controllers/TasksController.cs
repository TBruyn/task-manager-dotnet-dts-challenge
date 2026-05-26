using Microsoft.AspNetCore.Mvc;
using TaskManager.Api.Models;

namespace TaskManager.Api.Controllers;

[ApiController]
[Route("tasks")]
public class TasksController : ControllerBase
{
    [HttpPost]
    public ActionResult<TaskItem> CreateTask([FromBody] CreateTaskRequest createTaskRequest)
    {
        var taskItem = new TaskItem{
            Id = Guid.NewGuid(),
            Title = createTaskRequest.Title,
            Description = createTaskRequest.Description,
            Status = createTaskRequest.Status,
            DueDate = createTaskRequest.DueDate
        };
        return Ok(taskItem);
    }
}