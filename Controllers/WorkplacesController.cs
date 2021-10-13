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
        private readonly InMemWorkplacesRepository repository;
        public WorkplacesController()
        {
            repository = new InMemWorkplacesRepository();
        }
        [HttpGet]
        public IEnumerable<Workplace> GetWorkplaces()
        {
            var workplaces = repository.GetWorkplaces();
            return workplaces;
        }
    }
}