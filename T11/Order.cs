namespace T11;

class Order
{
    public string CustomerName { get; set; }
    public string ShippingAddress { get; set; }

    private string? _emailTemplate;

    public void SendConfirmationEmail()
    {
        _emailTemplate = LoadEmailTemplate(); 
        var body = _emailTemplate.Replace("{name}", CustomerName);
        Console.WriteLine("Sending email: " + body);
    }

    private string LoadEmailTemplate()
    {
        return "Dear {name}, your order has been placed.";
    }
}
