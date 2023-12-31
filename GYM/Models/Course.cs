﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GYM.Models;

public partial class Course
{
    public int Id { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "The {0} must be less than 20 word")]
    [DisplayName("Course Name")]
    public string CourseName { get; set; }

    [Required]
    [DisplayName("Duration(Minutes)")]
    public int? Duration { get; set; }

    [Required]
    [DisplayName("Start Date")]
    [DataType(DataType.DateTime)]
    public DateTime? StartDate { get; set; }

    [Required]
    [DisplayName("Coach Name")]
    [StringLength(20, ErrorMessage = "The {0} must be less than 20 word")]
    public string CoachName { get; set; }

    [Required]
    [DisplayName("Coach Phone")]
    [StringLength(20, ErrorMessage = "The {0} must be less than 20 word")]
    public string CoachPhone { get; set; }

    [Required]
    [DisplayName("Burn Calorie(By kilocalorie)")]
    public int? BurnCalories { get; set; }
}