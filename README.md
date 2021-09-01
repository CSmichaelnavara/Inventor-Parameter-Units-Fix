# Inventor-Parameter-Units-Fix

File [ParameterUnitsExtension.cs](ParameterUnitsExtension.cs) contains extension methods for Inventor.Parameter and its derivatives. This extension methods fix the issue in [Parameter.Units](https://help.autodesk.com/view/INVNTOR/2021/ENU/?guid=GUID-090CE11F-8D4A-4FB3-9E54-0CF74D025843) implementation. Usage of this property raises compiler exception [CS1545](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1545)

Copy this file or its content anywhere to your project and use this extension methods instead of default property.

```csharp
Parameter parameter = GetParameter();

// Get parameter units
//string units = parameter.Units; //CS1545
string units = parameter.Units(); // OK

// Set parameter units to [mm] by string
parameter.Units("mm");

//Set parameter units to [mm] by UnitsTypeEnum
parameter.Units(UnitsTypeEnum.kMillimeterLengthUnits);

```
