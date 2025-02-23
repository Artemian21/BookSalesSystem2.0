using BookSalesSystem2._0.OrderFolder;

namespace BookSalesSystem2._0
{
    public partial class ReportsControl : UserControl
    {
        private List<Order> orders = new List<Order>();
        private readonly OrderService orderService = new OrderService();
        private GenerateReports generateReports;

        public ReportsControl()
        {
            InitializeComponent();
            LoadOrdersAsync();
        }

        private async void LoadOrdersAsync()
        {
            orders = await orderService.GetOrdersAsync();
            generateReports = new GenerateReports(orders); // Ініціалізуємо generateReports один раз
        }

        private void pathButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF файли (*.pdf)|*.pdf|Excel файли (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Оберіть місце для збереження";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtpath.Text = saveFileDialog.FileName;
                }
            }
        }

        private void GenerateReport(string filePath, DateTime startDateReport, DateTime endDateReport, Func<string, DateTime, DateTime, bool> generateFunc, string successMessage, string errorMessage)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Оберіть місце для збереження файлу!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var isGenerated = generateFunc(filePath, startDateReport, endDateReport);
            if (isGenerated)
            {
                MessageBox.Show(successMessage, "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(errorMessage, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pdfButton_Click(object sender, EventArgs e)
        {
            string filePath = txtpath.Text;
            DateTime startDateReport = startDate.Value;
            DateTime endDateReport = endDate.Value;

            GenerateReport(filePath, startDateReport, endDateReport, generateReports.GenerateSalesReportPDF, "PDF звіт успішно збережено!", "Невдалося згенерувати звіт!");
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            string filePath = txtpath.Text;
            DateTime startDateReport = startDate.Value;
            DateTime endDateReport = endDate.Value;

            GenerateReport(filePath, startDateReport, endDateReport, generateReports.GenerateExcelReport, "Excel звіт успішно збережено!", "Невдалося згенерувати звіт!");
        }

        private void generatePdfFinButton_Click(object sender, EventArgs e)
        {
            string filePath = txtpath.Text;
            DateTime startDateReport = startDate.Value;
            DateTime endDateReport = endDate.Value;

            GenerateReport(filePath, startDateReport, endDateReport, generateReports.GenerateFinancialReportPDF, "PDF фінансовий звіт успішно збережено!", "Невдалося згенерувати фінансовий звіт!");
        }

        private void generateExcelFinButton_Click(object sender, EventArgs e)
        {
            string filePath = txtpath.Text;
            DateTime startDateReport = startDate.Value;
            DateTime endDateReport = endDate.Value;

            GenerateReport(filePath, startDateReport, endDateReport, generateReports.GenerateFinancialReportExcel, "Excel фінансовий звіт успішно збережено!", "Невдалося згенерувати фінансовий звіт!");
        }
    }
}

