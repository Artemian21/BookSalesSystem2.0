using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookSalesSystem2._0.OrderFolder;

namespace BookSalesSystem2._0
{
    public partial class UpdatedOrderForm : Form
    {
        public Order UpdatedOrder { get; private set; }
        private Order currentOrder;

        public UpdatedOrderForm(Order order)
        {
            InitializeComponent();
            InitializeFields();
            this.currentOrder = order;
        }

        private void InitializeFields()
        {
            customerNameField.Text = currentOrder.CustomerName;
            customerSurnameField.Text = currentOrder.CustomerSurname;
            emailField.Text = currentOrder.CustomerEmail;
            phoneNumberField.Text = currentOrder.PhoneNumber;
            notesField.Text = currentOrder.Notes;
            orderStatus.Text = currentOrder.Status;
            paymentStatus.Text = currentOrder.PaymentStatus;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveOrderButton_Click(object sender, EventArgs e)
        {
            var orderModel = new Order
            {
                OrderId = currentOrder.OrderId,
                CustomerName = customerNameField.Text,
                CustomerSurname = customerSurnameField.Text,
                CustomerEmail = emailField.Text,
                PhoneNumber = phoneNumberField.Text,
                Status = orderStatus.Text,
                PaymentStatus = paymentStatus.Text,
                Notes = notesField.Text,
                OrderDate = currentOrder.OrderDate,
                TotalPrice = currentOrder.TotalPrice,
                Books = currentOrder.Books
            };

            bool validate = ValidateOrderInput.ValidateUpdateInput(errorProvider1, orderModel, customerNameField, customerSurnameField, emailField, phoneNumberField, orderStatus, paymentStatus);
            if (validate)
            {
                UpdatedOrder = orderModel;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Невдалось оновити дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
