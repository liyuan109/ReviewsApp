using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcReviews.Models
{
    public class Review
    {
        public int ID { get; set; }
        public string Company { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Reviews { get; set; }
    }
    public class ReviewDBContext : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
    }
}