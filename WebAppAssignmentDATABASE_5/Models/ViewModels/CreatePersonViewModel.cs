using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppAssignmentDATABASE_5.Models.ViewModel
{
    public class CreatePersonViewModel
    {
        [DataType(DataType.Text)]
        [StringLength(20, MinimumLength =1)]
        [Required(ErrorMessage = "* Please enter name"), MaxLength(50)]
        [Display(Name = "Name")]
        public string PersonName { get; set; }


        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "* Please enter phonenumber"), MaxLength(30)]
        [Display(Name = "PhoneNumber")]
        public string PersonPhoneNumber { get; set; }


        [DataType(DataType.Text)]
        [Required(ErrorMessage = "* Please enter city"), MaxLength(50)]
        [Display(Name = "City")]
        [StringLength(15,MinimumLength =1)]
        public string PersonCity { get; set; }

        [Key]
        public int Id { get; set; }
        public CreatePersonViewModel()
        {

        }
    }

}
