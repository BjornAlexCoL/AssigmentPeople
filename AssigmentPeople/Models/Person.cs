using System.ComponentModel.DataAnnotations;

namespace AssignmentPeople.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }
        [Display(Name = "City")]
        public string CityName { get; set; }
    }
}
