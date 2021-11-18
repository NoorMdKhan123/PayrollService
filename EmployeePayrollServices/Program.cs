using System;

namespace EmployeePayrollServices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll");

            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel model = new EmployeeModel();

            repo.GetAllEmployee();
        }
    }
}
