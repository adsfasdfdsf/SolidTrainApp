namespace SolidApp;

public class Drink
{
    public required string Name { get; set; }
    public required decimal Cost { get; set; }
    private List<Option> _options = new List<Option>();
    
    public void AddOption(Option option)
    {
        _options.Add(option);
    }

    public decimal GetTotalCost()
    {
        decimal total = Cost;
        foreach (var opt in _options)
        {
            total += opt.Cost;
        }
        return total;
    }

    public string GetDescription()
    {
        string desc = Name;
        if (_options.Count > 0)
        {
            desc += " with " + string.Join(", ", _options.Select(o => o.Name));
        }
        return desc;
    }
}

public enum DrinkSize
{
    Small,
    Medium,
    Large
}

public class Option
{
    public string Name { get; set; }
    public decimal Cost { get; set; }
}
