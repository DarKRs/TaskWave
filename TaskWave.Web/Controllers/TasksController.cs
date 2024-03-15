using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TaskWave.Domain.Entities;
using TaskWave.Domain.Interfaces.IServices;
using TaskWave.Infrastructure.Data;
using TaskWave.Infrastructure.Services;

namespace TaskWave.Web.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITaskService _taskService;
        private readonly IProjectService _projectService;

        public TasksController(ITaskService taskService, IProjectService projectService)
        {
            _taskService = taskService;
            _projectService = projectService;
        }

        public async Task<IActionResult> Index()
        {
            var tasks = await _taskService.GetAllTasksAsync();
            return View(tasks);
        }

        public async Task<IActionResult> Details(int id)
        {
            var task = await _taskService.GetTaskByIdWithProjectAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        // Создание новой задачи (GET)
        public async Task<IActionResult> Create()
        {
            var projects = await _projectService.GetAllProjectsAsync();
            ViewBag.Projects = new SelectList(projects, "ProjectId", "Name");
            return View();
        }

        // Создание новой задачи (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Description,ProjectId")] ProjectTask task)
        {
            ModelState.Remove("Project");
            if (ModelState.IsValid)
            {
                await _taskService.CreateTaskAsync(task);
                return RedirectToAction(nameof(Index));
            }
            if (!ModelState.IsValid) {
                var projects = await _projectService.GetAllProjectsAsync();
                ViewBag.Projects = new SelectList(projects, "ProjectId", "Name");
                return View();
            }
            return View(task);
        }

    }

}
