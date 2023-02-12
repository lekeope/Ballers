﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ballers_API.Models
{
	public class User
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Access Levels:
        /// 0. General User - can join, book and organize matches
        /// 1. Employee - can manage bookings
        /// 2. Admin - employee function and can make other users employee and admin
        /// </summary>
        public int AccessLevel { get; set; } = 0;
    }
}