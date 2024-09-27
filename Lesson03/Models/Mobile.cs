using System.ComponentModel.DataAnnotations;

namespace Lesson04.Models
{
    //tạo class trong Model dùng để generate ra bảng trong DB
    //VD: class Mobile => table Mobile
    public class Mobile
    {
        public int Id { get; set; } //primary key

        public string Brand { get; set; }

        //add validation cho model
        [MinLength(1, ErrorMessage = "Minimum character is 1")]
        [MaxLength(30, ErrorMessage = "Maximum character is 30")]
        public string Model { get; set; }

        [Range(1, 100, ErrorMessage = "Quantity must be from 1 to 100")]
        public int Quantity { get; set; }

        public decimal Price { get; set; }

        [Url(ErrorMessage = "Image Link is not valid")]
        public string Image { get; set; }
    }
}
