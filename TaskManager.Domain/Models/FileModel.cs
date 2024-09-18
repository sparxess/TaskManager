using TaskManager.Storage.Entities;

namespace TaskManager.Domain.Models
{
    public class FileModel
    {
        /// <summary>
        /// Id файла
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Имя файла
        /// </summary>
        public string FileName { get; set; } = null!;
        /// <summary>
        /// Тип файла
        /// </summary>
        public string ContentType { get; set; } = null!;
        /// <summary>
        /// Дата создания файла
        /// </summary>
        public DateTimeOffset? DateCreated { get; set; }
        /// <summary>
        /// Содержимое файла в виде массива байтов
        /// </summary>
        public byte[] Content { get; set; } = null!;
        /// <summary>
        /// Задача, к которой относится файл
        /// </summary>
        public TaskItemEntity TaskItemEntity { get; set; } = null!;
        /// <summary>
        /// Id задачи, к которой относится файл
        /// </summary>
        public Guid TaskId { get; set; }
    }
}
