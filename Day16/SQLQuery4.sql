create or ALTER PROCEDURE SP_PrintDate as
BEGIN
SELECT GETDATE();
END;

EXEC SP_PrintDate