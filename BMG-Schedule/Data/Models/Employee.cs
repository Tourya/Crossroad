using System.ComponentModel.DataAnnotations;

namespace BMG_Schedule.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Моля, въведете името на служителя.")]
        [StringLength(50)]
        public string? FirstName { get; set; }

        [Required(ErrorMessage ="Моля, въведете фамилията на служителя.")]
        [StringLength(50)]
        public string? LastName { get; set; }

        public string? Info { get; set; }

        public IEnumerable<WorkingDay>? WorkingDays { get; set; }

        //public IEnumerable<Exit>? Exits { get; set; }


        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
