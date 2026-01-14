using POOConcepts.Core;


try
{
    var employee1 = new SalaryEmployee { Id = 1010, Firstname = "Sandra", Lastname = "Lopez", BornDate = new Date(1980, 12, 2), HireDate = new Date(2023, 2, 12), IsActive = true, Salary = 2000000 };

    var employee2 = new HourlyEmployee { Id = 2020, Firstname = "Carlos", Lastname = "Martinez", BornDate = new Date(1995, 6, 15), HireDate = new Date(2024, 1, 5), IsActive = true, HourValue = 50000, WorkingHours = 160 };

    var employees = new List<Employee> { employee1,  employee2 };
    decimal total = 0;
    foreach (var employee in employees)
    {
        Console.WriteLine(employee);
        total += employee.GetValueToPay();
    }
    Console.WriteLine("=================");
    Console.WriteLine($"{total:C2}");
}
catch (Exception ex)
{
	Console.WriteLine($"Error: {ex.Message}");
}



//try
//{
//    var date1 = new Date(2025, 11, 30);
//    var date2 = new Date(2028, 2, 29);

//    Console.WriteLine(date1);
//    Console.WriteLine(date2);
//}
//catch (Exception ex)
//{

//	Console.WriteLine($"Error: {ex.Message}");
//}

