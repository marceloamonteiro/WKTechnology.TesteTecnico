using Microsoft.AspNetCore.Mvc;
using WKTechnology.TesteTecnico.Domain.Model.Common;

namespace WKTechnology.TesteTecnico.Api.Controllers
{
    public class BaseController : ControllerBase
    {
        protected new IActionResult Response<T>(ResponseObject<T> response)
        {
            if (response.HasError)
                return BadRequest(new ResponseObject<T>(response.Notifications));

            if (response.HasData)
                return Ok(new ResponseObject<T>(response.Data));

            return NotFound(new ResponseObject<T>(response.Notifications));
        }
    }
}
