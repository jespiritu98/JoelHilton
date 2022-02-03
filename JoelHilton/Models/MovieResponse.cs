using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JoelHilton.Models
    //Create a Model for the Movie Form
{
    public class MovieResponse
    {
        [Key]
        [Required]
        public int ApplicationId { get; set; }
       
    
        public string Title { get; set; }
       
        public string Year { get; set; }
        
        public string Director { get; set; }
  
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
     
        public string Notes { get; set; }

        //Build Foreign Key Relationship
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
