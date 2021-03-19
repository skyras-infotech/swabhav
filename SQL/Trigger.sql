CREATE TRIGGER IncrementSal on EMP
AFTER INSERT
AS 
BEGIN
	DECLARE @Salary money
	DECLARE @EId integer
	Select @EId = inserted.EMPNO from inserted
	Select @Salary = inserted.sal from inserted
	update EMP set SAL = @Salary + 10000 where EMPNO = @EId
END
GO