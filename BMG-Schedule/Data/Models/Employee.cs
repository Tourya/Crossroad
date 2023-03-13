using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BMG_Schedule.Data.Models
{
    public class Employee : IdentityUser<int>
    {
        //public int Id { get; set; }
        public override int Id { get => base.Id; set => base.Id = value; }

        [Required(ErrorMessage = "Моля, въведете името на служителя.")]
        [StringLength(50)]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Моля, въведете фамилията на служителя.")]
        [StringLength(50)]
        public string? LastName { get; set; }

        public string? Info { get; set; }

        public IEnumerable<WorkingDay>? WorkingDays { get; set; }

        public IEnumerable<Exit>? Exits { get; set; }


        public (double hours, int noWorkingDays, int businessTrip, int sick, int offPayed, int offUnpayed) CountHours(int month, int year)
        {
            var currentMonthWorking = WorkingDays?
                                   .Where(day => day.Start.Year == year)
                                   .Where(day => day.Start.Month == month)
                                   .Where(day => day.RecordTypeId == 1)
                                   .ToArray();

            var currentMonthNoWorking = WorkingDays?
                                       .Where(day => day.Start.Year == year)
                                       .Where(day => day.Start.Month == month)
                                       .Where(day => day.RecordTypeId != 1)
                                       .ToArray();

            double hours = 0;
            var noWorkingDays = 0;
            var businessTrip = 0;
            var sick = 0;
            var offPayed = 0;
            var offUnpayed = 0;

            if (currentMonthNoWorking is not null)
            {
                noWorkingDays = currentMonthNoWorking.Length;

                foreach (var day in currentMonthNoWorking)  
                {
                    switch (day.RecordTypeId)
                    {
                        case 2:
                            businessTrip++;
                            break;
                        case 3:
                            offPayed++;
                            break;
                        case 4:
                            offUnpayed++;
                            break;
                        case 5:
                            sick++;
                            break;
                    }
                }

            }

            if (currentMonthWorking is not null)
            {

                foreach (var day in currentMonthWorking)
                {
                    if (day.Start != default(DateTime) && day.End != default(DateTime))
                    {
                        hours += Math.Round(day.End.Subtract(day.Start).TotalHours, 2);
                    }
                }

            }

            return (Math.Round(hours, 2), noWorkingDays, businessTrip, sick, offPayed, offUnpayed);
        }

        public double CountHours(WorkingDay workingDay)
        {
            double hours = 0;

            if (workingDay.Start != default(DateTime) && workingDay.End != default(DateTime))
            {
                hours = workingDay.End.Subtract(workingDay.Start).TotalHours;
            }

            return Math.Round(hours, 2);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
