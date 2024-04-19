using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista___Employees
{
    internal class Employees
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
                
        public Employees(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void salaryIncrease(double percent)
        {
            Salary += Salary * percent/100;
        }

        public override string ToString()
        {
            return Id
            + ", "
            + Name
            + ", "
            + Salary;
        }
    }
}
