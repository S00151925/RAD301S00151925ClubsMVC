﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RAD301S00151925Clubs.Models.ClubModel
{
    [Table("Student")]
    public class Student
    {
        [Key, Column(Order = 1)]
        public int memberID { get; set; }
        [Key, Column(Order = 2)]
        public string StudentID { get; set; }
        public bool approved { get; set; }
    }
}