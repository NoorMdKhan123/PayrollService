using System;
namespace EmployeePayrollServices
{
     class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public decimal BasicPay { get; set; }
        public decimal Deduction { get; set; }
        public decimal TaxablePay { get; set; }
        public decimal Tax { get; set; }
        public decimal NetPay { get; set; }
        public DateTime StartDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }


    }
}