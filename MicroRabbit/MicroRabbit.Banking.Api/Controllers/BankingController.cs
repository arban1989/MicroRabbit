﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.ModelsDto;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroRabbit.Banking.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // Get api/banking
        [HttpGet]
        public ActionResult<IEnumerable<Account>> GetAccounts()
        {
            return Ok(_accountService.GetAccounts());
        }

        [HttpPost]
        public ActionResult PostAccount([FromBody] AccountTransfer accountTranfer)
        {
            _accountService.Transfer(accountTranfer);
            return Ok(accountTranfer);
        }
    }
}
