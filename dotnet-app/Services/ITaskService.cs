namespace dotnet_app.Services
{
    using dotnet_app.Models;
    using System.Collections.Generic;

    public interface ITaskService
    {
        IEnumerable<TaskDto> GetAll();
        TaskDto? GetById(int id);
        void Create(TaskDto task);
        bool Update(int id, TaskDto updatedTask);
        bool Delete(int id);
    }
}
