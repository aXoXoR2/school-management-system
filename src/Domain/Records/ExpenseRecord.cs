﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Domain.Records
{
    public class ExpenseRecord : Entity
    {
        [Required]
        public Expense Expense { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
            ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        
        [Required]
        [Range(1,99999)]
        public int Amount { get; set; }
        
        [Required]
        [Range(0.01,99999)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public double Value { get; set; }
    }
}
