﻿using BandTogether.Data.Entities.ResourceClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandTogether.Data.EntityConfigurations
{
    public class ResourceEntityConfig : EntityTypeConfiguration<Resource>
    {
        public ResourceEntityConfig()
        {
            //Primary Key
            this.HasKey(res => res.ResourceId);

            //Properties
            this.Property(res => res.Title).IsRequired().HasMaxLength(600);
            this.Property(res => res.Description).IsRequired();
            this.Property(res => res.DateCreated).IsRequired();
            this.Property(res => res.DateModified).IsOptional();
            this.Property(res => res.IsDownloadable).IsRequired();
            this.Property(res => res.IsPublic).IsRequired();
            this.Property(res => res.TeacherId).IsRequired();

            //One Resource to One File Relationship
            this.HasOptional(res => res.File)
                .WithOptionalPrincipal(file => file.Resource);
                //.WithRequiredDependent(file => file.Resource);
        }
    }
}
