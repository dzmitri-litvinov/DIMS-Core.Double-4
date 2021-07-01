﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DIMS_Core.DataAccessLayer.Models
{
    public partial class ToDoTask
    {
        public ToDoTask()
        {
            UserTasks = new HashSet<UserTask>();
        }

        public int TaskId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DeadlineDate { get; set; }

        public virtual ICollection<UserTask> UserTasks { get; set; }
    }
}
