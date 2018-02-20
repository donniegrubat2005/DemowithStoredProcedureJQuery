

USE DevDB 
GO
ALTER PROCEDURE deletesp
 @EmployeeNumber	INT= NULL

AS 

DELETE FROM Table_1 WHERE EmployeeNumber=@EmployeeNumber

GO

