create trigger empinstrg on person
after insert
as
select'Row created'