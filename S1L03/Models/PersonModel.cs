using System.ComponentModel.DataAnnotations; // Add to project
//Ensure that CodeLens is activated
//Select >> Tools >> Options >> Text Editor >> All Languages >> CodeLens
namespace kiaraStudyGroup.Models
{
    public class PersonModel
    {
        //Quick property - type "prop" press tab x2
        //Complete the property details
        //This is the "Model" of "data source"

        [Display(Name = "Student Number")] //Add as decorator
        public string StudentNumber { get; set; }

        [Display(Name = "Name")] //Add as decorator
        public string Name { get; set; }
        
        [Display(Name = "Surname")] //Add as decorator
        public string Surname { get; set; }

        [Display(Name = "Email")] //Add as decorator
        // [Required(ErrorMessage = "Name is mandatory")]=> Example of manditory decorator
        public string Email { get; set; }
    }
}