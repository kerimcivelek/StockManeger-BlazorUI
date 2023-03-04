using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.PBYS.Shared.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public int CategoryType { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public string? Ram { get; set; }
        public string? Capacity { get; set; }
        public string? Colour { get; set; }
        public string? Note { get; set; }
        public int Min { get; set; } = 0;
        public int Max { get; set; } = 0;
        public bool status { get; set; } = true;
    }
}
