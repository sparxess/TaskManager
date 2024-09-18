using TaskManager.Storage.Entities.Enums;

namespace TaskManager.Storage.Entities
{
    public class TaskItemEntity
    {
        /// <summary>
        /// Id задачи
        /// </summary>
        public Guid TaskId { get; set; }
        /// <summary>
        /// Наименование задачи
        /// </summary>
        public string Description { get; set; } = null!;
        /// <summary>
        /// Дата создания задачи
        /// </summary>
        public DateTimeOffset Date { get; set; }
        /// <summary>
        /// Статус выполнения задачи
        /// </summary>
        public TaskItemStatus Status { get; set; }
        /// <summary>
        /// Список файлов, связанных с задачей
        /// </summary>
        public IEnumerable<FileEntity> Files { get; set; } = null!;
    }
}
