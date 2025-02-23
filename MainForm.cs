using BookSalesSystem2._0.BookFolder;
using BookSalesSystem2._0.OrderFolder;

namespace BookSalesSystem2._0
{
    public partial class MainForm : Form
    {
        private readonly BookService bookService = new BookService();
        private readonly OrderService orderService = new OrderService();

        public MainForm()
        {
            InitializeComponent();
            LoadControl(new MainControl());
            Task.Run(async () => await EnsureDatabaseCreatedAsync());
            Task.Run(async () => SyncDataAsync());
        }
        private async Task SyncDataAsync()
        {
            await bookService.SyncJsonToDatabase();
            await orderService.SyncJsonToDatabase();
        }

        public async Task EnsureDatabaseCreatedAsync()
        {
            using (var context = new BookSalesSystemContext())
            {
                if (DatabaseAvailable.IsDatabaseAvailable())
                {
                    await context.Database.EnsureCreatedAsync();
                }
            }
        }

        public void LoadControl(Control control)
        {
            panelContainer.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(control);
        }

        private void bookControlButton_Click(object sender, EventArgs e)
        {
            LoadControl(new BookControl());
        }

        private void orderControlButton_Click(object sender, EventArgs e)
        {
            LoadControl(new OrderControl());
        }

        private void reportControlButton_Click(object sender, EventArgs e)
        {
            LoadControl(new ReportsControl());
        }

        private void mainControlButton_Click(object sender, EventArgs e)
        {
            LoadControl(new MainControl());
        }
    }
}
