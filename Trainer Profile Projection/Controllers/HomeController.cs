using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using Trainer_Profile_Projection.Models;
using Models;
using System.Web.Services;
using System.Globalization;

namespace Trainer_Profile_Projection.Controllers
{
    public class HomeController : Controller
    {
        ITrainerProfileBL trainer = new TrainerProfileBL();

        public ActionResult Index()
        {
            GetAvailableTrainers();
            return View();
        }

        [HttpPost]
        public ActionResult GetAllTrainers()
        {
            List<tblTrainerDetail> trainersList = new List<tblTrainerDetail>();
            trainersList = trainer.GetAllTrainers();
            return PartialView("_ShowTrainers", trainersList);
        }

        [HttpPost]
        public ActionResult GetTrainers(TrainerModel trainerModel)
        {            
            List<USP_GetTrainerAvailability_Result> trainerList = new List<USP_GetTrainerAvailability_Result>();            
            trainerList = trainer.GetTrainers(trainerModel.TrainerId, trainerModel.StartDate, trainerModel.EndDate);
            string msg = "";
            if (trainerList.Count() > 0)
                msg = "Trainer " + trainerModel.TrainerId + " Profile can be projected!";
            else
                msg = "Trainer " + trainerModel.TrainerId + " has already been projected, kindly project another profile!";
            return Json(msg, JsonRequestBehavior.AllowGet);
            //return PartialView("_ShowTrainers", trainerList);
        }

        public void GetAvailableTrainers()
        {
            var availableTrainers = trainer.GetAvailableTrainers();
            var trainerList = availableTrainers.Select(m => new SelectListItem()
            {
                Text = m.TrainerId.ToString(),
                Value = m.TrainerId.ToString(),
            });

            ViewBag.TrainerId = trainerList;

            //return PartialView("_ProjectTrainers");
            //return View("Index");
        }

        [HttpPost]
        public ActionResult ProjectTrainers(TrainerModel trainerModel)
        {
            int message = trainer.ProjectTrainer(trainerModel.VendorId, trainerModel.TrainerId, trainerModel.StartDate, trainerModel.EndDate);

            GetAvailableTrainers();

            //return PartialView("_ProjectTrainers", message);
            return View("Index");
        }
    }
}