// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Collections.Generic;
using ExercicioLista___Employees;
using System.Security.Cryptography.X509Certificates;

Console.Write("How many employees will be registered? ");
int n = int.Parse(Console.ReadLine());

List<Employees> lista = new List<Employees>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Employee: #" + i);
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine());

    lista.Add(new Employees(id, name, salary));
    Console.WriteLine();
}

Console.Write("Enter the employee id that will have salary increase : ");
int findId = int.Parse(Console.ReadLine());

Employees search = lista.Find(x => x.Id == findId);

if (search != null)
{
    Console.Write("Enter the percentage: ");
    double percentage = double.Parse(Console.ReadLine());
    search.salaryIncrease(percentage);
}
else
{
    Console.WriteLine("This id does not exist!");
}

Console.WriteLine();
Console.WriteLine("Updated list of employees:");
foreach (Employees obj in lista)
{
    Console.WriteLine(obj);
}