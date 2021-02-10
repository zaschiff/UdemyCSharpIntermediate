using System;
using System.Collections.Generic;

namespace Exercise {
    public class Workflow {
        public List<IActivity> Activities;

        public Workflow() {
            Activities = new List<IActivity>();
        }

        public Workflow(List<IActivity> tasks) {
            Activities = tasks;
        }

        public void Add(IActivity task) {
            Activities.Add(task);
        }
    }
}