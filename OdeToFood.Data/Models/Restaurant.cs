using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        //[RegularExpression("")]
        //[Range(1,10)]
        public string Name { get; set; }

        //[DisplayFormat(DataFormatString = )] look up an example
        //[DisplayFormat(NullDisplayText = "")]
        //[DataType(DataType.Password)]  will render input type password
        [Display(Name="Type of food")] //will render the label of Type of food and not the Name prop
        public CuisineType Cuisine { get; set; }
    }
}
