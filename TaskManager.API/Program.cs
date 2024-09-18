using Microsoft.EntityFrameworkCore;
using ReportsWebApi.Filters;
using TaskManager.Domain.Services;
using TaskManager.Storage;
using TaskManager.Storage.Repositories;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Mssql");
builder.Services.AddDbContext<TaskManagerContext>(options => options
    .UseSqlServer(connectionString));

builder.Services.AddScoped<ITaskRepository, TaskRepository>();
builder.Services.AddScoped<IFileRepository, FileRepository>();
builder.Services.AddScoped<ITaskService, TaskService>();
builder.Services.AddScoped<IFileService, FileService>();

builder.Services.AddControllers(options =>
{
    options.Filters.Add<Filter>();
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
