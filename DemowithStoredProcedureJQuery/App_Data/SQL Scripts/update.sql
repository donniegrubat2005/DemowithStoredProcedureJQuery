
USE DevDB 
GO
ALTER PROCEDURE updatesp
 @EmployeeNumber	INT= NULL
,@FirstName			NVARCHAR(50)= NULL
,@LastName			NVARCHAR(50)= NULL
,@Address           TEXT= NULL
,@Status            NVARCHAR(15)= NULL
,@Birthday			DATE		= NULL
,@Age				INT			= NULL
,@Sex				NVARCHAR(1)	= NULL
AS 

UPDATE Table_1
SET FirstName=@FirstName
,LastName=@LastName
,Address=@Address
,Status=@Status
,Birthday=@Birthday
,Age=@Age
,Sex=@Sex
WHERE EmployeeNumber=@EmployeeNumber


GO

