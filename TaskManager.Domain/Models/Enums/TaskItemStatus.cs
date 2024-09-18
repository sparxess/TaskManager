using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Domain.Models.Enums
{
    public enum TaskItemStatus
    {
        /// <summary>Задача создана</summary>
        Created = 1,

        /// <summary>Задача в процессе</summary>
        InProgress = 2,

        /// <summary>Задача выполнена</summary>
        Completed = 3,

        /// <summary>Задача на паузе</summary>
        OnHold = 4,

        /// <summary>Задача отменена</summary>
        Cancelled = 5,

        /// <summary>Произошла ошибка</summary>
        Failed = 6
    }
}
