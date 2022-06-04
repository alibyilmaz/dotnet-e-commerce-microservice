using FreeCourse.Shared.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Shared.ControllerBases;
using FreeCourse.Shared.Services;

namespace FreeCourse.Services.FakePayment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FakePaymentsController : CustomBaseController
    {

        [HttpPost]
        public IActionResult ReceivePayment()
        {
            return CreateActionResultInstance(ResponseDto<NoContent>.Success(200));
        }
    }
}
