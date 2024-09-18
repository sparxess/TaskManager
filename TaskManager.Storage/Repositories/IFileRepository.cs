using TaskManager.Storage.Entities;

namespace TaskManager.Storage.Repositories
{
    public interface IFileRepository
    {
        /// <summary>
        /// Загрузка файла для указанной задачи
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<Guid> UploadFileAsync(FileEntity model);
        /// <summary>
        /// Получение файла по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<FileEntity?> GetFileByIdAsync(Guid id);
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
        Task UpdateFileAsync(FileEntity model);
        /// <summary>
        /// Удаление всех файлов для указанной задачи
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        Task DeleteFilesByTaskId(Guid taskId);
    }
}
