using Microsoft.AspNetCore.Mvc;
using TaskWave.Domain.Entities;
using TaskWave.Domain.Interfaces.IServices;

namespace TaskWave.Web.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public async Task<IActionResult> Index()
        {
            var projects = await _projectService.GetAllProjectsAsync();
            return View(projects);
        }

        public async Task<IActionResult> Details(int id)
        {
            var project = await _projectService.GetProjectByIdAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name")] Project project)
        {
            if (ModelState.IsValid)
            {
                await _projectService.CreateProjectAsync(project);
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

    }
}
