using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace OnlineStoreForJewellery.Models
{
    public class Contact
    {
        [Required]
        public string Name { get; set; }


        [Required]
        public string Email { get; set; }


        [Required]
        public string Message { get; set; }

        
    }
}
