using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.PBYS.Shared.Dto
{
    public class TechnicalServiceDto
    {
        public int Id { get; set; }
        public string CustomerDescrition { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Gsm { get; set; }
        public string BugDefination { get; set; }
        public string? DescriptionOfAction { get; set; }
        public int ActionStatus { get; set; } = 0;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int UserId { get; set; }
    }
}
