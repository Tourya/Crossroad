using System.ComponentModel.DataAnnotations;

namespace BMG_Schedule.Data.Models
{
    public class Exit
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Моля, въведете датата и часа за начало на излизането.")]
        public DateTime Start { get; set; }

        [Required(ErrorMessage = "Моля, въведете датата и часа за край на излизането.")]
        public DateTime End { get; set; }

        public bool IsPersonal { get; set; }

        [StringLength(1000)]
        public string? Reason { get; set; }

        public int EmployeeId { get; set; }
        public int WorkingDayId { get; set; }
    }
}
