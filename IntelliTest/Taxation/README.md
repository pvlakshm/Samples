IntelliTest sample "Taxation" showing the following:
 - checking whether the code under test had testability issues
 - generating a compact suite with high coverage

This is a .NET Framework app modelling some taxation functionality.
 - the folder ```Models``` represents some entities from the domain - like, an employee, the house (s)he is living in, the location of the house, and a couple of exceptions that can be raised.
 - the folder ```DAL``` is the data access layer Repository and uses the environment to look up, and return, data about an employee. In this case it uses the file system. Such dependency on the external environment renders the code non-unit testable (it needs to be mocked, or dependency-injected, etc.)
 - and the folder ```TaxCalculators``` implements some tax calculations. The calculations are concrete implementations of the ITaxCalculator interface.

Do a "Run IntelliTest" inside ```TaxCalculator.CalculateExemptionForRent```. Note that IntelliTest is able to discover, and use, a concrete implementation for ITaxCalculator, is able to instantiate an Employee type using publicly accessible methods, and is able to set up the instance data on the type with real values. This lets IntelliTest generate a compact test suite with high code coverage.

Do a "Run IntelliTest" inside ```TaxRecord.EmployeeHRADeductionEligible```. Note that IntelliTest is able to discover, and use, a concrete instance of IDAL, and is able to instantiate a ```TaxRecord``` type (for 'd') using publicly accessible methods. The HRA method on the IDAL implementation access the ```FileSystem```. Note how IntelliTest flags that as a Testability issue.
