Build script and Unit testing
=============================
Running the Build Script
------------------------

This build script compiles a C# console application and creates a packaged zip file.
This has been tested in Windows 11 operating system.

1. Prerequisites:

   a. Ensure that you have the .NET SDK installed on your machine.
   b. The dependencies 7-Zip are installed on your machine.

2. Script Execution steps:

   a. Open a command prompt.

   b. Navigate to the directory where the MSBuild file (buildScript.csproj) is located.

   c. Execute the following command: msbuild buildScript.csproj -t:Build
     
3. Expected Output:

   a. The script will compile the C# files and generate an executable(MyConsoleCalculator.exe) in the directory(build_bin).
   b. After successful compilation, the script will create a packaged zip file (MyConsoleCalculatorPackage.zip) using 7-Zip.

   Running the Unit test
   ---------------------
   This Unit test will test the methods of the application. The test cases consist of 3 passed test and 2 failed test.

   1. Prerequisites:
        a. NUnit package on your machine.
   2. Nativage to 'Test Explorer' in Microsoft Visual Studio and RUN the test cases.