using Newtonsoft.Json;

namespace BookSalesSystem2._0.OrderFolder
{
    public class JsonOperationOrder
    {
        private readonly string filePath = "orders.json";

        public JsonOperationOrder()
        {
            EnsureJsonFileExists();
        }

        private async void EnsureJsonFileExists()
        {
            if (!File.Exists(filePath))
            {
                await File.WriteAllTextAsync(filePath, "[]");
            }
        }

        public async void AddOrderAsync(Order order)
        {
            var orders = await GetAllOrdersAsync();
            orders.Add(order);
            await File.WriteAllTextAsync(filePath, JsonConvert.SerializeObject(orders, Formatting.Indented));
        }

        public async void DeleteOrderAsync(int orderId)
        {
            var orders = await GetAllOrdersAsync();
            var deletedOrder = orders.Where(o => o.OrderId != orderId).ToList();
            await File.WriteAllTextAsync(filePath, JsonConvert.SerializeObject(orders, Formatting.Indented));
        }

        public async void UpdateOrderAsync(Order updatedOrder)
        {
            var orders = await GetAllOrdersAsync();
            var index = orders.FindIndex(o => o.OrderId == updatedOrder.OrderId);
            if (index != -1)
            {
                orders[index] = updatedOrder;
                await File.WriteAllTextAsync(filePath, JsonConvert.SerializeObject(orders, Formatting.Indented));
            }
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            try
            {
                var json = await File.ReadAllTextAsync(filePath);
                return JsonConvert.DeserializeObject<List<Order>>(json) ?? new List<Order>();
            }
            catch
            {
                return new List<Order>();
            }
        }
    }
}
