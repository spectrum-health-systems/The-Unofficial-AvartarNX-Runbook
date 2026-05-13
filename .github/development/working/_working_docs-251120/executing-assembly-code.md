# Executing assembly code

```csharp
/// <summary>A required log file component.</summary>
public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;
```