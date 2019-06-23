using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aeh.uber.Models;
using aeh.uber.Interfaces;
using AutoMapper;

namespace aeh.uber.Controllers
{
    public class CvController : Controller
    {
        private readonly IAppLogic _appLogic;
        private readonly IMapper _mapper;

        public CvController(IAppLogic iAppLogic, IMapper mapper)
        {
            _appLogic = iAppLogic;

            _mapper = mapper;
        }

        public async Task<IActionResult> Index(string id = "aeh")
        {
            var rawData = await _appLogic.GetAboutMeEntryAsync(id);

            if(rawData == null) return NotFound($"Can't find a guy named {id}...");


            var aboutMeViewModel = _mapper.Map<AboutMeViewModel>(rawData);

            return View(aboutMeViewModel);
        }
    }
}
