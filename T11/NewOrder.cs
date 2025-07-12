namespace T11;

public class NewOrder(User user)
{
    private bool _isGoldMember;
    private User _user = user;

    private void SetIsUserGoldMember(User user)
    {
        // 設定使用者登入狀態
        _isGoldMember = user.IsGoldMember();
    }
    
    // 這裡有許多函數, 有的函數用到了 _isGoldMember

    public void AddOrderItem(Item item, int quantity)
    {
        // add order item 
        
        if (_isGoldMember)
        {
            // _user 增加購買積分 
        }
    }
}

//
// --- 以下為支援用的輔助程式碼，非本範例重點 ---
// 

public class User(string userId, string name, string email)
{
    public string UserId { get; set; } = userId;
    public string Name { get; set; } = name;
    public string Email { get; set; } = email;
    public int BonusPoints { get; set; }

    public bool IsGoldMember()
    {
        // 模擬取得使用者是否為金會員的邏輯
        return true; // 假設使用者已登入
    }
}

public class Item
{
    public string Name;
    public decimal Price;
}
