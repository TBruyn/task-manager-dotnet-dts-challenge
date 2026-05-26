using System.Collections.Concurrent;
using TaskManager.Api.Models;

namespace TaskManager.Api.Repositories;

public class TaskRepository
{
    private readonly ConcurrentDictionary<Guid, TaskItem> _tasks = [];

    public void Save(TaskItem taskItem)
    {
        _tasks[taskItem.Id] = taskItem;
    }

    public TaskItem? GetById(Guid id)
    {
        return _tasks.GetValueOrDefault(id);
    }

    public IReadOnlyCollection<TaskItem> GetAll()
    {
        return [.. _tasks.Values];
    }
}