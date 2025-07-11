
var visitor1 = new Visitor(30, false);
var visitor2 = new Visitor(30, true);
var visitor3 = new Visitor(66, false);
var visitor4 = new Visitor(66, true);

var visitors = new List<Visitor> { visitor1, visitor2, visitor3, visitor4 };

const double listPrice = 1000; 
var date = new DateTime(2025, 7, 25);

foreach (var visitor in visitors)
{
    var price = GetPrice(listPrice, visitor, date);
    Console.WriteLine($"Visitor: {visitor}, Price: {price:C0}");
}
return; 

// 如果年紀大於 65 歲，老年優惠，打 8 折
// 如果持有身障証，打 5 折
// 夏日優惠打 7 折
double GetPrice(double price, Visitor visitor, DateTime dateTime)
{
    double discount = 1d;

    if (dateTime.Month >= 6 && dateTime.Month <= 9) discount = 0.7;
    if (visitor.Age >= 65) discount = 0.8;
    if (visitor.HasAccessibilityCard) discount = 0.7;

    return price * discount;
}

public record struct Visitor(int Age, bool HasAccessibilityCard);
