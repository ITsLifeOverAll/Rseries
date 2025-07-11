namespace T06;

public class OrderService
{
    public void CreateOrder(string customerName, string customerPhone, string customerAddress)
    {
        Console.WriteLine($"Creating order for {customerName}, {customerPhone}, {customerAddress}");
    }

    public void SendInvoice(string customerName, string customerPhone, string customerAddress)
    {
        Console.WriteLine($"Sending invoice to {customerName}, {customerPhone}, {customerAddress}");
    }
}
