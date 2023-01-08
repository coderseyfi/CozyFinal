using Cozy.Domain.AppCode.Extensions;
using Cozy.Domain.Models.DataContexts;
using Cozy.Domain.Models.Entites;
using Cozy.Domain.Models.ViewModels.ContactPostInfo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Cozy.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly CozyDbContext db;

        public HomeController(CozyDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Faq()
        {
            var data = db.Faqs.Where(f => f.DeletedDate == null).ToList();
            return View(data);

        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Subscribe(Subscribe model)
        //{



        //    if (!ModelState.IsValid)
        //    {
        //        string msg = ModelState.Values.First().Errors[0].ErrorMessage;

        //        return Json(new
        //        {
        //            error = true,
        //            message = msg
        //        });
        //    }

        //    var entity = db.Subscribes.FirstOrDefault(s => s.Email.Equals(model.Email));

        //    if (entity != null && entity.IsApproved == true)
        //    {
        //        return Json(new
        //        {
        //            error = false,
        //            message = "Siz artiq abune olmusunuz"
        //        });
        //    }

        //    if (entity == null)
        //    {
        //        db.Subscribes.Add(model);
        //        db.SaveChanges();
        //    }
        //    else if (entity != null)
        //    {
        //        model.Id = entity.Id;
        //    }

        //    string token = $"{model.Id}-{model.Email}-{Guid.NewGuid()}";

        //    token = crypto.Encrypt(token, true);


        //    string message = $"Abuneliyinizi <a href='https://{Request.Host}/approve-subscribe?token={token}'>link</a> vasitesile tesdiq edin";

        //    await emailService.SendEmailAsync(model.Email, "Subscribe Approve ticket", message);

        //    return Json(new
        //    {
        //        error = false,
        //        message = "E-mailinizə təsdiq mesajı göndərildi"
        //    });



        //}

        public IActionResult Contact()
        {
            var contactInfo = db.ContactInfos.FirstOrDefault();

            return View(new ContactPostInfoViewModel
            {
                ContactInfos = contactInfo
            });
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactPostInfoViewModel vm)
        {
            if (ModelState.IsValid)
            {
                db.ContactPosts.Add(vm.ContactPosts);

                await db.SaveChangesAsync();

                var response = new
                {
                    error = false,
                    message = "Your request has been accepted, we'll reply soon"
                };

                return Json(response);
            }

            var responseError = new
            {
                error = true,
                message = "Information is not correct, please try again",
                state = ModelState.GetError()
            };
            return Json(responseError);
        }

    }
}
