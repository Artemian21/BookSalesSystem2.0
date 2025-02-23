using System.ComponentModel;
using System.Data;
using BookSalesSystem2._0.OrderFolder;

namespace BookSalesSystem2._0
{
    public partial class OrderHistoryControl : UserControl
    {
        private List<Order> orderList;
        private BindingList<Order> filteredList = new BindingList<Order>();

        public OrderHistoryControl()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.ParentForm;
            mainForm.LoadControl(new OrderControl());
        }

        private void searchOrderBox_TextChanged(object sender, EventArgs e)
        {
            var query = searchOrderBox.Text.ToLower();

            if (string.IsNullOrEmpty(query))
            {
                filteredList = new BindingList<Order>(orderList);
            }
            else
            {
                var filteredOrder = orderList
                    .Where(o => o.CustomerName.ToLower().Contains(query) ||
                               o.CustomerSurname.ToLower().Contains(query) ||
                               o.CustomerEmail.ToLower().Contains(query) ||
                               o.PhoneNumber.ToLower().Contains(query) ||
                               o.TotalPrice.ToString().Contains(query) ||
                               o.OrderDate.ToString().Contains(query) ||
                               o.Status.ToLower().Contains(query) ||
                               o.PaymentStatus.ToLower().Contains(query)
                    )
                    .ToList();

                filteredList = new BindingList<Order>(filteredOrder);
            }

            orderDataGridView.DataSource = null;
            orderDataGridView.DataSource = filteredList;
        }

        public void RefreshOrders()
        {
            LoadOrders();
        }

        private async void LoadOrders()
        {
            orderDataGridView.AutoGenerateColumns = false;
            try
            {
                OrderService orderService = new OrderService();
                var orders = await orderService.GetOrdersAsync();

                if (orders != null && orders.Any())
                {
                    orderList = orders;
                    filteredList = new BindingList<Order>(orderList);

                    orderDataGridView.DataSource = filteredList;
                }
                else
                {
                    MessageBox.Show("Немає доступних замовлень.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження замовлень: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var order = orderDataGridView.Rows[e.RowIndex].DataBoundItem as Order;

                if (e.ColumnIndex == orderDataGridView.Columns["deleteButton"].Index && order != null)
                {
                    await HandleDeleteOrder(order);
                }
                else if (e.ColumnIndex == orderDataGridView.Columns["editButton"].Index && order != null)
                {
                    await HandleEditOrder(order);
                }
            }
        }

        private async Task HandleDeleteOrder(Order order)
        {
            var result = MessageBox.Show("Ви впевнені, що хочете видалити це замовлення?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                OrderService orderService = new OrderService();
                bool resultDelete = await orderService.RemoveOrderAsync(order.OrderId);

                if (resultDelete)
                {
                    RefreshOrders();
                }
                else
                {
                    MessageBox.Show("Не вдалося видалити замовлення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task HandleEditOrder(Order order)
        {
            UpdatedOrderForm updatedOrderForm = new(order);
            DialogResult result = updatedOrderForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                var updatedOrder = updatedOrderForm.UpdatedOrder;
                OrderService orderService = new OrderService();
                bool updateResult = await orderService.UpdateOrderAsync(updatedOrder);

                if (updateResult)
                {
                    RefreshOrders();
                }
                else
                {
                    MessageBox.Show("Не вдалося оновити замовлення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
