﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcWebsite.Models
{
    public class Classes
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ClassId { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public bool UserIsAdmin { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }

        public float ClassPrice { get; set; }
    }
}