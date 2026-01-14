namespace POOConcepts.Core;

public class SalaryEmployee : Employee
{
    private const decimal MINIMUM_SALARY = 1500000;
    private decimal _salary;

    public decimal Salary 
    {
        get => _salary;
        set => _salary = ValidateSalary(value); 
    }

    public override decimal GetValueToPay() => Salary;

    public override string ToString() => $"{base.ToString}\n\t" +
            $"Salary...: {GetValueToPay():C2}";    

    private decimal ValidateSalary(decimal salary)
    {
        if (salary < MINIMUM_SALARY)
        {
            throw new Exception($"Salary: {salary:C2}, must be at least: {MINIMUM_SALARY:C2}");
        }
        return salary;
    }
}
