namespace SolidApp;

public class Order
{
    private List<OrderItem> _items = new();

    public void AddItem(OrderItem item)
    {
        _items.Add(item);
    }

    public decimal GetSubtotal()
    {
        return _items.Sum(s => s.GetItemCost());
    }
}