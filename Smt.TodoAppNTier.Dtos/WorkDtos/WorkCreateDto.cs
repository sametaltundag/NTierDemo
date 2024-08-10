using Smt.TodoAppNTier.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smt.TodoAppNTier.Dtos.WorkDtos
{
    public class WorkCreateDto :IDto
    {
        [Required(ErrorMessage ="Definition is requeried")]
        public string Definition { get; set; }
        public bool IsCompleted { get; set; }
    }
}
