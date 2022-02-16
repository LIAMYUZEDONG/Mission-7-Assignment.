using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookProject.Models
{
    public partial class Book
    {
        [Key]
        [Required]
        //public long ProjectId { get; set; }
        //public string ProjectName { get; set; }
        //public string ProjectType { get; set; }
        //public string ProjectRegionalProgram { get; set; }
        //public int ProjectImpact { get; set; }
        //public string ProjectPhase { get; set; }
        //public string ProjectFunctionalityStatus { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Category { get; set; }
        public string Classification { get; set; }
        public int PageCount { get; set; }
        public int Price { get; set; }
        public int ISBN { get; set; }



    }
}
