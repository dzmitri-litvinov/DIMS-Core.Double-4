CREATE TABLE [dbo].[Tasks]
(
    [TaskId]        INT             NOT NULL IDENTITY (1, 1),
    [Name]          NVARCHAR(50)    NOT NULL,
    [Description]   NVARCHAR(250)   NULL,
    [StartDate]     DATE            NOT NULL,
    [DeadlineDate]  DATE            NOT NULL,

    CONSTRAINT PK_Tasks_TaskId PRIMARY KEY (TaskId)
)