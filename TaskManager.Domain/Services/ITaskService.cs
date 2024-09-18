using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Models;

namespace TaskManager.Domain.Services
{
    public interface ITaskService
    {
        Task<Guid> CreateTaskAsync(TaskItemModel model);
        Task<TaskItemModel> GetTaskByIdAsync(Guid id);
        Task DeleteTaskAsync(Guid id);
        Task UpdateTaskAsync(TaskItemModel model);
     
    }
}
