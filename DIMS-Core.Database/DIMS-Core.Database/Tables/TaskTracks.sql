CREATE TABLE [dbo].[TaskTracks]
(
    [TaskTrackId]   INT             NOT NULL IDENTITY (1, 1),
    [UserTaskId]    INT             NOT NULL,
    [TrackDate]     DATE            NOT NULL,
    [TrackNote]     NVARCHAR(250)   NOT NULL,

    CONSTRAINT PK_TaskTracks_TaskTrackId PRIMARY KEY (TaskTrackId),
    CONSTRAINT FK_TaskTracks_To_UserTasks FOREIGN KEY (UserTaskId) REFERENCES UserTasks (UserTaskId) ON UPDATE CASCADE ON DELETE CASCADE
)