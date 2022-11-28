using TechnologyCategory.Controllers.Model;

namespace TechnologyCategory.Services
{
    public class TechnologyCategoryService : ITechnologyCategoryService
    {
        private readonly IConfiguration _config;
        public TechnologyCategoryService(IConfiguration config)
        {
            _config = config;
        }
        public TechnologyCategoryResponse GetTechStack()
        {
            var techStack = new TechnologyCategoryResponse();
            var frontEndStack = _config.GetSection("Technologies").GetSection("FrontEnd").Value;
            var backEndStack = _config.GetSection("Technologies").GetSection("Backend").Value;
            var databasetack = _config.GetSection("Technologies").GetSection("Database").Value;
            techStack.FrontEndTechnologies = frontEndStack.Split('|').ToList();
            //techStack.FrontEndTechnologies.Concat(tech);
            techStack.BackEndTechnologies = backEndStack.Split('|').ToList();
            //techStack.BackEndTechnologies.Concat(tech);
            techStack.DatabaseTechnologies = databasetack.Split('|').ToList();
            //techStack.DatabaseTechnologies.Concat(tech);
            return techStack;
        }
    }
}
