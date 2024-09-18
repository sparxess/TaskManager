using System.Data;
using TaskManager.Domain.Models;
using TaskManager.Storage.Entities;
using TaskManager.Storage.Repositories;

namespace TaskManager.Domain.Services
{
    public class FileService : IFileService
    {
        private readonly IFileRepository _fileRepository;
        private readonly ITaskRepository _taskRepository;

        public FileService(IFileRepository fileRepository, ITaskRepository taskRepository)
        {
            _fileRepository = fileRepository;
            _taskRepository = taskRepository;
        }

        public async Task<Guid> UploadFileAsync(FileModel request)
        {
            var taskItem = await _taskRepository.GetTaskByIdAsync(request.TaskId) ?? 
                throw new DataException("File not found");

            var model = new FileEntity
            {
                FileName = request.FileName,
                ContentType = request.ContentType,
                DateCreated = request.DateCreated,
                Content = request.Content,
                TaskId = request.TaskId,
            };
            return await _fileRepository.UploadFileAsync(model);
        }

        public async Task DeleteFileAsync(Guid id)
        {
            await _fileRepository.DeleteFileAsync(id);
        }

        public async Task<FileModel> GetFileByIdAsync(Guid id)
        {
            var fileModel = await _fileRepository.GetFileByIdAsync(id);
            return new()
            {
                Id = fileModel!.Id,
                FileName = fileModel.FileName,
                ContentType = fileModel.ContentType,
                DateCreated = fileModel.DateCreated,
                Content = fileModel.Content,
                TaskId = fileModel.TaskId
            };
        }

        public async Task UpdateFileAsync(FileModel model)
        {
            await _fileRepository.UpdateFileAsync(
                new()
                {
                    Id = model.Id,
                    FileName = model.FileName,
                    ContentType = model.ContentType,
                    DateCreated = model.DateCreated,
                    Content = model.Content,
                });
        }
    }
}
