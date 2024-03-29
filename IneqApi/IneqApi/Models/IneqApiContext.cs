﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace IneqApi.Models
{
    public class IneqApiContext: DbContext

    {
        public IneqApiContext() : base("IneqApiContext")
        {
        }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Component> Components { get; set; }

        public DbSet<ComponentType> ComponentTypes { get; set; }

        public DbSet<Equipment> Equipments { get; set; }

        public DbSet<EquipmentType> EquipmentTypes { get; set; }

        public DbSet<Model> Models { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<User> Users { get; set; }





        protected override  void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}
