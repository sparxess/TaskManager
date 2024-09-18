using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Storage.Entities;

namespace TaskManager.Storage.Repositories
{
    public interface IFileRepository
    {
        Task<Guid> UploadFileAsync(FileEntity model);
        Task<FileEntity?> GetFileByIdAsync(Guid id);
        Task DeleteFileAsync(Guid id);
        Task UpdateFileAsync(FileEntity model);
        Task DeleteFilesByTaskId(Guid taskId);
    }
}
