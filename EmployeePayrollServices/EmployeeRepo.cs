using System;
using System.Data.SqlClient;
namespace EmployeePayrollServices
{
    public class EmployeeRepo
    {
        public static string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=payroll_services;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);

        public void GetAllEmployee()
        {
            try
            {
                EmployeeModel employee = new EmployeeModel();
                using(this.connection)
                {
                    string query = @"select EmployeeId, EmployeeName, PhoneNumber, Address,
                Department, Gender, BasicPay, Deductions, TaxablePay, Tax, NetPay,
                StartDate, City, Country FROM employee_payroll_services;";
                

                //define sql command object
                SqlCommand cmd = new SqlCommand(query, this.connection);

                    this.connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            employee.EmployeeId = dr.GetInt32(0);
                            employee.EmployeeName = dr.GetString(1);
                            employee.PhoneNumber = dr.GetInt64(2);
                            employee.Address = dr.GetString(3);
                            employee.Department = dr.GetString(4);
                            employee.Gender = dr.GetString(5);
                            employee.BasicPay = dr.GetDecimal(6);
                            employee.Deduction = dr.GetDecimal(7);
                            employee.TaxablePay = dr.GetDecimal(8);
                            employee.Tax = dr.GetDecimal(9);
                            employee.NetPay = dr.GetDecimal(10);
                            employee.StartDate = dr.GetDateTime(11);
                            employee.City = dr.GetString(12);
                            employee.Country = dr.GetString(13);

                            //display retrived record
                            Console.WriteLine($"{employee.EmployeeId} {employee.EmployeeName} {employee.PhoneNumber} {employee.Address} {employee.Department}");
                                 

                        }
                    }
                    else
                    {
                        Console.WriteLine("No records present");
                    }
                    dr.Close();
                    this.connection.Close();

                        }
                    }
            catch( Exception e)
            {
                Console.WriteLine (e.Message.ToString());
            }

          
        }
    }
}