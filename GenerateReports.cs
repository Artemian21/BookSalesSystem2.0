using BookSalesSystem2._0.OrderFolder;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using OfficeOpenXml;

namespace BookSalesSystem2._0
{
    public class GenerateReports
    {
        private List<Order> orders;

        public GenerateReports(List<Order> orders)
        {
            this.orders = orders;
        }

        public bool GenerateFinancialReportPDF(string filePath, DateTime startDate, DateTime endDate)
        {
            if (!IsValidFileExtension(filePath, "PDF"))
                return false;

            var directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            using (var writer = new PdfWriter(filePath))
            using (var pdf = new PdfDocument(writer))
            {
                var document = new iText.Layout.Document(pdf);
                var font = PdfFontFactory.CreateFont("C:/Windows/Fonts/arial.ttf", PdfEncodings.IDENTITY_H);
                document.SetFont(font);

                document.Add(new Paragraph($"Фінансовий звіт ({startDate:dd.MM.yyyy} - {endDate:dd.MM.yyyy})"));

                var dailySales = orders
                    .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                    .GroupBy(o => o.OrderDate.Date)
                    .Select(g => new
                    {
                        Date = g.Key,
                        DailyTotal = g.Sum(o => o.Books.Sum(b => b.Quantity * b.Price))
                    })
                    .OrderBy(d => d.Date)
                    .ToList();

                var totalSales = dailySales.Sum(d => d.DailyTotal);

                var table = new iText.Layout.Element.Table(2);
                table.AddHeaderCell("Дата");
                table.AddHeaderCell("Сума продажів");

                foreach (var item in dailySales)
                {
                    table.AddCell(item.Date.ToString("dd.MM.yyyy"));
                    table.AddCell(item.DailyTotal.ToString("C"));
                }

                document.Add(table);

                document.Add(new Paragraph($"Загальна сума продажів: {totalSales:C}"));

                return true;
            }
        }

        public bool GenerateFinancialReportExcel(string filePath, DateTime startDate, DateTime endDate)
        {
            if (!IsValidFileExtension(filePath, "Excel"))
                return false;

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets.Add("Фінансовий звіт");
                worksheet.Cells[1, 1].Value = "Дата";
                worksheet.Cells[1, 2].Value = "Сума продажів";

                var dailySales = orders
                    .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                    .GroupBy(o => o.OrderDate.Date)
                    .Select(g => new
                    {
                        Date = g.Key,
                        DailyTotal = g.Sum(o => o.Books.Sum(b => b.Quantity * b.Price))
                    })
                    .OrderBy(d => d.Date)
                    .ToList();

                int row = 2;
                foreach (var item in dailySales)
                {
                    worksheet.Cells[row, 1].Value = item.Date.ToString("dd.MM.yyyy");
                    worksheet.Cells[row, 2].Value = item.DailyTotal;
                    row++;
                }

                worksheet.Cells[row, 1].Value = "Загальна сума продажів";
                worksheet.Cells[row, 2].Value = dailySales.Sum(d => d.DailyTotal);

                package.SaveAs(new FileInfo(filePath));
                return true;
            }
        }

        public bool GenerateSalesReportPDF(string filePath, DateTime startDate, DateTime endDate)
        {
            if (!IsValidFileExtension(filePath, "PDF"))
                return false;

            var directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            using (var writer = new PdfWriter(filePath))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var document = new iText.Layout.Document(pdf);
                    var font = PdfFontFactory.CreateFont("C:/Windows/Fonts/arial.ttf", PdfEncodings.IDENTITY_H);
                    document.SetFont(font);

                    document.Add(new Paragraph($"Звіт про продажі ({startDate:dd.MM.yyyy} - {endDate:dd.MM.yyyy})"));

                    var table = new iText.Layout.Element.Table(3);
                    table.AddHeaderCell("Назва книги");
                    table.AddHeaderCell("Кількість продано");
                    table.AddHeaderCell("Ціна");

                    var salesData = orders
                        .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                        .SelectMany(o => o.Books)
                        .GroupBy(b => b.Title)
                        .Select(g => new
                        {
                            BookTitle = g.Key,
                            QuantitySold = g.Sum(b => b.Quantity),
                            Price = g.First().Price
                        });

                    foreach (var item in salesData)
                    {
                        table.AddCell(item.BookTitle);
                        table.AddCell(item.QuantitySold.ToString());
                        table.AddCell(item.Price.ToString("C"));
                    }

                    document.Add(table);

                    var totalSales = salesData.Sum(b => b.QuantitySold * b.Price);
                    document.Add(new Paragraph($"Загальна сума продажів: {totalSales:C}"));
                }
                return true;
            }
        }

        public bool GenerateExcelReport(string filePath, DateTime startDate, DateTime endDate)
        {
            if (!IsValidFileExtension(filePath, "Excel"))
                return false;

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                string sheetName = "Звіт_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                var worksheet = package.Workbook.Worksheets.Add(sheetName);

                worksheet.Cells[1, 1].Value = "Назва книги";
                worksheet.Cells[1, 2].Value = "Кількість продано";
                worksheet.Cells[1, 3].Value = "Ціна";

                var salesData = orders
                        .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                        .SelectMany(o => o.Books)
                        .GroupBy(b => b.Title)
                        .Select(g => new
                        {
                            BookTitle = g.Key,
                            QuantitySold = g.Sum(b => b.Quantity),
                            Price = g.First().Price
                        }).ToList();

                int row = 2;
                foreach (var item in salesData)
                {
                    worksheet.Cells[row, 1].Value = item.BookTitle;
                    worksheet.Cells[row, 2].Value = item.QuantitySold;
                    worksheet.Cells[row, 3].Value = item.Price;
                    row++;
                }

                package.SaveAs(new FileInfo(filePath));
            }
            return true;
        }

        private bool IsValidFileExtension(string filePath, string reportType)
        {
            string fileExtension = Path.GetExtension(filePath).ToLower();

            if (reportType == "PDF" && fileExtension != ".pdf")
            {
                MessageBox.Show("Невірне розширення файлу для PDF звіту. Виберіть файл з розширенням .pdf.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (reportType == "Excel" && fileExtension != ".xlsx")
            {
                MessageBox.Show("Невірне розширення файлу для Excel звіту. Виберіть файл з розширенням .xlsx.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
