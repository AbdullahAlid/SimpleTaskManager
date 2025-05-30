using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleTaskManagementWebApplication.Data;
using SimpleTaskManagementWebApplication.Models;

namespace SimpleTaskManagementWebApplication.Controllers
{
    public class TaskItemController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TaskItemController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var tasks = await _context.TaskItems.ToListAsync();
            return View(tasks);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Title, Description, DueDate")] TaskItem task)
        {
            return View(task);
        }


    }
}
