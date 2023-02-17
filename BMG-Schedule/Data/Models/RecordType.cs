using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMG_Schedule.Data.Models
{
    public class RecordType
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
