using EF_Session1.Context;
using Microsoft.EntityFrameworkCore;

namespace EF_Session1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           EnterPriseDbContext dbContext = new EnterPriseDbContext();
           // dbContext.Employees.Add();

            // apply migration to db: EF => C# code ==> sql statment
              // 1.code
             // dbContext.Database.Migrate(); //Apply Ups of all Migrateions [Not Applied only]

              // 2.package manger console

        }
    }
}
