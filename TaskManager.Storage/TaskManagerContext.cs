using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Storage.Entities;
using TaskManager.Storage.Entities.Enums;

namespace TaskManager.Storage
{
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext(DbContextOptions<TaskManagerContext> options) : base(options) { }

        public DbSet<TaskItemEntity> Tasks { get; set; }
        public DbSet<FileEntity> Files { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TaskItemEntity>()
                .HasKey(t => t.TaskId);

            modelBuilder.Entity<TaskItemEntity>()
                .HasMany(t => t.Files)
                .WithOne(f => f.TaskItemEntity)
                .HasForeignKey(k => k.TaskId);

            var firstTaskItemId = Guid.NewGuid();
            var secondTaskItemId = Guid.NewGuid();
            var thirdTaskItemId = Guid.NewGuid();
            modelBuilder.Entity<TaskItemEntity>().HasData(
                new TaskItemEntity
                {
                    TaskId = firstTaskItemId,
                    Date = DateTimeOffset.Now,
                    Description = "Task1",
                    Status = TaskItemStatus.Created
                },
                new TaskItemEntity
                {
                    TaskId = secondTaskItemId,
                    Date = DateTimeOffset.Now,
                    Description = "Task2",
                    Status = TaskItemStatus.Created
                },
                new TaskItemEntity
                {
                    TaskId = thirdTaskItemId,
                    Date = DateTimeOffset.Now,
                    Description = "Task3",
                    Status = TaskItemStatus.Created
                }
                );

            modelBuilder.Entity<FileEntity>().HasData(
                new FileEntity
                {
                    Id = Guid.NewGuid(),
                    FileName = "file1.txt",
                    ContentType = "text/plain",
                    DateCreated = DateTimeOffset.Now,
                    Content = new byte[100],
                    TaskId = firstTaskItemId
                },
                new FileEntity
                {
                    Id = Guid.NewGuid(),
                    FileName = "file2.png",
                    ContentType = "image/png",
                    DateCreated = DateTimeOffset.Now,
                    Content = new byte[100],
                    TaskId = firstTaskItemId
                },
                new FileEntity
                {
                    Id = Guid.NewGuid(),
                    FileName = "file3.txt",
                    ContentType = "text/plain",
                    DateCreated = DateTimeOffset.Now,
                    Content = new byte[100],
                    TaskId = firstTaskItemId
                },
                new FileEntity
                {
                    Id = Guid.NewGuid(),
                    FileName = "file4.txt",
                    ContentType = "text/plain",
                    DateCreated = DateTimeOffset.Now,
                    Content = new byte[100],
                    TaskId = secondTaskItemId
                },
                new FileEntity
                {
                    Id = Guid.NewGuid(),
                    FileName = "file5.png",
                    ContentType = "image/png",
                    DateCreated = DateTimeOffset.Now,
                    Content = new byte[100],
                    TaskId = secondTaskItemId
                },
                new FileEntity
                {
                    Id = Guid.NewGuid(),
                    FileName = "file6.png",
                    ContentType = "image/png",
                    DateCreated = DateTimeOffset.Now,
                    Content = new byte[100],
                    TaskId = thirdTaskItemId
                }
                );
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<Enum>().HaveConversion<string>();
        }
    }
}
