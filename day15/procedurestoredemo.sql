
create procedure producdurestoredemo as
begin
select Sum(salary) as SumofSalary
from Employees;
end;