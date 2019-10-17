using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TrainerModel
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
