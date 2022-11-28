using Microsoft.AspNetCore.Mvc;
using TechnologyCategory.Controllers.Model;
using TechnologyCategory.Services;

namespace TechnologyCategory.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TechnologyCategoryController : Controller
    {
        private readonly ITechnologyCategoryService _service;
        public TechnologyCategoryController(ITechnologyCategoryService techService)
        {
            _service = techService;
        }
        [HttpGet]
        public TechnologyCategoryResponse GetTechnologyCategories()
        {
            return _service.GetTechStack();
            
        }
    }
}
