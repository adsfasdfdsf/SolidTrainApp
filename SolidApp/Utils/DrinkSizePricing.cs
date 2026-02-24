namespace SolidApp;

public class DrinkSizePricing
{
    public static decimal GetExtraCost(DrinkSize size)
    {
        switch (size)
        {
            case DrinkSize.Small:
                return 50;
            case  DrinkSize.Medium:
                return 75;
            case  DrinkSize.Large:
                return 100;
            default:
                return 0;
        }
    }
}