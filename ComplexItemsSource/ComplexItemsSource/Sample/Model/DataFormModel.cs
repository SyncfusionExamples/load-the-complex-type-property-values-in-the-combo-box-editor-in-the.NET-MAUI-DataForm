using System.ComponentModel.DataAnnotations;

namespace ComplexItemsSource
{
    public class DataFormModel
    {
        public DataFormModel()
        {
            this.Name = string.Empty;
            this.Address = string.Empty;
            this.Department = string.Empty;
        }

        [Display(Prompt = "Enter your name")]
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Display(Prompt = "Enter your address", Name = "Address")]
        [Required(ErrorMessage = "Please enter your address")]
        public string Address { get; set; }

        [Display(Prompt = "Select a gender")]
        [Required(ErrorMessage = "Please select a gender")]
        public Gender Gender { get; set; }

        [Display(Prompt = "Please select your department")]
        public string Department { get; set; }

        [Display(Name = "Ready To Relocate")]
        public bool ReadyToRelocate { get; set; }

        [Display(Name = "Date of Joining")]
        public DateTime DateOfJoining { get; set; }
        public string FeedBack { get; set; } = string.Empty;
    }
    public class ComplexModel
    {
        public string Name { get; set; } = string.Empty;
        public int DepartmentID { get; set; }
    }
    public enum Gender
    {
        Male,
        Female,
        Others
    }
}