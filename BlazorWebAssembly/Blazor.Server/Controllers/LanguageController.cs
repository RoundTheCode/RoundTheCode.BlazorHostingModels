using API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        protected readonly ILanguageService _languageService;

        public LanguageController([NotNull] ILanguageService languageService)
        {
            _languageService = languageService;
        }

        [Route("getall")]
        public virtual IEnumerable<string> GetAll()
        {
            return _languageService.GetAll();
        }

        [Route("add"), HttpPost]
        public virtual IEnumerable<string> Add(LanguageModel model)
        {
            _languageService.AddLanguage(model.Language);

            return _languageService.GetAll();
        }
    }

    public class LanguageModel
    {
        public virtual string Language { get; set; }
    }
}