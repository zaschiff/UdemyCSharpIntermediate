using System;
using System.Collections.Generic;

namespace Exercise {
    public class WorkflowEngine {

        public void Run(Workflow taskBoard) {
            foreach (var task in taskBoard.Activities) {
                if (task == null)
                    throw new ArgumentException("Activity can not be null.");
                task.Execute();
            }
        }
    }
}