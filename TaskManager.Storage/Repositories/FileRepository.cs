using Microsoft.EntityFrameworkCore;
using TaskManager.Storage.Entities;

namespace TaskManager.Storage.Repositories
{
    public class FileRepository : IFileRepository
    {
        private readonly TaskManagerContext _context;

        public FileRepository(TaskManagerContext context)
        {
            _context = context;
        }

        public async Task<Guid> UploadFileAsync(FileEntity model)
        {
            _context.Files.Add(model);

            await _context.SaveChangesAsync();

            return model.Id;
        }

        public async Task DeleteFileAsync(Guid id)
        {
            await _context.Files
                .Where(t => t.Id == id)
                .ExecuteDeleteAsync();

            await _context.SaveChangesAsync();
        }

        public async Task<FileEntity?> GetFileByIdAsync(Guid id)
        {
            var file = await _context.Files
                .FirstOrDefaultAsync(i => i.Id == id);

            return file;
        }

        public async Task UpdateFileAsync(FileEntity model)
        {
            var file = await _context.Files
                .FirstOrDefaultAsync(i => i.Id == model.Id);

            if (file != null)
            {
                file.FileName = model.FileName;
                file.ContentType = model.ContentType;
                file.DateCreated = model.DateCreated;
                file.Content = model.Content;
            }

            await _context.SaveChangesAsync();
        }

        public async Task DeleteFilesByTaskId(Guid taskId)
        {
            await _context.Files
                .Where(t => t.TaskId == taskId)
                .ExecuteDeleteAsync();

            await _context.SaveChangesAsync();
        }
    }
}
