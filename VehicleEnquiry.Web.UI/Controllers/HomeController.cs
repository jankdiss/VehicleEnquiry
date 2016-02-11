using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicleEnquiry.Commands;
using VehicleEnquiry.Commands.Handlers;
using VehicleEnquiry.Core.IContract;
using VehicleEnquiry.Web.UI.App_Start;
using VehicleEnquiry.Web.UI.Utils;
using VehicleEnquiry.Web.UI.ViewModel;

namespace VehicleEnquiry.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        IVehicleQuerying _query;
      

        public HomeController(IVehicleQuerying query)
        {
            _query = query;
        }

        public ActionResult Index()
        {
            var items = _query.Get().ToViewModel();
            return View(items);
        }

        public ActionResult Details(int id)
        {
            var item = _query.Get(id).ToDetailsViewModel();
            return View(item);
        }

        [HttpPost]
        public ActionResult Enquiry(EnquiryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var container = UnityConfig.GetConfiguredContainer();

                var _commandBus = container.Resolve<ICommandBus>();

                _commandBus.Send(
                    new CreateEnquiryCommand(Guid.NewGuid(),model.VehicleId,model.Name,model.Email,model.Comment,DateTime.Now)
                    );

                return RedirectToAction("ThankYou");
            }

            return RedirectToAction("Details",new { id = model.VehicleId});

        }

        public ActionResult ThankYou()
        {
            return View();
        }
        
    }
}