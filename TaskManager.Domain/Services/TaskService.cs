using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Models;
using TaskManager.Storage.Entities;
using TaskManager.Storage.Entities.Enums;
using TaskManager.Storage.Repositories;

namespace TaskManager.Domain.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        private readonly IFileRepository _fileRepository;

        public TaskService(ITaskRepository taskRepository, IFileRepository fileRepository)
        {
            _taskRepository = taskRepository;
            _fileRepository = fileRepository;
        }

        public async Task<Guid> CreateTaskAsync(TaskItemModel request)
        {
            var model = new TaskItemEntity
            {
                Date = request.Date,
                Description = request.Description,
                Status = (TaskItemStatus)(int)request.Status
            };

            return await _taskRepository.CreateTaskAsync(model);
        }

        public async Task<TaskItemModel> GetTaskByIdAsync(Guid id)
        {
            var taskModel = await _taskRepository.GetTaskByIdAsync(id);

            return new TaskItemModel
            {
                TaskId = taskModel.TaskId,
                Date = taskModel.Date,
                Description = taskModel.Description,
                Status = (Models.Enums.TaskItemStatus)(int)taskModel.Status
            };
        }

        public async Task DeleteTaskAsync(Guid id)
        {
            await _fileRepository.DeleteFilesByTaskId(id);

            await _taskRepository.DeleteTaskAsync(id);
        }

        public async Task UpdateTaskAsync(TaskItemModel model)
        {
            await _taskRepository.UpdateTaskAsync(
                new TaskItemEntity
                {
                    TaskId = model.TaskId,
                    Date = model.Date,
                    Description = model.Description,
                    Status = (TaskItemStatus)(int)model.Status
                });
        }
    }
}
