CREATE VIEW [dbo].[vUserTracks]
AS
SELECT	UserTasks.UserId,
		UserTasks.TaskId,
		TaskTracks.TaskTrackId,
		Tasks.Name AS TaskName,
		TaskTracks.TrackNote,
		TaskTracks.TrackDate
FROM [UserTasks]
	INNER JOIN [TaskTracks] ON UserTasks.UserTaskId = TaskTracks.UserTaskId
	INNER JOIN [Tasks] ON UserTasks.TaskId = Tasks.TaskId