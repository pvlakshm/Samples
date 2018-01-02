# Sample
This solution uses NUnit 3.9. It has 5 tests cases. It also has a data collector.

## Build and Run all tests
Build and run the tests using the following commandline ```vstest.console.exe NUnit39.dll /settings:"..\..\..\1.runsettings" /testadapterpath:.```

### Output
The actual time when the test started (TS) executing is printed to the console. That actual time when that test's start event (TSE) was processed by the data collector is also emitted to console. Both values are printed in ticks.

### Expectation
The expectation is that TSE - TS < 0

### Actual
From the values that are emitted, notice that TSE is not earlier than its corresponding TS.