# Development notes

>This is a collection of Abatab development notes.

***

<br>



## Abbreviations

### Module

Module abbreviations are 8 characters.

* ProgNote = Progress Note
* Proto    = Prototype
* QMedOrdr = Quick Medication Order
* Testing  = Testing

### Keywords

Keyword abbreviations are 4 characters.

* Vfy  = Verify  

### Other abbreviations

* Loc  = Location
* Indi = Individual/Individualized
* Inde = Independent



# Flowchart colors

`F94144`: Abatab  
`277DA1`: Core.Catalog, Module.ProgressNote  
`F3722C`: Core.DataExport, Module.Prototype  
`577590`: Core.Framework, Module.QuickMedicationOrder  
`F8961E`: Core.Logger, Module.Testing
`4D908E`: Core.Session  
`F9844A`: Core.Utilities  
`43AA8B`: ScriptLinkStandard  
`F9C74F`:  
`90BE6D`:  


# New deployment

See "Abatab Lieutenant" for more info



# Comments

## Types of comments

`// Documentation`  
`/* Narrative */`  
`/// XML`

## Better Comments

Abatab uses the [Better Comments VS2022](https://marketplace.visualstudio.com/items?itemName=OmarRwemi.BetterCommentsVS2022) extension.

### Developer notes

Developer notes are contained in `/* DEVELOPER_NOTE */`

Example:

```csharp
/* DEVELOPER_NOTE
 * This is an example of a developer note.
 * More info.
 * Even more info
 */
```

### Questions

Questions are contained in `/* QUESTION */`

Example:

```csharp
/* QUESTION
 * This is a question
 */
```

### TODO

Todos are contained in `/* TODO */`

```csharp
/* TODO
 * Refactor this thing.
 * GitHub issue #123
 */
```

