CREATE PROCEDURE SetUserTaskAsFail
	@UserTaskId INT
AS
UPDATE UserTasks SET StateId = 3 WHERE UserTaskId = @UserTaskId