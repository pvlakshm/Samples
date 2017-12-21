# Sample
The following is a sample for the in-assembly parallel test execution feature in MSTest V2.

Please note that the feature is still in an alpha stage.
**To know more about the feature, please see  the following:**
1. [RFC 004-In-Assembly-Parallel-Execution.md](https://github.com/Microsoft/testfx-docs/blob/master/RFCs/004-In-Assembly-Parallel-Execution.md).
2. [Issue #142: in-assembly parallel execution](https://github.com/Microsoft/testfx/issues/142).

The sample illustrates the following:
1. It contrasts test execution performance over 2 runs. The first run shows serial execution, while the second run is with in-assembly parallel execution. The gains are shown both in VSTS CI and in the Visual Studio IDE and in 
2. The test lifecycle method semantics (as described in the RFC above)

## Code
There are 4 test assemblies: UTA1, UTA2, UTA3, UTA4
Each assembly contains 2 test classes: C!, C2
Each test class contains 2 test methods: TM1, TM2
Each test takes 3 secs to run.

## Progressively making test execution faster
The following image shows the results from the 2 runs. The test explorer contents have been grouped by project.
![image](image.jpg)

### First run
All test run in in series. This total run time is about 50 secs (16 test x 3secs per test) + overhead
The test explorer shows that the test run (on the local box) took about 51s.
On VSTS CI, execution via the VSTest task on an agent machine took about the same (approx 50s).

### Second run
**Now we switch on in-assembly parallel** test execution.
In this example, that is done by configuring the test run with a .runsettings file.
The test explorer shows that this run took only about 14s.

Similarly VSTS CI shows that the run on an agent machine took only about 13.3. The height of the blue bar represent the test run duration. Just look at how much shorter that blue bar has become in this run!
The total run time in this case is around 14 secs.

### The speedup
Running the tests in this sample with in-assembly parallel makes them almost **3.5x faster**.
Of course YMMV.

## Test lifecycle method semantics
The test lifecycle methods have been setup to throw an exception if their semantics as called out in the RFC are not met. Since the tests all pass, it implies that the semantics are honoured.
