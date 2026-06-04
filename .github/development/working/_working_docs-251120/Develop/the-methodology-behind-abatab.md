# The methodology behind Abatab development'

This is where why Abatab is designed the way it is will be explained.

## General

/// <remarks>
/// - Defined at the start of the class so it can be easily used throughout the method when creating log files.
/// </remarks>
public static string AssemblyName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

## Abatab.asmx.cs

<!-- More information needed -->
Entry point, black box.