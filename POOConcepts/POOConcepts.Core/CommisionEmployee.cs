namespace POOConcepts.Core;

public class CommisionEmployee : Employee
{
    private float _commisionPercentage;
    private decimal _sales;

    public float CommisionPercentage 
    { 
        get => _commisionPercentage; 
        set => _commisionPercentage = ValidateCommisionPercentage(value); 
    }
    public decimal Sales 
    { 
        get => _sales; 
        set => _sales = ValidateSales(value); 
    }

    public override decimal GetValueToPay() => Sales * (decimal)CommisionPercentage;

    public override string ToString() => $"{base.ToString()}\n\t" +
            $"Sales..........: {Sales,20:C2}\n\t" +
            $"Commision %....: {CommisionPercentage,20:P2}\n\t" +
            $"Salary.........: {GetValueToPay(),20:C2}";

    private float ValidateCommisionPercentage(float commisionPercentage)
    {
        if (commisionPercentage < 0 || commisionPercentage > 100)
        {
            throw new Exception($"Commision percentage: {commisionPercentage:P2}, must be greater than zero and less than or equal to 100");
        }
        return commisionPercentage;
    }

    private decimal ValidateSales(decimal sales)
    {
        if (sales < 0)
        {
            throw new Exception($"Sales: {sales:C2}, must be greater than zero");
        }
        return sales;
    }
}
