CREATE PROCEDURE SetUserTaskAsSuccess
	@UserTaskId INT
AS
UPDATE UserTasks SET StateId = 2 WHERE UserTaskId = @UserTaskId