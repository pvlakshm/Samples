A .NET Fraemwork app modelling some banking services.

 - the folder Domain represents some entities from the domain - like, and account, an employee, an operation (deposit/withdraw),  and an opration
 - the folder Repository uses the Repository pattern to access a data source
 - the folder Data will use a data source as appropriate (currently just stubs)
 - and the folder Services implements some services like make a transfer, determine pension contribution for an employee, etc.
 
The method ```EmployeeServices.DeterminePensionContribution``` has some business logic. Do a "Run IntelliTest". Note that IntelliTest is able to generate a compact suite of tests with high coverage.
