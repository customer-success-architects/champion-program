using System.IO;
using System.Linq;
using Microsoft.Extensions.FileProviders;
using dotnet_app.Services;
using dotnet_app.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ITaskService, CsvTaskService>();

var app = builder.Build();

// Serve UI from wwwroot instead of external templates folder
app.UseDefaultFiles();
app.UseStaticFiles();

// Replace simple GET /tasks with optional status query
app.MapGet("/tasks", (string? status, ITaskService service) =>
{
    var tasks = service.GetAll();
    if (!string.IsNullOrEmpty(status))
        tasks = tasks.Where(t => t.Status == status);
    return Results.Ok(tasks);
});
app.MapGet("/tasks/{id}", (int id, ITaskService service) =>
    service.GetById(id) is TaskDto task ? Results.Ok(task) : Results.NotFound());
app.MapPost("/tasks", (TaskDto task, ITaskService service) =>
{
    service.Create(task);
    return Results.Created($"/tasks/{task.Id}", task);
});
// Update returns the modified task JSON instead of NoContent
app.MapPut("/tasks/{id}", (int id, TaskDto inputTask, ITaskService service) =>
{
    inputTask.Id = id;
    return service.Update(id, inputTask)
        ? Results.Ok(inputTask)
        : Results.NotFound();
});
app.MapDelete("/tasks/{id}", (int id, ITaskService service) =>
    service.Delete(id) ? Results.NoContent() : Results.NotFound());

app.Run();
