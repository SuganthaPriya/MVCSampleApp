using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Globalization;

namespace TrainerProfile.Tests
{
    [TestClass()]
    public class MSTests
    {
        ITrainerProfileBL trainer = new TrainerProfileBL();
        [TestMethod()]
        public void GetAllTrainersTest()
        {
            List<tblTrainerDetail> trainersList = new List<tblTrainerDetail>();
            trainersList = trainer.GetAllTrainers();
            int i = 0;
            Assert.AreNotEqual(i,trainersList.Count);
        }

        [TestMethod()]
        public void GetTrainersTest()
        {
            List<USP_GetTrainerAvailability_Result> trainerList = new List<USP_GetTrainerAvailability_Result>();                     
            DateTime.TryParseExact("02/03/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime startDate);
            DateTime.TryParseExact("02/08/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime endDate);
            trainerList = trainer.GetTrainers(1028, startDate, endDate);
            int i = 0;
            Assert.AreNotEqual(i,trainerList.Count);
        }

        [TestMethod()]
        public void StartDateEndDateNullTest()
        {
            string startdate = "";
            string Enddate = "";
            if (string.IsNullOrEmpty(startdate)|| string.IsNullOrEmpty(Enddate))
                Assert.Fail();
        }

        [TestMethod()]
        public void InavlidStartDateEndDateTest()
        {
            bool date = false;
            DateTime.TryParseExact("02/03/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime startDate);
            DateTime.TryParseExact("03/08/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime endDate);
            if (startDate < endDate)
                date = true;
            Assert.AreEqual(true, date);

        }
    }
}