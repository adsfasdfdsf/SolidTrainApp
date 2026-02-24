namespace SolidApp;



public class OrderItem
{
    public Drink Drink { get; set; }
    public DrinkSize Size { get; set; }

    public OrderItem(Drink drink, DrinkSize size)
    {
        Drink = drink;
        Size = size;
    }
    
    public decimal GetItemCost()
    {
        return Drink.Cost + DrinkSizePricing.GetExtraCost(Size);
    }
}