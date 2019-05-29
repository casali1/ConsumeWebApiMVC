using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConsumeWebApiMVC.Models;
using System.Net.Http;

namespace ConsumeWebApiMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetMembers()
        {
            IEnumerable<MemberViewModel> members = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:52044/api/");

                var responseTask = client.GetAsync("member");
                responseTask.Wait();

                //To store result of web api response.
                var result = responseTask.Result;

                if(result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<MemberViewModel>>();

                    readTask.Wait();

                    members = readTask.Result;
                }
                else
                {
                    members = Enumerable.Empty<MemberViewModel>();
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }

            return View(members);
        }


    }
}