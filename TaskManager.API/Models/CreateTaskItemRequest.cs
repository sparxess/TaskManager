using TaskManager.Domain.Models.Enums;

namespace TaskManager.API.Models
{
    public class CreateTaskItemRequest
    {
        /// <summary>
        /// Наименование задачи
        /// </summary>
        public string Description { get; set; } = null!;
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTimeOffset Date { get; set; }
        /// <summary>
        /// Статус выполнения
        /// </summary>
        public TaskItemStatus Status { get; set; }
    }
}
