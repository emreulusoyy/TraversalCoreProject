using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProject.Controllers
{
    public class DefaultController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
