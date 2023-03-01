using System.ComponentModel.DataAnnotations;

namespace BMG_Schedule.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Моля, въведете името на служителя.")]
        [StringLength(50)]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Моля, въведете фамилията на служителя.")]
        [StringLength(50)]
        public string? LastName { get; set; }

        public string? Info { get; set; }

        public IEnumerable<WorkingDay>? WorkingDays { get; set; }

        //public IEnumerable<Exit>? Exits { get; set; }


        public double CountHours(int month, int year)
        {
            var currentMonthHours = WorkingDays?
                                   .Where(day => day.Start.Year == year)
                                   .Where(day => day.Start.Month == month)
                                   .Where(day => day.RecordTypeId == 1)
                                   .ToArray();
            double hours = 0;

            if (currentMonthHours is not null)
            {

                foreach (var day in currentMonthHours)
                {
                    hours += Math.Round(day.End.Subtract(day.Start).TotalHours, 2);
                }

            }

            return Math.Round(hours, 2);
        }

        public double CountHours(WorkingDay workingDay)
        {
            double hours = workingDay.End.Subtract(workingDay.Start).TotalHours;

            return Math.Round(hours, 2);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
