# Sample
When a testcase executes, the VSTest Test Platform raises TestStart/TestEnd events. For tests running serially, it is expected that these events surround the actual execution of the testcase. Testcase-level data collectors handle these events and record relevant observations. For e.g. the TIA data collector might record observations about all of the test code and SUT code that might be executing, a video data collector might take a screen shot for associating with the testcase, and so on. For the events to be useful to such data collectors it is essential that they are raised contemporaneosly with the testcase that is executing - i.e. if were to associate time stamps as follows:
- TCSE - timestamp when testcase 'start' event is handled.
- TCS - timestamp when actual testcase execution begins.
- TCE - timestamp when actaul testcase execution ends.
- TCEE - timestamp when testcase 'end' event is handled.

then, it is expected that the relation {TCSE < TCS < TCE < TCEE} is ```true```.

This sample is an example where this relation is ```false```. 

This solution uses NUnit 3.9. It has 5 tests cases. It also has a data collector. The testcases and the datacollector emit timestamps in ticks.

## Build and Run all tests
- Download the sample, and build it in VS.
- Run the tests using the following commandline ```vstest.console.exe NUnit39.dll /settings:"..\..\..\1.runsettings" /testadapterpath:.```

### Output
The actual time when the test started (TCS) executing is printed to the console. That actual time when that test's start event (TCSE) was processed by the data collector is also emitted to console. Both values are printed in ticks.

### Expected
The expectation is that TCSE < TCS

### Actual
From the values that are emitted, notice that TCSE is not earlier than its corresponding TCS.
