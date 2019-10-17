using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAccessLayer
{
    public class TrainerProfileDL: ITrainerProfileDL
    {
        TrainerProfileProjectionEntities trainerProfileProjectionEntities = new TrainerProfileProjectionEntities();

        public List<tblTrainerDetail> GetAllTrainers()
        {
            return trainerProfileProjectionEntities.tblTrainerDetails.ToList();
        }

        public List<USP_GetTrainerAvailability_Result> GetTrainers(int trainerId, DateTime startDate, DateTime endDate)
        {    
            return trainerProfileProjectionEntities.USP_GetTrainerAvailability(trainerId, startDate, endDate).ToList();
        }
        
        public List<tblTrainerDetail> GetAvailableTrainers()
        {           

            return trainerProfileProjectionEntities.tblTrainerDetails.Where(m => m.StartDate == null).ToList();
        }

        public int ProjectTrainer(int vendorId, int trainerId, DateTime startDate, DateTime endDate)
        {
            return trainerProfileProjectionEntities.USP_ProjectTrainerProfile(vendorId, trainerId, startDate, endDate);
        }
    }
}
