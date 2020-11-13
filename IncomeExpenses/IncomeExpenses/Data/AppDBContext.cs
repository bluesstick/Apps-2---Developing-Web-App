using IncomeExpenses.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IncomeExpenses.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("DefaultConnection")
        {
                
        }

        public DbSet<IncomeExpensesEM> incomeExpenses { get; set; }

    }
}