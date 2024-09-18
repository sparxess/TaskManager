using TaskManager.Domain.Models;

namespace TaskManager.Domain.Services
{
    public interface ITaskService
    {
        /// <summary>
        /// Создание новой задачи
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<Guid> CreateTaskAsync(TaskItemModel model);
        /// <summary>
        /// Получение задачи по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TaskItemModel> GetTaskByIdAsync(Guid id);
        /// <summary>
        /// Удаление задачи
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteTaskAsync(Guid id);
        /// <summary>
        /// Обновление задачи
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task UpdateTaskAsync(TaskItemModel model);
     
    }
}
