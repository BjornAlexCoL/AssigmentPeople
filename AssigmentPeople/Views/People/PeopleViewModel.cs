using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssignmentPeople.Models
{
    public class PeopleViewModel
    {
   
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(100)]
        public string CityName { get; set; }

        public List<string> CityList { get; set; }
    }
}
