namespace T07;

public class Order
{
    public string CreateReceipt(List<ShoppingItem> items)
    {
        var receiptLines = GetReceiptLines(items);
        var bill = GetBillTotal(items);
        var receipt = string.Join("\n", receiptLines);
        return $"{receipt}\nBill {bill}$";
    }
    
    public decimal GetBillTotal(List<ShoppingItem> items)
    {
        return items.Sum(item => item.Price * item.Tax);
    }

    public List<string> GetReceiptLines(List<ShoppingItem> items)
    {
        return items.Select(item => $"{item.Name}: {item.Price * item.Tax}$").ToList();
    }
}

//
// --- 以下為支援用的輔助程式碼，非本範例重點 ---
//

public class ShoppingItem
{
    public string Name { get; }
    public decimal Price { get; }
    public decimal Tax { get; }

    public ShoppingItem(string name, decimal price, decimal tax)
    {
        Name = name;
        Price = price;
        Tax = tax;
    }
}

