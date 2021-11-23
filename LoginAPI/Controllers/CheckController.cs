using LoginAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LoginAPI.Controllers
{
    [Authorize]
    [Route("api/check")]
    public class CheckController : MainController
    {
        [HttpPost("open")]
        public async Task<ActionResult> Open(CheckViewModel vm)
        {
            return CustomResponse(vm.Message);
        }
    }
}
