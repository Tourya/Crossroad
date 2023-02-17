namespace BMG_Schedule.Data.Models
{
    public class Exit
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool IsPersonal { get; set; }
        public string? Reason { get; set; }
        public int EmployeeId { get; set; }
    }
}
