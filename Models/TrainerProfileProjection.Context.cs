﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TrainerProfileProjectionEntities : DbContext
    {
        public TrainerProfileProjectionEntities()
            : base("name=TrainerProfileProjectionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblTrainerDetail> tblTrainerDetails { get; set; }
    
        public virtual ObjectResult<USP_GetTrainerAvailability_Result> USP_GetTrainerAvailability(Nullable<int> trainerId, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate)
        {
            var trainerIdParameter = trainerId.HasValue ?
                new ObjectParameter("TrainerId", trainerId) :
                new ObjectParameter("TrainerId", typeof(int));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GetTrainerAvailability_Result>("USP_GetTrainerAvailability", trainerIdParameter, startDateParameter, endDateParameter);
        }
    
        public virtual int USP_ProjectTrainerProfile(Nullable<int> vendorId, Nullable<int> trainerId, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate)
        {
            var vendorIdParameter = vendorId.HasValue ?
                new ObjectParameter("VendorId", vendorId) :
                new ObjectParameter("VendorId", typeof(int));
    
            var trainerIdParameter = trainerId.HasValue ?
                new ObjectParameter("TrainerId", trainerId) :
                new ObjectParameter("TrainerId", typeof(int));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_ProjectTrainerProfile", vendorIdParameter, trainerIdParameter, startDateParameter, endDateParameter);
        }
    }
}
