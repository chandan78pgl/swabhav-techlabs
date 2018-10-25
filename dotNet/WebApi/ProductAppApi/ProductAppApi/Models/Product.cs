using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductAppApi.Models
{
    public class Product
    {
        [Key]
        public int ProductId { set; get; }
        public string ProductName { set; get; }
        public string ProductCode { set; get; }
        public DateTime ReleaseDate { set; get; }
        public string Description { set; get; }
        public double Price { set; get; }
        public double StarRating { set; get; }
        public string ImageUrl { set; get; }
    }
}