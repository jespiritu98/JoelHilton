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
       
        [Required(ErrorMessage = "Can't watch a movie without knowing the title...")]
        public string Title { get; set; }
        [Required(ErrorMessage ="I want to know when it was made!")]
        public string Year { get; set; }
        [Required(ErrorMessage ="Who directed it?")]
        public string Director { get; set; }
        [Required(ErrorMessage ="Is it a good enough rating for my wife to let me watch it?")]
        public string Rating { get; set; }
        
        public bool Edited { get; set; }
      
        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }

        //Build Foreign Key Relationship
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
