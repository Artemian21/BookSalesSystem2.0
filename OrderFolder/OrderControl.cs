using System.Data;
using BookSalesSystem2._0.BookFolder;
using BookSalesSystem2._0.OrderFolder;

namespace BookSalesSystem2._0
{
    public partial class OrderControl : UserControl
    {
        private List<Book> booksList = new List<Book>();
        private Dictionary<int, NumericUpDown> quantityControls = new Dictionary<int, NumericUpDown>();
        private decimal totalPrice = 0;

        public OrderControl()
        {
            InitializeComponent();
            LoadAvailableBooks();
        }

        private async void LoadAvailableBooks()
        {
            try
            {
                var bookService = new BookService();
                var books = await bookService.GetBooksAsync();
                if (books != null && books.Any())
                {
                    booksList = books;
                    SetupControl();
                }
                else
                {
                    ShowErrorMessage("Немає доступних книг.");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Помилка завантаження книг: {ex.Message}");
            }
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void SetupControl()
        {
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.AutoScroll = true;
            LoadBooksToPanel();
        }

        private void LoadBooksToPanel(List<Book> books = null)
        {
            books ??= booksList;
            foreach (var book in books)
            {
                AddBookToPanel(book);
            }
        }

        private void AddBookToPanel(Book book)
        {
            Panel bookItemPanel = new Panel { Width = 1000, Height = 60, Padding = new Padding(3) };

            var chkSelect = new CheckBox { Text = book.Title, Width = 920, Height = 40, Tag = book.ID };
            var numQuantity = new NumericUpDown { Width = 50, Minimum = 1, Maximum = book.Stock, Left = 930, Top = 10, Enabled = book.Stock > 0 };

            chkSelect.CheckedChanged += (s, e) => ToggleQuantityEnabled(numQuantity, chkSelect.Checked);
            numQuantity.ValueChanged += (s, e) => UpdateTotalPrice();

            bookItemPanel.Controls.Add(chkSelect);
            bookItemPanel.Controls.Add(numQuantity);
            flowLayoutPanel.Controls.Add(bookItemPanel);
            quantityControls[book.ID] = numQuantity;
        }

        private void ToggleQuantityEnabled(NumericUpDown numQuantity, bool isEnabled)
        {
            numQuantity.Enabled = isEnabled;
            UpdateTotalPrice();
        }

        public List<OrderItem> GetSelectedBooks()
        {
            var selectedBooks = new List<OrderItem>();
            foreach (Control panel in flowLayoutPanel.Controls)
            {
                var checkBox = panel.Controls.OfType<CheckBox>().FirstOrDefault();
                var numericUpDown = panel.Controls.OfType<NumericUpDown>().FirstOrDefault();
                if (checkBox?.Checked == true && numericUpDown != null)
                {
                    selectedBooks.Add(CreateOrderItem(checkBox, numericUpDown));
                }
            }
            return selectedBooks;
        }

        private OrderItem CreateOrderItem(CheckBox checkBox, NumericUpDown numericUpDown)
        {
            int bookID = (int)checkBox.Tag;
            var book = booksList.FirstOrDefault(b => b.ID == bookID);
            return new OrderItem
            {
                BookID = bookID,
                Title = checkBox.Text,
                Quantity = (int)numericUpDown.Value,
                Price = book.Price
            };
        }

        private void OrderControl_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void UpdateTotalPrice()
        {
            totalPrice = booksList
                .Where(book => quantityControls.ContainsKey(book.ID) && quantityControls[book.ID].Parent.Controls.OfType<CheckBox>().FirstOrDefault()?.Checked == true)
                .Sum(book => book.Price * quantityControls[book.ID].Value);

            labelTotalPrice.Text = $"Загальна сума: {totalPrice} грн";
        }

        private void PerformSearch()
        {
            string query = searchTextBox.Text.Trim().ToLower();
            var filteredBooks = booksList
                .Where(book => book.Title.ToLower().Contains(query) ||
                               book.Author.ToLower().Contains(query) ||
                               book.Genre.ToLower().Contains(query) ||
                               book.ISBN.ToLower().Contains(query))
                .ToList();

            flowLayoutPanel.Controls.Clear();
            LoadBooksToPanel(filteredBooks);
        }

        private async void addOrderButton_Click(object sender, EventArgs e)
        {
            var orderModel = new Order
            {
                CustomerName = customerNameField.Text,
                CustomerSurname = customerSurnameField.Text,
                CustomerEmail = emailField.Text,
                PhoneNumber = phoneNumberField.Text,
                OrderDate = DateTime.Now,
                TotalPrice = totalPrice,
                Status = orderStatus.SelectedItem?.ToString(),
                PaymentStatus = paymentStatus.SelectedItem?.ToString(),
                Books = GetSelectedBooks(),
                Notes = notesField.Text,
            };

            var orderService = new OrderService();
            bool isValid = ValidateOrderInput.ValidateInput(errorProvider1, orderModel, customerNameField, customerSurnameField, emailField, phoneNumberField, totalPrice, orderStatus, paymentStatus);

            if (isValid)
            {
                await orderService.AddOrderAsync(orderModel);
                MessageBox.Show("Успішно додане замовлення", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }

        private void ClearFields()
        {
            customerNameField.Clear();
            customerSurnameField.Clear();
            emailField.Clear();
            phoneNumberField.Clear();
            totalPrice = 0;
            orderStatus.SelectedIndex = -1;
            paymentStatus.SelectedIndex = -1;
            notesField.Clear();
            foreach (Control panel in flowLayoutPanel.Controls)
            {
                var checkBox = panel.Controls.OfType<CheckBox>().FirstOrDefault();
                if (checkBox != null)
                {
                    checkBox.Checked = false;
                }

                var numericUpDown = panel.Controls.OfType<NumericUpDown>().FirstOrDefault();
                if (numericUpDown != null)
                {
                    numericUpDown.Value = numericUpDown.Minimum;
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void viewOrderHistoryButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.ParentForm;
            mainForm.LoadControl(new OrderHistoryControl());
        }
    }
}