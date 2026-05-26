using TaskManager.Api.Models;
using TaskManager.Api.Repositories;

namespace TaskManager.Api.Services;

public class TaskService
{
    private readonly TaskRepository _taskRepository;

    public TaskService(TaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public void CreateTask(TaskItem taskItem)
    {
        _taskRepository.Save(taskItem);
    }

    public TaskItem? GetTaskById(Guid id)
    {
        return _taskRepository.GetById(id);
    }
}