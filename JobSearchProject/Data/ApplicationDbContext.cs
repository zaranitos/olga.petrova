﻿using JobSearchProject.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace JobSearchProject.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Specialization> Specialization { get; set; }
        public virtual DbSet<DriverVacancy> DriverVacancy { get; set; }
        public virtual DbSet<Vacancy> Vacancy { get; set; }

        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
    }
}