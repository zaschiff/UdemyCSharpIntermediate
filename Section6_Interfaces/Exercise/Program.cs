using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkflowEngine wfe = new WorkflowEngine();
            Workflow wf = new Workflow();
            ActivtiyOne a1 = new ActivtiyOne();
            ActivityTwo a2 = new ActivityTwo();

            wf.Add(a1);
            wf.Add(a2);
            wfe.Run(wf);
        }
    }
}
