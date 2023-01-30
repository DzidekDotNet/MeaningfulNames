namespace ComplexIf;

public record Customer(string Name, decimal TotalTurnover, decimal LastQuarterTurnover, bool HasLoyaltyCard);
public class ComplexIf
{
    private const decimal PremiumTotalTurnover = 1000000;
    private const decimal PremiumQuarterTurnover = 250000;
    
    public void ComplexIf_Wrong(Customer customer)
    {
        if (customer.HasLoyaltyCard && customer.TotalTurnover > PremiumTotalTurnover && customer.LastQuarterTurnover > PremiumQuarterTurnover)
        {
            //do something
        }
    }

    private bool IsPremium(Customer customer)
    {
        return customer.HasLoyaltyCard && customer.TotalTurnover > PremiumTotalTurnover && customer.LastQuarterTurnover > PremiumQuarterTurnover;
    }
    
    public void ComplexIf_Good(Customer customer)
    {
        if (IsPremium(customer))
        {
            //do something
        }
    }
}