using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepoDemoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkerController : ControllerBase
    {
        
        private readonly IAsyncRepository<Worker> _repository;

        public WorkerController(IAsyncRepository<Worker> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Worker>> GetWorkers() 
        {
            return await _repository.GetAll();
        }

    }
}
