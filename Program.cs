using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data source
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Query (query syntax)
            var querySyntax = from obj in list
                              where obj > 2
                              select obj;

            WriteLine("Query Syntax ----");

            // Execution
            foreach (var item in querySyntax)
            {
                WriteLine(item);
            }

            WriteLine("Method Syntax ----");

            // Query (method syntax)
            var methodSyntax = list.Where(obj => obj > 2);

            // Execution
            foreach (var item in methodSyntax)
            {
                WriteLine(item);
            }

            WriteLine("Mixed Syntax ----");

            var mixedSyntax = (from obj in list
                               select obj).Max();
            WriteLine($"Max value is: {mixedSyntax}");

            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Leslie"},
                new Employee(){Id = 2, Name = "Lisa"},
            };

            IEnumerable<Employee> query = from emp in employees
                                          where emp.Id == 1
                                          select emp;

            IQueryable<Employee> query1 = employees.AsQueryable().Where(x => x.Id == 1);

            foreach (var item in query1)
            {
                WriteLine($"Id = {item.Id}, Name = {item.Name}");
            }

            WriteLine("Projection....");

            List<Employee> employeeList = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Leslie", Email="Leslie@gmail.com"},
                new Employee(){Id = 2, Name = "Adam", Email="Adam@gmail.com"},
                new Employee(){Id = 3, Name = "Test", Email="Test@gmail.com"},
                new Employee(){Id = 4, Name = "Person", Email="Person@gmail.com"},
                new Employee(){Id = 5, Name = "Mark", Email="Mark@gmail.com"}
            };

            var basicQuery = (from emp in employeeList
                             select emp).ToList();

            var basicMethod = employeeList.ToList();


            /// Operations
            /// 

            var basicPropQuery = (from emp in employeeList
                                  select emp.Id).ToList();

            var basicPropMethod = employeeList.Select(emp => emp.Id).ToList();

            // Using select with an index
            var indexPropMethod = employeeList.Select((emp, index) => new { Index = index, Name = emp.Name });

            foreach (var item in indexPropMethod)
            {
                WriteLine(item);
                // WriteLine($"{item.Name}, {item.Email}");
            }
        }

        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
        }
    }
}
