namespace T10;

public class Reservation
{
    /// <summary>
    /// 是否可以預約指定飯店，指定日期。如果有代理商或聯盟商，則可以抽傭。如果有折扣卷，則依折扣卷打所。
    /// </summary>
    /// <param name="user">使用者</param>
    /// <param name="reservationDate">想要預約的日期</param>
    /// <param name="hotel">預約哪一家飯店</param>
    /// <param name="agent">可以抽傭的代理商，可能為 null</param>
    /// <param name="alliance">可以抽庸的聯盟商，可能為 null</param>
    /// <param name="coupon">折扣卷，依折扣卷打所，可能為 null</param>
    /// <returns>true: 可以預約。false: 該飯店時段無法預約。</returns>
    public bool MakeReservation(
        User user, 
        DateTime reservationDate, 
        Hotel hotel, 
        Agent?  agent, 
        Alliance? alliance, 
        Coupon? coupon)
    {
        // 實作預約邏輯...
        return true; // 假設預約成功
    }
}

//
// --- 以下為支援用的輔助程式碼，非本範例重點 ---
//

public class Coupon
{
}

public class Alliance
{
}

public class Agent
{
}

public class Hotel
{
}

public class User
{
}

