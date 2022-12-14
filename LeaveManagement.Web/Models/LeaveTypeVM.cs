using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {
        
        public int Id { get; set; }
        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Default Number Of Days")]
        [Required]
        [Range(1, 25, ErrorMessage = "Please eneter a number between 1 to 25")]
        public int DefaultDays { get; set; }
    }
}
