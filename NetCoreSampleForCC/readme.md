# .NET Core Sample for code coverage
Introducing code coverage for tests targeting .Net Core (Windows). Refer the following:
- [vstest RFC 0021 - Code Coverage for .NET Core](https://github.com/Microsoft/vstest-docs/blob/master/RFCs/0021-CodeCoverageForNetCore.md)
- [vstest Issue #981: Add support for dotnet test --collect:"Code Coverage"](https://github.com/Microsoft/vstest/issues/981)
This capability is available in the Test Plaform starting from Microsoft.NET.Test.Sdk (15.8.0) onwards.

## This sample solution
This solution is a sample ilustrating code coverage collection for code targeting .NET Core.
- [NetCoreSamplesForCC](./NetCoreSamplesForCC): system under test targeting netcoreapp2.1
- [MSTestV2TestProject](./MSTestV2TestProject): test project using MSTest V2 (v1.3.2), and targeting netcoreapp2.1
- [NUnit3TestProject](./NUnit3TestProject): test project using NUnit (v3.10.0), and targeting netcoreapp2.1
- [xUnitTestProject](./xUnitTestProject): test project using xUnit (v2.4.0), and targeting netcoreapp2.1

### Code Coverage from within Visual Studio
1. Build the solution
2. Select all the tests in the Test Explorer, and invoke the "Analyze Code Coverage for Selected Tests" menu command

### Code Coverage from CLI
Go to each of the Test folders folder within `Tests` and run the following command to generate code coverage data:
1. `dotnet test –collect "Code coverage"` [you can also use `"code coverage"` (with the lower case 'c').]
2. Open the generated `.coverage` file in VS Enterprise to see the coverage info.
