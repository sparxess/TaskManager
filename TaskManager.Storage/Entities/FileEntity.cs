using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Storage.Entities
{
    public class FileEntity
    {
        /// <summary>
        /// Id файла
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Имя файла
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// Тип файла
        /// </summary>
        public string ContentType { get; set; }
        /// <summary>
        /// Дата создания файла
        /// </summary>
        public DateTimeOffset? DateCreated { get; set; }
        /// <summary>
        /// Содержимое файла в виде массива байтов
        /// </summary>
        public byte[] Content { get; set; }
        /// <summary>
        /// Задача, к которой относится файл
        /// </summary>
        public TaskItemEntity TaskItemEntity { get; set; }
        /// <summary>
        /// Id задачи, к которой относится файл
        /// </summary>
        public Guid TaskId { get; set; }
    }
}
