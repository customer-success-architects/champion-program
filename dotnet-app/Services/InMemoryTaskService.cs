namespace dotnet_app.Services
{
    using System.Collections.Concurrent;
    using dotnet_app.Models;

    public class InMemoryTaskService : ITaskService
    {
        private readonly ConcurrentDictionary<int, TaskDto> _tasks = new();
        private int _nextId = 1;

        public IEnumerable<TaskDto> GetAll() => _tasks.Values;

        public TaskDto? GetById(int id) => _tasks.TryGetValue(id, out var task) ? task : null;

        public void Create(TaskDto task)
        {
            var id = System.Threading.Interlocked.Increment(ref _nextId);
            task.Id = id;
            _tasks[id] = task;
        }

        public bool Update(int id, TaskDto updatedTask)
        {
            if (!_tasks.ContainsKey(id)) return false;
            updatedTask.Id = id;
            _tasks[id] = updatedTask;
            return true;
        }

        public bool Delete(int id) => _tasks.TryRemove(id, out _);
    }
}
