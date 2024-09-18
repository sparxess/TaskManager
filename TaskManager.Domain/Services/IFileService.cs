using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Models;

namespace TaskManager.Domain.Services
{
    public interface IFileService
    {
        Task<Guid> UploadFileAsync(FileModel model);
        Task<FileModel> GetFileByIdAsync(Guid id);
        Task DeleteFileAsync(Guid id);
        Task UpdateFileAsync(FileModel model);
    }
}
