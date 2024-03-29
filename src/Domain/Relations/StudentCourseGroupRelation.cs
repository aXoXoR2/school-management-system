﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Domain.Relations
{
    public class StudentCourseGroupRelation : Entity
    {
        [Required]
        [ForeignKey("StudentFK")]
        public Student Student { get; set; }
        
        [Required]
        [ForeignKey("GroupFK")]
        public CourseGroup Group { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
            ApplyFormatInEditMode = true)]
        public DateTime StartDate{ get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
            ApplyFormatInEditMode = true)]
        public DateTime EndDate{ get; set; }
    }
}
