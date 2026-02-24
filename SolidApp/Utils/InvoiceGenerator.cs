using System.Text;

namespace SolidApp;

public class InvoiceGenerator
{
    public string GenerateInvoice(Order order, decimal finalPrice, decimal discount)
    {
        StringBuilder invoice = new StringBuilder();
        invoice.AppendLine("Invoice:".PadLeft(30));
        invoice.AppendLine($"Total Price: {order.GetSubtotal()}");
        invoice.AppendLine($"Total Discount: {discount}");
        invoice.AppendLine($"Final Price: {finalPrice}");
        return invoice.ToString();
    }
}