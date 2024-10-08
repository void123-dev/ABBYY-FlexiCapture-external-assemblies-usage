Summary
​This repository demonstrates how to use external assemblies in ABBYY FlexiCapture scripts and global modules.​ It covers adding both standard and compiled user assemblies, managing shared assemblies across projects, and debugging external assemblies.

Key Points
Adding External Assemblies
External assemblies can be added in batch type properties, project properties, or Document Definition properties
Assemblies are added on the .Net References tab
Shared assemblies can be used across multiple batch types and Document Definitions
To add a shared assembly:
Go to project properties > .Net References
Click Add...
Select assembly type (Standard or Attached file)
Enter assembly name or browse to file
Using External Assemblies in Scripts
Classes and methods from external assemblies must be properly referenced
Example code for using an external assembly:
csharp
TestNameSpace.Test test = new TestNameSpace.Test();
test.Show("hello world");
Different script types require assemblies to be added in specific locations:
Event handler scripts: batch type or project properties
Other scripts (e.g., script rules, export scripts): Document Definition properties
Debugging External Assemblies
Both the assembly file and .pdb file with symbolic information are required for debugging
Registry keys can control loading of symbolic information:
LoadSymbolsFromOriginalPath: load .pdb files from original folders
PDBSearchLocations: set search paths for .pdb files
Restart the program after modifying registry keys
Use managed code connection for debugging assemblies
Best Practices
Use shared assemblies for common functionality across multiple batch types and Document Definitions
Update shared assemblies in project properties to affect all dependent components
Disable loading of symbolic information in working projects to improve performance
Enable symbolic information loading only when debugging is necessary
Sample Code
namespace TestNameSpace
{
    public class Test
    {
        public void Show(string text)
        {
            ABBYY.FlexiCapture.FCTools.ShowMessage(text, false);
        }
    }
}

This README provides an overview of working with external assemblies in ABBYY FlexiCapture, including how to add, use, and debug them. For more detailed information, refer to the official ABBYY FlexiCapture documentation.
