using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rzr_pages_mariadb.Models
{

    public class Rating
    {
        public uint RatingID { get; set; }

        [Required]
        public virtual Product Product { get; set; }

        [Required]
        public uint Score { get; set; }

        public string Description { get; set; }



    }

}