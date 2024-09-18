using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.API.Models
{
    public class UpdateTaskItemRequest
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
        /// Id задачи
        /// </summary>
        public DateTimeOffset Date { get; set; }
        /// <summary>
        /// Статус выполнения
        /// </summary>
        public TaskStatus Status { get; set; }
    }
}
