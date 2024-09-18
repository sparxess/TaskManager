using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Threading.Tasks;
using TaskManager.API.Models;
using TaskManager.Domain.Models;
using TaskManager.Domain.Models.Enums;
using TaskManager.Domain.Services;
using TaskManager.Storage.Entities;

namespace TaskManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilesController : ControllerBase
    {
        private readonly IFileService _fileService;

        public FilesController(IFileService fileService)
        {
            _fileService = fileService;
        }

        /// <summary>
        /// Добавление нового файла для указанной задачи
        /// </summary>
        /// <response code="201">Успешно добавлен новый файл</response>
        [HttpPost]
        [ProducesResponseType(typeof(Guid), StatusCodes.Status201Created)]
        public async Task<ActionResult> UploadFile(IFormFile file, [FromQuery] Guid taskId)
        {
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                
                var fileModel = new FileModel
                {
                    FileName = file.FileName,
                    ContentType = file.ContentType,
                    DateCreated = DateTimeOffset.Now,
                    TaskId = taskId,
                    Content = memoryStream.ToArray()
                };

                var result = await _fileService.UploadFileAsync(fileModel);

                return Created(string.Empty, result);
            }
        }

        /// <summary>
        /// Получение файла по Id
        /// </summary>
        /// <response code="200">Успешно найден файл</response>
        /// <response code="404">Файл не найден</response>
        [HttpGet("{id:guid}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetFileById(Guid id)
        {
            var file = await _fileService.GetFileByIdAsync(id);
            
            if (file == null)
            {
                return NotFound();
            }

            return File(file.Content, file.ContentType, file.FileName);
        }

        /// <summary>
        /// Обновление файла по Id
        /// </summary>
        /// <response code="200">Успешно обновлена задача</response>
        [HttpPut]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> UpdateFileAsync(IFormFile file, [FromQuery] Guid id)
        {
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);

                var fileModel = new FileModel
                {
                    Id = id,
                    FileName = file.FileName,
                    ContentType = file.ContentType,
                    DateCreated = DateTimeOffset.Now,
                    Content = memoryStream.ToArray()
                };

                await _fileService.UpdateFileAsync(fileModel);

                return Ok();
            }
        }

        /// <summary>
        /// Удаление файла по Id
        /// </summary>
        /// <response code="204">Файл удален</response>
        [HttpDelete("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult> DeleteFile(Guid id)
        {
            await _fileService.DeleteFileAsync(id);

            return NoContent();
        }
    }
}
