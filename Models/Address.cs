using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NET_3.Models
{
    public class Address
    {
        /*[Display(Name = "Twoja ulubiona ulica")]
        [Required(ErrorMessage = "Podaj ulice")]
        public string Street { get; set; }

        [Display(Name = "Zipcode")]
        [StringLength(60, MinimumLength = 3), Required]
        public string ZipCode { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Podaj miasto")]
        public string City { get; set; }*/

        public int Id { get; set; }

        [Display(Name = "Number")]
        [Required]
        [Range(1, 1000)]
        public int Number { get; set; }

public string Result { get; set; }

        public DateTime Date { get; set; }

        public Address()
        {

        }

        public void MakesValues(int number)
        {
            if(number % 3 == 0 && number % 5 != 0)
            {
                Result = "Fizz";
                Date = DateTime.Now;
            }

            else if (number % 3 != 0 && number % 5 == 0)
            {
                Result = "Buzz";
                Date = DateTime.Now;
            }

            else if (number % 3 == 0 && number % 5 == 0)
            {
                Result = "FizzBuzz";
                Date = DateTime.Now;
            }

            else 
            {
                Result = "Brak";
                Date = DateTime.Now;
            }

        }


    }
}
