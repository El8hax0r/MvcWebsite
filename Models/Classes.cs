using System;
using System.ComponentModel.DataAnnotations;

namespace MvcWebsite.Models
{
    public class Classes
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Class { get; set; }
        public string UserClass { get; set; }

        [DataType(DataType.Date)]
        public DateTime SessionDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Paid { get; set; }
    }
}