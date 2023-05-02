declare @grandsalary money;
declare salary_cursor cursor
for
select salary from Employee2 order salary;
open salary_cursor;
fetch next from salary_cursor into @grandsalary;
while @@fetch_status=0
begin
fetch next from salary_cursor into @grandsalary
end
close salary_cursor
deallocate salary_cursor;

