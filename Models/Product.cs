using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rzr_pages_mariadb.Models
{

    public class Product
    {
        public uint ProductID { get; set; }

        [Required]
        [StringLength(24)]
        public string Title { get; set; }

        [Required]
        public uint Stock { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal Price { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }





    }

}