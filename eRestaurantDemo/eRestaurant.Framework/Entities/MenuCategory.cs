using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Framework.Entities
{
    // start off by making it a public class
    public class MenuCategory
    {
        [Key] // This attribute identifies the menucategoryid property as mapping to a primary key
        public int MenuCategoryID { get; set; }

        [Required(ErrorMessage = "A Description is required (5-35 characters)")]
        [StringLength(35, MinimumLength = 5, ErrorMessage = "Descriptions must be from 5 to 35 characters in length")]
        public string Description { get; set; }

        // Navigation Property
        public virtual ICollection<Item> Items { get; set; }

    }
}
