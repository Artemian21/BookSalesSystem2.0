using System.ComponentModel.DataAnnotations;

namespace BookSalesSystem2._0.OrderFolder
{
    public class Order
    {
        [Key]
        [Required(ErrorMessage = "Це обов'язкове поле")]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Це обов'язкове поле")]
        [StringLength(100, ErrorMessage = "Ім'я не може перевищувати 100 символів")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Це обов'язкове поле")]
        [StringLength(100, ErrorMessage = "Прізвище не може перевищувати 100 символів")]
        public string CustomerSurname { get; set; }

        [Required(ErrorMessage = "Це обов'язкове поле")]
        [EmailAddress(ErrorMessage = "Некоректний формат email")]
        public string CustomerEmail { get; set; }

        [Required(ErrorMessage = "Це обов'язкове поле")]
        [Phone(ErrorMessage = "Некоректний формат номера телефону")]
        public string PhoneNumber { get; set; }

        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "Це обов'язкове поле")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Загальна сума повинна бути більше 0")]
        public decimal TotalPrice { get; set; }

        [Required(ErrorMessage = "Це обов'язкове поле")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Це обов'язкове поле")]
        public List<OrderItem> Books { get; set; } = new List<OrderItem>();

        [Required(ErrorMessage = "Це обов'язкове поле")]
        public string PaymentStatus { get; set; }
        public string Notes { get; set; }
    }
}
