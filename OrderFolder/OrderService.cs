using BookSalesSystem2._0.BookFolder;
using Microsoft.EntityFrameworkCore;

namespace BookSalesSystem2._0.OrderFolder
{
    public class OrderService
    {
        private JsonOperationOrder jsonOperation = new JsonOperationOrder();
        private JsonOperationBook jsonOperationBook = new JsonOperationBook();

        public async Task<bool> AddOrderAsync(Order order)
        {
            if (DatabaseAvailable.IsDatabaseAvailable())
            {
                using (var context = new BookSalesSystemContext())
                {
                    foreach (var orderItem in order.Books)
                    {
                        var book = await context.Books.FindAsync(orderItem.BookID);
                        if (book == null || book.Stock < orderItem.Quantity)
                        {
                            MessageBox.Show($"Книга '{orderItem.Title}' недоступна в потрібній кількості.",
                                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    foreach (var orderItem in order.Books)
                    {
                        var book = await context.Books.FindAsync(orderItem.BookID);
                        book.Stock -= orderItem.Quantity;
                        jsonOperationBook.UpdateBookInJson(book);
                    }

                    context.Orders.Add(order);
                    await context.SaveChangesAsync();
                }
            }

            jsonOperation.AddOrderAsync(order);
            return true;
        }

        public async Task<bool> RemoveOrderAsync(int orderID)
        {
            if (DatabaseAvailable.IsDatabaseAvailable())
            {
                using (var context = new BookSalesSystemContext())
                {
                    var order = await context.Orders.FindAsync(orderID);
                    if (order != null)
                    {
                        context.Orders.Remove(order);
                        await context.SaveChangesAsync();
                    }
                }
            }

            jsonOperation.DeleteOrderAsync(orderID);
            return true;
        }

        public async Task<bool> UpdateOrderAsync(Order order)
        {
            if (DatabaseAvailable.IsDatabaseAvailable())
            {
                using (var context = new BookSalesSystemContext())
                {
                    var existingOrder = await context.Orders.FindAsync(order.OrderId);
                    if (existingOrder != null)
                    {
                        existingOrder.CustomerName = order.CustomerName;
                        existingOrder.CustomerSurname = order.CustomerSurname;
                        existingOrder.CustomerEmail = order.CustomerEmail;
                        existingOrder.PhoneNumber = order.PhoneNumber;
                        existingOrder.OrderDate = order.OrderDate;
                        existingOrder.Status = order.Status;
                        existingOrder.Books = order.Books;
                        existingOrder.TotalPrice = order.TotalPrice;
                        existingOrder.PaymentStatus = order.PaymentStatus;
                        existingOrder.Notes = order.Notes;

                        await context.SaveChangesAsync();
                    }
                }
            }

            jsonOperation.UpdateOrderAsync(order);
            return true;
        }

        public async Task<List<Order>> GetOrdersAsync()
        {
            if (DatabaseAvailable.IsDatabaseAvailable())
            {
                using (var context = new BookSalesSystemContext())
                {
                    try
                    {
                        return await context.Orders.Include(o => o.Books).ToListAsync();
                    }
                    catch (Exception)
                    {
                        return await jsonOperation.GetAllOrdersAsync();
                    }
                }
            }
            return await jsonOperation.GetAllOrdersAsync();
        }

        public async Task SyncJsonToDatabase()
        {
            if (!DatabaseAvailable.IsDatabaseAvailable()) return;

            using (var context = new BookSalesSystemContext())
            {
                var jsonOrders = await jsonOperation.GetAllOrdersAsync();
                var existingOrders = await context.Orders.Select(o => new
                {
                    o.OrderId,
                    o.CustomerSurname,
                    o.CustomerEmail,
                    o.OrderDate
                }).ToListAsync();

                foreach (var order in jsonOrders)
                {
                    bool exists = existingOrders.Any(o =>
                        o.OrderId == order.OrderId ||
                        o.CustomerSurname == order.CustomerSurname &&
                         o.CustomerEmail == order.CustomerEmail &&
                         o.OrderDate == order.OrderDate);

                    if (!exists)
                    {
                        context.Orders.Add(order);
                    }
                }

                await context.SaveChangesAsync();
            }
        }
    }
}
