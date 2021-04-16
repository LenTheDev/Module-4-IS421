using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.HasData
            (
                new Assignment
                {
                    Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991873"),
                    AssignmentName = "1st Assignment",
                },
                new Assignment
                {
                    Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                    AssignmentName = "2nd Assignment",
                }
            );
        }
    }
}