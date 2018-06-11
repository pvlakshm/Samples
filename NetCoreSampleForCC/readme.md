# .NET Core Sample for code coverage
Introducing code coverage for tests targeting .Net Core (Windows). Refer the following:
- [vstest RFC 0021 - Code Coverage for .NET Core](https://github.com/Microsoft/vstest-docs/blob/master/RFCs/0021-CodeCoverageForNetCore.md)
- [vstest Issue #981: Add support for dotnet test --collect:"Code Coverage"](https://github.com/Microsoft/vstest/issues/981)

## Try out code coverage for yourself
### For an MSTestV2 based test project targeting .NET Core
1. Download "dotnet core sdk" from `https://dotnetcli.blob.core.windows.net/dotnet/Sdk/2.1.400-preview-008975/dotnet-sdk-2.1.400-preview-008975-win-x64.exe`
2. Install it.
3. Open powershell/cmd to run following commands.
    1. Create a directory. Example: D:\sample-projects\sample.Tests and "cd" to it.
    2. `dotnet new mstest`
    3. `dotnet add package Microsoft.NET.Test.SDK --version 15.8.0-preview-20180610-02
    4. `dotnet test –collect “Code coverage”`
    5. Open .coverage file in VS Enterprise to see the coverage info.

### On the solution in this repo (MSTestV2 + xUnit.net + NUnit)
The solution in this repo has 3 test projects (using MSTestV2, xUnit.net and NUnit)
The references have alreaday been updated as called out in the step 3.3 above.

Go to each folder within `Tests` and run the following command to generate code coverage data:
`dotnet test –collect "Code coverage"`
