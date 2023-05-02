create trigger empinstrg on Employee2
after insert
as
select 'Row Created';