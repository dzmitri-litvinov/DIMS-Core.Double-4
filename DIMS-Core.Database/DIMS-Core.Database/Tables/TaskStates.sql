CREATE TABLE [dbo].[TaskStates]
(
    [StateId]	INT           NOT NULL IDENTITY (1, 1),
    [StateName] NVARCHAR(50)  NOT NULL

    CONSTRAINT PK_TaskStates_StateId PRIMARY KEY (StateId)
)