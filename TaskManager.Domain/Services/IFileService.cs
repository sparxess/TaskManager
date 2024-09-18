using TaskManager.Domain.Models;

namespace TaskManager.Domain.Services
{
    public interface IFileService
    {
        /// <summary>
        /// Загрузка файла для указанной задачи
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<Guid> UploadFileAsync(FileModel model);
        /// <summary>
        /// Получение файла по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<FileModel> GetFileByIdAsync(Guid id);
        /// <summary>
        /// Удаление файла
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteFileAsync(Guid id);
        /// <summary>
        /// Обновление файла
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task UpdateFileAsync(FileModel model);
    }
}
