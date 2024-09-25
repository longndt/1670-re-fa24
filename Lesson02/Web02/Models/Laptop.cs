using System.ComponentModel.DataAnnotations;

namespace Web02.Models
{
    public class Laptop
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        [MinLength(5, ErrorMessage = "Tên model tối thiểu 5 ký tự")]
        [MaxLength(25, ErrorMessage = "Tên model tối đa 25 ký tự")]
        public string Model { get; set; }
        public int Quantity { get; set; }
        [Range(100, 5000, ErrorMessage = "Giá tiền không hợp lệ")]
        public decimal Price { get; set; }
        [Url(ErrorMessage = "Link ảnh không hợp lệ")]
        public string Image { get; set; }
    }
}
