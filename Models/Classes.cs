using System;
using System.ComponentModel.DataAnnotations;

namespace MvcWebsite.Models
{
    public class Classes
    {
        public int UserId { get; set; }
        public int ClassId { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public bool UserIsAdmin { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public decimal ClassPrice { get; set; }
    }
}