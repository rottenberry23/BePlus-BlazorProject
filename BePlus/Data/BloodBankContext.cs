﻿using BePlus.Models;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace BePlus.Data
{
    public class BloodBankDbContext : DbContext
    {
        public BloodBankDbContext(DbContextOptions<BloodBankDbContext> options)
            : base(options) {}
        public DbSet<Donor> Donors { get; set; }
        public DbSet<StoragePoint> StoragePoints { get; set; }
        public DbSet<CollectionPoint> CollectionPoints { get; set; }
        public DbSet<RegisteredHospital> RegisteredHospitals { get; set; }
        public DbSet<DeliveryStaff> DeliveryStaffs { get; set; }
        public DbSet<BloodRequest> BloodRequest { get; set; }
        public DbSet<CollectionStaff> CollectionStaffs { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<BloodStored> BloodStoreds { get; set; }
        public DbSet<BloodInTransit> BloodInTransits { get; set; }
        public DbSet<HospitalRequest> HospitalRequests { get; set; }
        public DbSet<StoragePointRequest> StoragePointRequests { get; set; }
    }
}
