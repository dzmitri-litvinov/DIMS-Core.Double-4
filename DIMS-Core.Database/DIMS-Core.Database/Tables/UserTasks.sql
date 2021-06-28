CREATE TABLE [dbo].[UserTasks]
(
    [UserTaskId] INT           NOT NULL IDENTITY (1, 1),
    [TaskId]     INT           NOT NULL,
    [UserId]     INT           NOT NULL,
    [StateId]    INT           NOT NULL

	CONSTRAINT PK_UserTasks_UserTaskId PRIMARY KEY (UserTaskId),
    FOREIGN KEY (TaskId) REFERENCES Tasks (TaskId),
    FOREIGN KEY (UserId) REFERENCES UserProfiles (UserId),
    FOREIGN KEY (StateId) REFERENCES TaskStates (StateId)
)