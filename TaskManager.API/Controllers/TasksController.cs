using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using TaskManager.API.Models;
using TaskManager.Domain.Models;
using TaskManager.Domain.Models.Enums;
using TaskManager.Domain.Services;

namespace TaskManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        /// <summary>
        /// Создание новой задачи
        /// </summary>
        /// <response code="201">Успешно создана новая задача</response>
        [HttpPost]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(Guid), StatusCodes.Status201Created)]
        public async Task<ActionResult> CreateTask(CreateTaskItemRequest request)
        {
            var model = new TaskItemModel
            {
                Date = request.Date,
                Status = (TaskItemStatus)(int)request.Status,
                Description = request.Description
            };

            var result = await _taskService.CreateTaskAsync(model);
            return Created(string.Empty, result);
        }

        /// <summary>
        /// Получение задачи по Id
        /// </summary>
        /// <response code="200">Успешно найдена задача</response>
        /// <response code="404">Задача не найдена</response>
        [HttpGet("{id:guid}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(GetTaskItemResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetTaskById(Guid id)
        {
            var task = await _taskService.GetTaskByIdAsync(id);
            if (task == null)
                return NotFound();

            return Ok(task);
        }

        /// <summary>
        /// Обновление задачи по Id
        /// </summary>
        /// <response code="200">Успешно обновлена задача</response>
        [HttpPut]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> UpdateTaskAsync(UpdateTaskItemRequest request)
        {
            var model = new TaskItemModel
            {
                TaskId = request.TaskId,
                Date = request.Date,
                Status = (TaskItemStatus)(int)request.Status,
                Description = request.Description
            };

            await _taskService.UpdateTaskAsync(model);
            return Ok();
        }

        /// <summary>
        /// Удаление задачи по Id
        /// </summary>
        /// <response code="204">Задача удалена</response>
        [HttpDelete("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult> DeleteTask(Guid id)
        {
            await _taskService.DeleteTaskAsync(id);
            return NoContent();
        }
    }
}
