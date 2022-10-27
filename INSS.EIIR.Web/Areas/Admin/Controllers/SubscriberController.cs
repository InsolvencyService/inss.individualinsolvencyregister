﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using INSS.EIIR.Interfaces.Services;
using INSS.EIIR.Models.Constants;
using INSS.EIIR.Web.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace INSS.EIIR.Web.Areas.Admin.Controllers
{
    public class SubscriberController : Controller
    {
        private readonly ISubscriberDataProvider _subscriberDataProvider;

        public SubscriberController(ISubscriberDataProvider subscriberDataProvider)
        {
            _subscriberDataProvider = subscriberDataProvider;
        }

        [HttpGet(AreaNames.Admin + "/Subscribers/{page?}/{active?}")]
        public async Task<IActionResult> Index(int page = 1, string active = "true")
        {
            return View();
        }

        [Area(AreaNames.Admin)]
        [Route(AreaNames.Admin + "/subscriber/{subscriberId}")]
        [Authorize(Roles = Role.Admin)]
        public async Task<IActionResult> Profile(int subscriberId)
        {
            var subscriber = await _subscriberDataProvider.GetSubscriberByIdAsync($"{subscriberId}");

            return View(subscriber);
        }
    }
}

