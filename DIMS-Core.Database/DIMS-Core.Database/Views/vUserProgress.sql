CREATE VIEW [dbo].[vUserProgress]
AS
SELECT	UserTasks.UserId,
		UserTasks.TaskId,
		TaskTracks.TaskTrackId,
		UserProfiles.FirstName AS UserName,
		ToDoTasks.Name AS TaskName,
		TaskTracks.TrackNote,
		TaskTracks.TrackDate
FROM [UserTasks]
	INNER JOIN [TaskTracks] ON UserTasks.UserTaskId = TaskTracks.UserTaskId
	INNER JOIN [ToDoTasks] ON UserTasks.TaskId = ToDoTasks.TaskId
	INNER JOIN [UserProfiles] ON UserTasks.UserId = UserProfiles.UserId