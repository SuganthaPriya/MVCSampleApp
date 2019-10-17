using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public interface ITrainerProfileDL
    {
        List<tblTrainerDetail> GetAllTrainers();
        List<USP_GetTrainerAvailability_Result> GetTrainers(int trainerId, DateTime startDate, DateTime endDate);
        List<tblTrainerDetail> GetAvailableTrainers();
        int ProjectTrainer(int vendorId, int trainerId, DateTime startDate, DateTime endDate);
    }
}
