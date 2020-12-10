using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Search.POC.API.Models;
using Search.POC.API.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Search.POC.API.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/v1")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private IService _searchService;

        public SearchController(IService searchSvc)
        {
            _searchService = searchSvc;
        }


        [HttpPost("search", Name = "Search Records")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<String>> Search([FromBody] SearchRequestDTO searchRequestDTO)
        {
            if (searchRequestDTO == null)
            {
                return BadRequest("Criteria is empty. Nothing to fetch");
            }

            var result = _searchService.Search(searchRequestDTO);

            if (result != null)
            {
                return StatusCode(200, result);
            }
            return NoContent();
        }
    }
}
