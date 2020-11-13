using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IncomeExpenses.Models
{
    public class IncomeExpensesEM
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Operation")]
        public bool IsIncome { get; set; }

        [Required]
        public double Value { get; set; }

        [Display(Name = "Date of Entry")]
        public DateTime DateIncome { get; set; }
    }
}