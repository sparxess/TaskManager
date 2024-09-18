using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Models.Enums;

namespace TaskManager.Domain.Models
{
    public class TaskItemModel
    {
        /// <summary>
        /// Id задачи
        /// </summary>
        public Guid TaskId { get; set; }
        /// <summary>
        /// Наименование задачи
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Дата создания задачи
        /// </summary>
        public DateTimeOffset Date { get; set; }
        /// <summary>
        /// Статус выполнения
        /// </summary>
        public TaskItemStatus Status { get; set; }
    }
}
