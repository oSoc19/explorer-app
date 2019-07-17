using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using backend.Models;
using backend.dto;
using AutoMapper;
using backend.DAL;

namespace backend.Controllers
{
    [ApiController]
    public class HomepageController : ControllerBase
    {
        public HomepageController(ExplorerContext context, IMapper mapper)
        {
        }

        // GET: /
        [HttpGet]
        [Route("/")]
        public ActionResult Homepage()
        {
          return Ok("Welcome");
        }

        // GET: /api
        [HttpGet]
        [Route("/api")]
        public ActionResult HomepageApi()
        {
          return Ok("Welcome to Api");
        }

    }
}