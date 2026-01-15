using POOConcepts.Core;


try
{
    var employee1 = new SalaryEmployee { Id = 1010, Firstname = "Sandra", Lastname = "Lopez", BornDate = new Date(1980, 12, 2), HireDate = new Date(2023, 2, 12), IsActive = true, Salary = 2315544.67690M };
    var employee2 = new HourlyEmployee { Id = 2020, Firstname = "Carlos", Lastname = "Martinez", BornDate = new Date(1995, 6, 15), HireDate = new Date(2024, 1, 5), IsActive = true, HourValue = 34679, WorkingHours = 127 };
    var employee3 = new CommisionEmployee { Id = 3030, Firstname = "Ana", Lastname = "Gomez", BornDate = new Date(1991, 8, 16), HireDate = new Date(2020, 11, 30), IsActive = true, CommisionPercentage = 0.03f, Sales = 527000000 };
    var employee4 = new BaseCommisionEmployee { Id = 4040, Firstname = "Luis", Lastname = "Rodriguez", BornDate = new Date(1988, 3, 22), HireDate = new Date(2019, 7, 19), IsActive = true, CommisionPercentage = 0.015f, Sales = 89568000, Salary = 500000 };

    var invoice1 = new Invoice { Id = 1, Description = "Computer Asus R55", Price = 4500000, Quantity = 3 };
    var invoice2 = new Invoice { Id = 2, Description = "Avocado", Price = 5321, Quantity = 5.68f };
    var invoice3 = new Invoice { Id = 3, Description = "Office Chair", Price = 823456, Quantity = 5 };

    var items = new List<IPay> { employee1,  employee2, employee3, employee4, invoice1, invoice2, invoice3 };
    decimal total = 0;
    foreach (var item in items)
    {
        Console.WriteLine(item);
        Console.WriteLine();
        total += item.GetValueToPay();
    }
    Console.WriteLine("                         ====================");
    Console.WriteLine($"TOTAL:                   {total,20:C2}");
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

