using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SampleADWebApi.Service.Models;

namespace SampleADWebApi.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NamesController : ControllerBase
    {
        [Authorize(Roles = "Api.readonly")]
        [HttpGet, Route("GetNames")]
        public IActionResult GetNames()
        {
            return Ok(Data.namelist);
        }

        [Authorize(Roles = "Api.readwirteonly")]
        [HttpPost, Route("PostName")]
        public IActionResult PostName([FromBody] NameModel nameModel)
        {
            Data.namelist.Add(nameModel);
            return Ok(Data.namelist);
        }
    }
}
