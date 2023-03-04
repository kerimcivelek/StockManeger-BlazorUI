using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.PBYS.Shared.Dto
{
    public class ProductStockDetailDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string? CustomerDescrition { get; set; }
        public string InOut { get; set; }
        public string UsedDivace { get; set; }
        public string? Tckn { get; set; }
        public string? IMEI { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float TotalPrice { get; set; }
        public string? Descrition { get; set; }
        public string username { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
