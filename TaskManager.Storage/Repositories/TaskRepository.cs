using Microsoft.EntityFrameworkCore;
using TaskManager.Storage.Entities;

namespace TaskManager.Storage.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskManagerContext _context;

        public TaskRepository(TaskManagerContext context)
        {
            _context = context;
        }

        public async Task<Guid> CreateTaskAsync(TaskItemEntity model)
        {
            _context.Tasks.Add(model);

            await _context.SaveChangesAsync();

            return model.TaskId;
        }

        public async Task<Guid> DeleteTaskAsync(Guid id)
        {
            await _context.Tasks
                .Where(t => t.TaskId == id)
                .ExecuteDeleteAsync();

            await _context.SaveChangesAsync();

            return id;
        }

        public async Task<TaskItemEntity?> GetTaskByIdAsync(Guid id)
        {
            var task = await _context.Tasks
                .FirstOrDefaultAsync(i => i.TaskId == id);

            return task;
        }

        public async Task UpdateTaskAsync(TaskItemEntity model)
        {
            var taskItem = await _context.Tasks
                .FirstOrDefaultAsync(i => i.TaskId == model.TaskId);
            if (taskItem != null)
            {
                taskItem.Status = model.Status;
                taskItem.Date = model.Date;
                taskItem.Description = model.Description;
            }

            await _context.SaveChangesAsync();
        }
    }
}
