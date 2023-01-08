using Cozy.Domain.AppCode.Extensions;
using Cozy.Domain.Business.BlogPostModule;
using Cozy.Domain.Models.DataContexts;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cozy.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly CozyDbContext db;
        private readonly IMediator mediator;

        public BlogController(CozyDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index(BlogPostGetAllQuery query)
        {
            var response = await mediator.Send(query);

            if (Request.IsAjaxRequest())
            {
                return PartialView("_PostBody", response);
            }
            return View(response);
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
