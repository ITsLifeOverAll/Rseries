namespace T12;

public class Ticket
{
    public double GetPrice(double price, DateTime dateTime, int age, bool hasAccessibilityCard)
    {
        var rate = 1.0d;

        if (dateTime.Month is >= 6 and <= 9 && dateTime.Hour is >= 17) price *= 0.7; 

        if (dateTime.Month >= 6 && dateTime.Month <= 9) rate = Math.Min(rate, 0.7);
        if (age >= 65) rate = Math.Min(rate, 0.8);
        if (hasAccessibilityCard) rate = Math.Min(rate, 0.7);

        return price * rate;
    }
    
    // 其它函數 ... 
}