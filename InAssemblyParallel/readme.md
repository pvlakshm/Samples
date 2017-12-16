Code:
There are 4 test assemblies: UTA1, UTA2, UTA3, UTA4
Each assembly contains 2 test classes: C!, C2
Each test class contains 2 test methods: TM1, TM2

Each test takes 3 secs to run.

First run:
All test run in sequence. This total run time is about 51 secs (16 test x 3secs per test) + overhead

Second run:
We enable process-parallel test execution. You can read more about that in this (blog post)[https://blogs.msdn.microsoft.com/devops/2016/10/10/parallel-test-execution/].
Test execution is launched on each available core as a distinct process, and handed an assembly worth of tests to execute.
The total run time in this case is about 19 secs. On a 4 core machine, the run ought to take about the 1/4th the time. On my laptop, i see these times. YMMV a little.
Nonetheless the second rin is faster.

Third run:
Now we switch on in-assembly parallel as well.
In this example, that is done by configuring the test run with a .runsettings file.
Now we have process-parallel AND in-assmebmly parallel.
The total run time in this case is around 5.5 secs.
Is that fast or what?!