﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Course
    {
        [Column("Course_ID")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Course name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string CourseName { get; set; }

        public ICollection<User> Users { get; set; }
    }
}