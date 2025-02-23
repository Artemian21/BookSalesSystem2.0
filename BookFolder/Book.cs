using System.ComponentModel.DataAnnotations;

namespace BookSalesSystem2._0.BookFolder
{
    public class Book
    {
        [Required(ErrorMessage = "Це обов'язкове поле")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Це обов'язкове поле")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Це обов'язкове поле")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Це обов'язкове поле")]
        public string Genre { get; set; }
        [Required(ErrorMessage = "Це обов'язкове поле")]
        [RegularExpression(@"^\d{13}$", ErrorMessage = "ISBN має містити 13 цифр.")]
        public string ISBN { get; set; }
        [Required(ErrorMessage = "Це обов'язкове поле")]
        [Range(0, double.MaxValue, ErrorMessage = "Ціна не може бути меншою за 0")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Це обов'язкове поле")]
        [Range(0, int.MaxValue, ErrorMessage = "Кількість не може бути меншою за 0")]
        public int Stock { get; set; }

    }
}
