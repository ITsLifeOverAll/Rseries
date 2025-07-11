namespace T09;

public class OrderService
{
    public List<OrderItem>? Items { get; set; } = new List<OrderItem>();
    
    
    public void Process(OrderService? order)
    {
        if (order != null)
        {
            if (order.Items != null && order.Items.Count > 0)
            {
                foreach (var item in order.Items)
                {
                    if (item.Quantity > 0)
                    {
                        if (item.Price > 0)
                        {
                            Console.WriteLine($"Processing {item.Name}");
                        }
                    }
                }
            }
        }
    }
}

//
// --- 以下為支援用的輔助程式碼，非本範例重點 ---
//

public class OrderItem(string name, decimal price, int quantity)
{
    public string Name { get; set; } = name;
    public decimal Price { get; set; } = price;
    public int Quantity { get; set; } = quantity;
}

