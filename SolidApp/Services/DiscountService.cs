namespace SolidApp;

public class DiscountService
{
    public DiscountService(){}

    public decimal CalculateTotalDiscount(Order order) => order.GetSubtotal() switch
    {
        > 500 => order.GetSubtotal() * (decimal)0.2,
        > 100 => order.GetSubtotal() * (decimal)0.1,
        _ => 0
    };
}