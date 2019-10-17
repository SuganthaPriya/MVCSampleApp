using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataAccessLayer;

namespace BusinessLayer
{
    public class TrainerProfileBL: ITrainerProfileBL
    {
        ITrainerProfileDL trainerProfileDL = new TrainerProfileDL();

        public List<tblTrainerDetail> GetAllTrainers()
        {
            return trainerProfileDL.GetAllTrainers();
        }

        public List<USP_GetTrainerAvailability_Result> GetTrainers(int trainerId, DateTime startDate, DateTime endDate)
        {
            return trainerProfileDL.GetTrainers(trainerId, startDate, endDate);
        }

        public List<tblTrainerDetail> GetAvailableTrainers()
        {
            return trainerProfileDL.GetAvailableTrainers();
        }

        public int ProjectTrainer(int vendorId, int trainerId, DateTime startDate, DateTime endDate)
        {
            return trainerProfileDL.ProjectTrainer(vendorId, trainerId, startDate, endDate);
        }
    }
}
