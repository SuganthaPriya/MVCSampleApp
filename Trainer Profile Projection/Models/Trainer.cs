using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trainer_Profile_Projection.Models
{
    public class Trainer
    {
        public int VendorId { get; set; }
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public int Experience { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}