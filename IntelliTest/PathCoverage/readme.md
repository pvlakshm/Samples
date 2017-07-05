"All paths" coverage of code will not be practical in many cases – the state space to analyze can explode.
But here is a fun example to try:

Do a "Run IntelliTest" on ```PathCoverage.ManyPaths``` and it will generate 3 tests: (0,0),(0,11),(11,0), but does not cover the case where the output would be “ab” (11,11).
By default, IntelliTest is setup to generate a compact suite with high coverage. In this setup, IntelliTest will emit a test only if an exploration traces through a new code path.
The 3 tests above are enough to get you 100% branch coverage. Hence IntelliTest stops at this point.

Now to get this to “all paths” coverage, do as follows:
(1) select the generated tests and save them (a test project will get created and added to the solution).
(2) in the test project, locate the PexMethod in the generated .cs file (it will look something like the following:
```
        [PexMethod]
        public int ManyPaths([PexAssumeUnderTest]Class1 target, int a, int b) ...
```

(3) Replace that ```PexMethod``` attribute with the following:
        ```[PexMethod(TestEmissionFilter = Microsoft.Pex.Framework.Settings.PexTestEmissionFilter.All)]```
This essentially overrides the default setting of when we emit a test.
You may want to play around with this, and other such, attributes from IntelliTest.

(4) Rerun IntelliTest on the ```ManyPaths``` method:
Now you will see the data set {11, 11} as well !
