create or alter procedure getsalary @empid int,@salary money output
as
begin
select @salary=salary from Employees
where employee_id=@empid
end;