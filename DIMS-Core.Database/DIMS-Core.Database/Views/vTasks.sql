CREATE VIEW [dbo].[vTasks]
AS
SELECT ToDoTasks.TaskId,
        ToDoTasks.Name,
        ToDoTasks.Description,
        ToDoTasks.StartDate,
        ToDoTasks.DeadlineDate
FROM [ToDoTasks]