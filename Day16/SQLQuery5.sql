create or alter PROCEDURE ShowEmpwithId(@empid int)
AS
BEGIN
SELECT* FROM EmpMaster where EMPID-@empid;
end
exec ShowEmpwithId;