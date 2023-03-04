namespace BMG_Schedule.Data.Models
{
    public class WorkingDay
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int RecordTypeId { get; set; }
        public int EmployeeId { get; set; }
        public IEnumerable<Exit>? Exits { get; set; }

        public override string ToString()
        {
            return (Start, End, EmployeeId).ToString();
        }
    }


}
