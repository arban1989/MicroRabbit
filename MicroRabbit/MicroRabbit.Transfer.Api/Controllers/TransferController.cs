using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroRabbit.Transfer.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferServices _transferServices;

        public TransferController(ITransferServices transferServices)
        {
            _transferServices = transferServices;
        }


        // Get api/transfer
        [HttpGet]
        public ActionResult<IEnumerable> GetTransferLogs()
        {
            return Ok(_transferServices.GetTransferLogs());
        }
    }
}
