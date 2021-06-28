CREATE TABLE [dbo].[TaskTracks]
(
    [TaskTrackId]		INT				NOT NULL IDENTITY (1, 1),
    [UserTaskId]		INT				NOT NULL,
	[TrackDate]			DATE			NULL,
    [TrackNote]			NVARCHAR(250)	NULL,

    CONSTRAINT PK_TaskTracks_TaskTrackId PRIMARY KEY (TaskTrackId),
	FOREIGN KEY (UserTaskId) REFERENCES UserTasks (UserTaskId)
)