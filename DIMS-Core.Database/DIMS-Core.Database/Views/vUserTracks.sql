CREATE VIEW [dbo].[vUserTracks]
AS
SELECT	UserTasks.UserId,
		UserTasks.TaskId,
		TaskTracks.TaskTrackId,
		ToDoTasks.Name AS TaskName,
		TaskTracks.TrackNote,
		TaskTracks.TrackDate
FROM [UserTasks]
	INNER JOIN [TaskTracks] ON UserTasks.UserTaskId = TaskTracks.UserTaskId
	INNER JOIN [ToDoTasks] ON UserTasks.TaskId = ToDoTasks.TaskId