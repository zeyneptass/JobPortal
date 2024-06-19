using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobTypesController : ControllerBase
    {
        IJobTypeService _jobTypeService;

        public JobTypesController(IJobTypeService jobTypeService)
        {
            _jobTypeService = jobTypeService;
        }
        [HttpGet("getall")]
        public ActionResult GetAll()
        {
            var result = _jobTypeService.GetJobtypes();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getjobbyid")]
        public ActionResult GetJobById(int id)
        {
            var result = _jobTypeService.GetJobtypeById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyname")]
        public ActionResult GetJobByName(string name)
        {
            var result = _jobTypeService.GetJobTypesByName(name);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
