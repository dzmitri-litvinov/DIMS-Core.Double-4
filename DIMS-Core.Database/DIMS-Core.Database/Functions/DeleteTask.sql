CREATE PROCEDURE DeleteTask
	@TaskId INT
AS
DELETE FROM Tasks WHERE TaskId = @TaskId