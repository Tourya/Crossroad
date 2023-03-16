using Microsoft.AspNetCore.Identity;

namespace BMG_Schedule.Data.Models
{
    public class Role : IdentityRole<int>
    {
        public override int Id { get => base.Id; set => base.Id = value; }
    }
}
