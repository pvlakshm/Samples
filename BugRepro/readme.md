The sln contains 3 unit test projects (NUnit, MSTest, xUnit.net) which just 1 bolier plate test method in each.
There is also a runsettings file with "UseVerifiableInstrumentation" set to False.

### Expected
all the runs as seen in `t.bat` must succeed.

### Actual
Running the NUnit tests with the runsettings as the configuration causes a crash from both the command line and from within the VS IDE.
`vstest.console.exe NUnitTestProject1\bin\Debug\NUnitTestProject1.dll /Settings:t.runsettings`
- Or -
set the runsettings file, and then invoke "Analyze Code Coverage for Selected Tests" from the Test Explorer.
It works in the case of the MSTest and xUnit based tests.