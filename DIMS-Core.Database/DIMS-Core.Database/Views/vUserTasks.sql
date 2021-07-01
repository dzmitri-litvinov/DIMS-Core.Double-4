CREATE VIEW [dbo].[vUserTasks]
AS
SELECT	UserTasks.UserId,
		UserTasks.TaskId,
		ToDoTasks.Name AS TaskName,
		ToDoTasks.Description,
		ToDoTasks.StartDate,
		ToDoTasks.DeadlineDate,
		TaskStates.StateName
FROM [UserTasks]
	INNER JOIN [ToDoTasks] ON UserTasks.TaskId = ToDoTasks.TaskId
	INNER JOIN [TaskStates] ON UserTasks.StateId = TaskStates.StateId 