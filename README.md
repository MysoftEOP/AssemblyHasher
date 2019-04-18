## Overview
AssemblyHasher, as its name implies, is a small tool for computing .NET assembly hash codes.It can determine if a .net assembly has changed.

## Usage
Usage is very simple:
```
var factory = HasherFactory.CreateHasher(path);
var md5 = factory.GetHash(path);
```

## Description
The same code, compiled on different machines, will get an assembly (.dll or .exe) with consistent effects but inconsistent files. Why does it cause inconsistencies? Because some extra information is written to the assembly during compilation ( .dll or .exe). When you determine that the assemblies are consistent, you need to exclude these "extra" and then compare them.You can get guidance from [here](https://docs.microsoft.com/en-us/dotnet/standard/assembly/file-format).

AssemblyHasher is to exclude these additional information for comparison.

For files that are not recognized as .net assemblies, the process will be downgraded to get the hash code.See [DefaultHasher class](https://github.com/MysoftEOP/AssemblyHasher/blob/master/AssemblyHasher.Core/DefaultHasher.cs).

Hopes this helps.
