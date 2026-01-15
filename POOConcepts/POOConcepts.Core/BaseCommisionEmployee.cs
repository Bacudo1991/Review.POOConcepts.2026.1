namespace POOConcepts.Core;

public class BaseCommisionEmployee : CommisionEmployee
{
    private decimal _salary;

    public decimal Salary 
    { 
        get => _salary; 
        set => _salary = ValidateSalary(value); 
    }

    public override decimal GetValueToPay() => Salary + base.GetValueToPay();

    private decimal ValidateSalary(decimal salary)
    {
        if (salary < 300000)
        {
            throw new Exception($"Salary: {salary:C2}, must be greater than {300000:C2}");
        }
        return salary;
    }    
}
