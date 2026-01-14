namespace POOConcepts.Core;

public class HourlyEmployee : Employee
{
    private decimal _hourValue;
    private float _workingHours;

    public decimal HourValue 
    { 
        get => _hourValue; 
        set => _hourValue = ValidateHourValue(value); 
    }
    public float WorkingHours 
    { 
        get => _workingHours; 
        set => _workingHours = ValidateWorkingHours(value); 
    }

    public override decimal GetValueToPay() => HourValue * (decimal)WorkingHours;

    public override string ToString() => $"{base.ToString()}\n\t" +
            $"Working hours..: {WorkingHours:N2}\n\t" +
            $"Hour value.....: {HourValue:C2}\n\t" +
            $"Salary.........: {GetValueToPay():C2}";

    private decimal ValidateHourValue(decimal hourValue)
    {
        if (hourValue <= 0)
        {
            throw new Exception($"Hour value: {hourValue:C2}, must be greater than zero");
        }
        return hourValue;
    }

    private float ValidateWorkingHours(float workingHours)
    {
        if (workingHours <= 0)
        {
            throw new Exception($"Working hours: {workingHours:N2}, must be greater than zero");
        }
        return workingHours;
    }
}
