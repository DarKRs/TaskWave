using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskWave.Domain.Entities;
using TaskWave.Domain.Interfaces.IRepositories;
using TaskWave.Infrastructure.Services;

namespace TaskWave.Tests.UnitTests
{
    [TestFixture]
    public class TaskServiceTests
    {
        private Mock<ITaskRepository> _mockRepository;
        private TaskService _taskService;

        [SetUp]
        public void Setup()
        {
            _mockRepository = new Mock<ITaskRepository>();
            _taskService = new TaskService(_mockRepository.Object);
        }

        [Test]
        public async Task GetAllTasksAsync_ReturnsAllTasks()
        { 
            var fakeTasks = new List<ProjectTask>
            {
                new ProjectTask { TaskId = 1, Name = "Test Task 1", Description = "Description 1" },
                new ProjectTask { TaskId = 2, Name = "Test Task 2", Description = "Description 2" }
            };
            _mockRepository.Setup(repo => repo.GetAllAsync()).ReturnsAsync(fakeTasks);

            // Act
            var result = await _taskService.GetAllTasksAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.Count(), Is.EqualTo(2));
            _mockRepository.Verify(repo => repo.GetAllAsync(), Times.Once);
        }
    }
}
