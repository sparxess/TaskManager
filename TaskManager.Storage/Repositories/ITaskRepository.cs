using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Storage.Entities;

namespace TaskManager.Storage.Repositories
{
    public interface ITaskRepository
    {
        Task<Guid> CreateTaskAsync(TaskItemEntity model);
        Task<TaskItemEntity?> GetTaskByIdAsync(Guid id);
        Task<Guid> DeleteTaskAsync(Guid id);
        Task UpdateTaskAsync(TaskItemEntity model);
    }
}
