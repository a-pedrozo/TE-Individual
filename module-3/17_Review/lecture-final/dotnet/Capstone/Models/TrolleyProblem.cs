using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class TrolleyProblem
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(300)]
        public string Problem { get; set; }
        public int TimesPulled { get; set; }
        public int TimesNotPulled { get; set; }
    }
}
