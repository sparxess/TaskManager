namespace TaskManager.API.Models
{
    public class GetTaskItemResponse
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
        /// Дата создания
        /// </summary>
        public DateTimeOffset Date { get; set; }
        /// <summary>
        /// Статус выполнения
        /// </summary>
        public TaskStatus Status { get; set; }
    }
}
