using System.ComponentModel.DataAnnotations;

namespace WebUI.PBYS.Shared.Dto
{
    public class CategoryDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez")]
        public string Name { get; set; }
        public int CategoryType { get; set; }
 
        public string CategoryTypeName { get; set; }
        public bool Status { get; set; } = true;
    }
}
