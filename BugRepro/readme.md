## Repro for NUnit3-vs-adapter [#519](https://github.com/nunit/nunit3-vs-adapter/issues/519)

The sln contains 3 unit test projects (NUnit, MSTest, xUnit.net) which just 1 bolier plate test method in each.
There is also a runsettings file with "UseVerifiableInstrumentation" set to False.

### Steps to repro
#### Command line
- Invoke 't.bat`

#### VS IDE
- set the runsettings file
- build sln
- select all tests from Test Explorer
- invoke "Analyze Code Coverage for Selected Tests" from the Test Explorer.

### Expected
All the runs as seen in `t.bat` must succeed.

### Actual
Running the NUnit tests with the runsettings as the configuration causes a crash from both the command line and from within the VS IDE.
It works in the case of the MSTest and xUnit based tests.
