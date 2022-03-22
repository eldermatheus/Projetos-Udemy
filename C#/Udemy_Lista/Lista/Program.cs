using Lista;
using System.Globalization;

List<Employee> employees = new List<Employee>();

Console.Write("How many employees will bee registered?");
int employeesNumber = int.Parse(Console.ReadLine());

for (int i = 1; i <= employeesNumber; i++)
{
    Console.WriteLine($"Employee #{i}:");
        
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

    employees.Add(new Employee(id, name, salary));
    Console.WriteLine();
}

Console.Write("Enter the employee ud that will have salary increase : ");
int selectEmployee = int.Parse(Console.ReadLine());

Console.Write("Enter the percentage: ");
double percent = double.Parse(Console.ReadLine());


Employee locatedEmployee = employees.Find(e => e.Id == selectEmployee);

if (locatedEmployee != null)
{
    locatedEmployee.IncreaseSalary(percent);
}

else
{
    Console.WriteLine("This id does not exist!");
}
 
Console.WriteLine("Updated list of employess: ");

foreach (var item in employees)
{
    Console.WriteLine(item);
}
