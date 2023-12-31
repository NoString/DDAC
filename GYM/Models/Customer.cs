﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GYM.Models;

public partial class Customer
{
    public int Id { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "The {0} must be less than 20 word")]
    public string Username { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "The {0} must be less than 20 word")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "The {0} must be less than 20 word")]
    [DisplayName("Real Name")]
    public string Realname { get; set; }

    [Required]
    public string Gender { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "The {0} must be less than 20 word")]
    public string Mobile { get; set; }

    [Required]
    [DisplayName("E-mail")]
    [EmailAddress]
    public string Email { get; set; }
}