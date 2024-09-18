using TaskManager.Storage.Entities;

namespace TaskManager.Storage.Repositories
{
    public interface ITaskRepository
    {
        /// <summary>
        /// Создание новой задачи
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<Guid> CreateTaskAsync(TaskItemEntity model);
        /// <summary>
        /// Получение задачи по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TaskItemEntity?> GetTaskByIdAsync(Guid id);
        /// <summary>
        /// Удаление задачи
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Guid> DeleteTaskAsync(Guid id);
        /// <summary>
        /// Обновление задачи
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task UpdateTaskAsync(TaskItemEntity model);
    }
}
