using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using backend.Models;
using backend.dto;
using AutoMapper;
using backend.DAL;

namespace backend.Controllers
{
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly LanguageDataAcceses _languageDataAccess;
        private readonly IMapper _mapper;
        public LanguageController(ExplorerContext context, IMapper mapper)
        {
            _languageDataAccess = new LanguageDataAcceses(context);
            _mapper = mapper;
        }

        // GET: api/language
        [HttpGet]
        [Route("api/language")]
        public ActionResult<IEnumerable<Language>> GetLanguages()
        {
            var languages = _languageDataAccess.GetLanguages();
            var languagesDto = _mapper.Map<List<LanguageDto>>(languages);
            return Ok(languagesDto);
        }

        // GET: api/language/{id}
        [HttpGet]
        [Route("api/language/{id}")]
        public ActionResult<Artist> GetPainting(long id)
        {
            Language language = _languageDataAccess.GetLanguage(id);
            if (language == null){
                return NotFound();
            }
            LanguageDto languageDto = _mapper.Map<LanguageDto>(language);
            return Ok(languageDto);
        }
    }
}
