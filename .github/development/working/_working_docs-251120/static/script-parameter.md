<!-- 250618 -->

_CONTENTS_  
[The Script Parameter](#the-script-parameter)  
[Components](#components)  
[Syntax](#syntax)  
[Valid requests](#valid-requests)  
[Depreciated](#depreciated)

# The Script Parameter <!-- static_documentation -->

The Script Parameter sent from Avatar contains all of the information that the Tingen Web Service needs to do what it needs to do.

The maximum length of a script parameter is 50 characters, and includes:

* The requested `Module` (the *namespace*)
* The requested `Command` (the *class*)
* The requested `Request` (the *method*)
* The requested `Option`

Components are seperated by a "`.`"

For example:

`Admin.Status.Current`

## Components <!-- static_documentation -->

## Syntax <!-- static_documentation -->

# Valid requests<!-- static_documentation -->

## Standard requests

```
12345678901234-1234567890-12345678901234567890-123
Module........-Command...-Action..............-Opt
```

* `Admin.Status.Current`
* `FormAccess.Deny.SysCodeDoc`
* `FormAccess.Deny.SysCodeDocHoc`
* `FormAccess.Deny.SysCodeList01`

## Prototype requests

```
12345678901234-1234567890-12345678901234567890-123
Module........-Command...-Action..............-Opt
```

* `_pFormAccess.Deny.DocSysCode`




## Prototypes

* _pDocSysCodeDenyAccessToForm

* Prototype.DocSysCode.DenyAccessToForm
* Admin.Status.Current
QuickMedicationOrder.Verify.Dose