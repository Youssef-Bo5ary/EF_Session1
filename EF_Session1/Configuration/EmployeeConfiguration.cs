using EF_Session1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF_Session1.Configuration
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        //4rth way of Mapping === Configuration =======
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(E => E.EmpID);
            builder.Property(nameof(Employee.EmpID)).UseIdentityColumn(1, 1);
            builder.Property(E => E.Name).HasColumnType("Varchar").HasMaxLength(50).HasDefaultValue("Ahmed");

            builder.Property(E => E.Salary).HasColumnType("money");
        }
    }
}
