use payroll_services;
create table employee_payroll_services
(
EmployeeID int identity not null,
EmployeeName varchar(100) not null,
PhoneNumber bigint not null,
Address varchar(200) not null,
Department varchar(50) not null,
Gender char(2) not null,
BasicPay decimal not null,
Deductions decimal not null,
TaxablePay decimal not null,
Tax decimal not null,
NetPay decimal not null,
StartDate date not null,
City varchar(50) not null,
Country varchar(50) not null
);
select * from employee_payroll_services;

EXEC sp_RENAME 'employee_payroll_services.tax', 'Tax', 'COLUMN';

Alter table employee_payroll_servic
Alter column PhoneNumber bigint;


Alter table employee_payroll_services
add City varchar(60),
Country varchar(65);
insert into  employee_payroll_services  (EmployeeName, PhoneNumber, Address, Department, Gender, BasicPay, Deductions, TaxablePay,
Tax, NetPay, StartDate, City, Country) values ('Sara', 9918097006, 'nai sadal','hr', 'f', 2000, 190, 20, 5, 20000, '2021-10-09','Varanasi','UP');


select EmployeeId, EmployeeName, PhoneNumber, Address,
                Department, Gender, BasicPay, Deductions, TaxablePay, Tax, NetPay,
                StartDate, City, Country FROM employee_payroll_services;

CREATE TABLE Parent(
Id INT PRIMARY KEY,
NAME varchar(MAX)
)
CREATE TABLE Child(
CId INT,
Name VARCHAR(MAX),
PId int FOREIGN key REFERENCES Parent(Id)
)

