namespace T15;

public class OrderService
{
    public User User { get; set; }
    public DateTime OrderTime { get; set; }
    public string? OrderId { get; set; }

    public void PlaceOrder()
    {
        // 處理訂單邏輯
    }
    
    public void CancelOrder()
    {
        // 處理取消訂單邏輯
    }
}

// 
// --- 以下為支援用的輔助程式碼，非本範例重點 ---
// 

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public User(string name, string email, string phone)
    {
        Name = name;
        Email = email;
        Phone = phone;
    }
}
