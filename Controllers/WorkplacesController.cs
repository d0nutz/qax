using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using qax.Entities;
using qax.Repositories;

namespace qax.Controllers
{
    [ApiController]
    [Route("workplaces")]
    public class WorkplacesController : ControllerBase
    {
        private readonly IWorkplacesRepository repository;
        public WorkplacesController(IWorkplacesRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public IEnumerable<Workplace> GetWorkplaces()
        {
            var workplaces = repository.GetWorkplaces();
            return workplaces;
        }
        [HttpGet("{id}")]
        public ActionResult<Workplace> GetWorkplace(Guid id)
        {
            var workplace = repository.GetWorkplace(id);
            if (workplace is null)
            {
                return NotFound();
            }
            return workplace;
        }
    }
}