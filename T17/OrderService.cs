namespace T17;

public class OrderService
{
    public List<int> GetTopHighValueCustomers(List<Order> orders)
    {
        var result = orders
            .Where(o => o.Items.Any(i => i.Price > 100 && i.IsAvailable))
            .GroupBy(o => o.Customer.Id)
            .Select(g => new
            {
                CustomerId = g.Key,
                Total = g.Sum(o => o.Items.Sum(i => i.Price))
            })
            .Where(r => r.Total > 1000)
            .OrderByDescending(r => r.Total)
            .Take(5)
            .Select(r => r.CustomerId)
            .ToList();
            
        return result;
    }
}

public class Order
{
    public Customer Customer { get; set; }
    public List<Item> Items { get; set; }
}

public class Item
{
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}

