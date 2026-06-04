# Tingen Roadmap

- Encrypt data saved via `FieldOperation.SaveValue()`?

- Save an OO for testing?
- Service status message in data root
-  Verify "disabled" works (OO is returned correctly)
- trace logs

if can't trace or other log, primeval

review which primeval logs can be trace logs

More places to create service status files

LogEvent.Trace(1, traceInfo, msg)

if (traceLevel != 0) and (traceLevel <= traceLogMode)
{
    Do work to workOptionObject
}

returnOptionObject = workOptionObject.Clone()

Session\YYMMDD\UserId\HHMM\trace\fffffff_calledClass-lineNumber.trace