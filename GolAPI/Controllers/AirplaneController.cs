using GOL.Commom.Pagging;
using GOL.Domain.Entities.Airplane;
using GOL.Domain.Interfaces;
using GOL.Service.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GOL.Service.Controllers
{
    [Route("api/v1/airplane")]
    [ApiController]
    public class AirplaneController : ControllerBase
    {
        private readonly IAirplaneRepository _airplaneRepository;

        public AirplaneController(IAirplaneRepository airplaneRepository)
        {
            _airplaneRepository = airplaneRepository;
        }

        /// <summary>
        /// Retorna uma lista de airplanes
        /// </summary>
        /// <param name="actualPage">pagina atual</param>
        /// <param name="pageSize">itens por página</param>
        /// <returns>Lista paginada de airplanes</returns>
        [HttpGet()]
        public ActionResult<PagedResult<Airplane>> Get(int actualPage = 1, int pageSize = 20)
        {            
            return Ok(_airplaneRepository.Get(actualPage, pageSize));
        }

        [HttpPost]
        public IActionResult New(AirplaneViewModel airplaneViewModel)
        {

        }

    }
}
