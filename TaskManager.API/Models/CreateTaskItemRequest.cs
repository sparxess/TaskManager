using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Models.Enums;

namespace TaskManager.API.Models
{
    public class CreateTaskItemRequest
    {
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
        public TaskItemStatus Status { get; set; }
    }
}
