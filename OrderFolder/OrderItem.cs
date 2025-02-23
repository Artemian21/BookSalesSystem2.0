using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSalesSystem2._0.OrderFolder
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Це обов'язкове поле")]
        public int BookID { get; set; }

        [Required(ErrorMessage = "Це обов'язкове поле")]
        [ForeignKey("Order")]
        public int OrderID { get; set; }

        [Required(ErrorMessage = "Це обов'язкове поле")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Це обов'язкове поле")]
        [Range(1, int.MaxValue, ErrorMessage = "Кількість повинна бути більше 0")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Це обов'язкове поле")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Ціна повинна бути більше 0")]
        public decimal Price { get; set; }

        [JsonIgnore]
        [JsonProperty(ReferenceLoopHandling = ReferenceLoopHandling.Ignore)]
        public Order Order { get; set; }
    }
}
