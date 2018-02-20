
USE DevDB 
GO
ALTER PROCEDURE createsp
 @EmployeeNumber	INT= NULL
,@FirstName			NVARCHAR(50)= NULL
,@LastName			NVARCHAR(50)= NULL
,@Address           NVARCHAR(50)= NULL
,@Status            TEXT= NULL
,@Birthday			DATE		= NULL
,@Age				INT			= NULL
,@Sex				NVARCHAR(1)	= NULL
AS 

INSERT INTO Table_1
(EmployeeNumber
,FirstName
,LastName
,Address
,Status
,Birthday
,Age
,Sex)
VALUES
(@EmployeeNumber
,@FirstName
,@LastName
,@Address
,@Status
,@Birthday
,@Age
,@Sex)

GO

