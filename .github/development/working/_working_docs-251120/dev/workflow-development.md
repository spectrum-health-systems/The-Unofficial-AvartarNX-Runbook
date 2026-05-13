<!-- u250901 -->

<!--
  I'm sure the Mermaid.js code here looks awful, but it was a real pain to get
  all it looking the way it does, so I don't plan on touching it going forward.

  The rest of the document will be updated normally.
-->

# Daily workflow

This is the daily workflow for all Tingen projects.

<div align="center">

```mermaid
flowchart LR 
  %% Components
  Start@{shape: sm-circ, label: ""}
  Preparation@{shape: rounded, label: "Preparation"}
  Development@{shape: rounded, label: "Development"}
  Finish@{shape: rounded, label: "Finish"}
  %% Subgraphs
  %% Layout
  Start --> Preparation:::R2_ --> Development:::P2_ --> Finish:::U2_
  %% Styles
  classDef P2_ stroke:#f5eef8,stroke-width:3px,fill:#af7ac5,color:#f5eef8
  classDef R2_ stroke:#f9ebea,stroke-width:3px,fill:#CD6155,color:#f9ebea
  classDef U2_ stroke:#eaf2f8,stroke-width:3px,fill:#5499c7,color:#eaf2f8
  classDef Hidden display: none;
```

</div>

## Preparation

<div align="center">

```mermaid
flowchart LR
  %% Components
  Start@{shape: sm-circ, label: ""}
  AutoHotKey@{shape: rounded, label: "Start\nAutoHotkey"}
  VSCodeWorkspaces@{shape: rounded, label: "Open VS Code\nworkspaces"}
  VS2022Solutions@{shape: rounded, label: "Open Visual Studio\nsolutions"}
  GitHubDesktop@{shape: rounded, label: "Start GitHub\nDesktop"}
  Development@{shape: rounded, label: "Development"}
  Finish@{shape: rounded, label: "Finish"}
  %% Subgraphs
  %% Layout
  Start --> AutoHotKey:::R2_ --> VSCodeWorkspaces:::R2_ --> VS2022Solutions:::R2_  -->GitHubDesktop:::R2_ --> Development:::P2_ --> Finish:::U2_
  %% Styles
  classDef P2_ stroke:#f5eef8,stroke-width:3px,fill:#af7ac5,color:#f5eef8
  classDef R2_ stroke:#f9ebea,stroke-width:3px,fill:#CD6155,color:#f9ebea
  classDef U2_ stroke:#eaf2f8,stroke-width:3px,fill:#5499c7,color:#eaf2f8
  classDef Hidden display: none;
```

</div>

## Development

<div align="center">

```mermaid
flowchart TB 
  %% Components
  Start@{shape: sm-circ, label: ""}
  Preparation@{shape: rounded, label: "Preparation"}
  subgraph _Development ["Development"]
    direction LR
      DeployToUat@{shape: rounded, label: "Deploy To UAT"}
      Test@{shape: diamond, label: "Test"}
      subgraph _SourceCodeModifications ["Source code modifications"]
        direction LR
        %% Components
        NewFunctionality@{shape: rounded, label: "New\nfunctionality"}
        UpdateExistingFunctionality@{shape: rounded, label: "Update existing\nfunctionality"}
        BugFixes@{shape: rounded, label: "Bug fixes"}
        Refactoring@{shape: rounded, label: "Refactoring"}
        Other@{shape: rounded, label: "Other"}
        NewFunctionality:::P8_ --> UpdateExistingFunctionality:::P8_ --> BugFixes:::P8_ --> Refactoring:::P8_ --> Other:::P8_
      end
      subgraph _Documentation ["Documentation"]
        direction TB
        %% Components
        SourceCodeDocumentation@{shape: docs, label: "Source code documentation"}
        ProjectManual@{shape: docs, label: "Project Manual"}
        APIDocumentation@{shape: docs, label: "API documentation"}
        DevMiscDocumentation@{shape: docs, label: "Development\\miscellaneous\ndocumentation"}
        SourceCodeDocumentation:::P8_ ~~~ ProjectManual:::P8_ ~~~ APIDocumentation:::P8_ ~~~ DevMiscDocumentation:::P8_
      end
      _SourceCodeModifications:::P8_ --> DeployToUat:::P4_ --> Test:::P4_ 
  end
  Finish@{shape: rounded, label: "Finish"}
  %% Subgraphs
  %% Layout
  Start --> Preparation:::R2_ --> _Development:::P2_ --> Finish:::U2_
  Test -- Fail --> _SourceCodeModifications
  Test -- Success --> _Documentation:::P1_
  _Documentation --> _SourceCodeModifications:::P1_
  %% Styles
  classDef G9_ stroke:#145a32,stroke-width:3px,fill:#145a32,color:#e9f7ef
  classDef P0_ stroke:#f5eef8,stroke-width:3px,fill:#f5eef8,color:#512e5f
  classDef P1_ stroke:#f5eef8,stroke-width:3px,fill:#d7bde2,color:#512e5f
  classDef P2_ stroke:#f5eef8,stroke-width:3px,fill:#af7ac5,color:#f5eef8
  classDef P3_ stroke:#f5eef8,stroke-width:3px,fill:#884ea0,color:#f5eef8
  classDef P4_ stroke:#f5eef8,stroke-width:3px,fill:#512e5f,color:#f5eef8
  classDef P5_ stroke:#512e5f,stroke-width:3px,fill:#f5eef8,color:#512e5f
  classDef P6_ stroke:#512e5f,stroke-width:3px,fill:#d7bde2,color:#512e5f
  classDef P7_ stroke:#512e5f,stroke-width:3px,fill:#af7ac5,color:#f5eef8
  classDef P8_ stroke:#512e5f,stroke-width:3px,fill:#884ea0,color:#f5eef8
  classDef P9_ stroke:#512e5f,stroke-width:3px,fill:#512e5f,color:#f5eef8
  classDef R2_ stroke:#f9ebea,stroke-width:3px,fill:#CD6155,color:#f9ebea
  classDef R9_ stroke:#641e16,stroke-width:3px,fill:#641e16,color:#f9ebea
  classDef U2_ stroke:#eaf2f8,stroke-width:3px,fill:#5499c7,color:#eaf2f8
  classDef Hidden display: none;
  linkStyle 0 stroke:#000000 ,stroke-width:4px,color:red;
  linkStyle 1 stroke:#000000 ,stroke-width:4px,color:red;
  linkStyle 2 stroke:#000000 ,stroke-width:4px,color:red;
  linkStyle 3 stroke:#000000 ,stroke-width:4px,color:red;
  linkStyle 12 stroke:#641e16 ,stroke-width:4px,color:red;
  linkStyle 13 stroke:#145a32 ,stroke-width:4px,color:green;
```

</div>

# Monthly workflow

<div align="center">

```mermaid
flowchart TB
  %% Components
  Start@{shape: sm-circ, label: "Start the workflow\n[sm-circ]"}
  UpdateComponents@{shape: rounded, label: "Update\ncomponents"}
  Development@{shape: rounded, label: "Development"}
  Release@{shape: rounded, label: "Release"}
  %% Subgraphs
  subgraph _Archive ["Archive"]
    direction LR
      subgraph _ArchiveRepositories ["Repositories"]
        direction LR
        %% Components
        ArchiveTingenWebService@{shape: rounded, label: "Archive\nTingen\nWeb Service"}
        ArchiveOutpost31@{shape: rounded, label: "Archive\nOutpost31"}
        ArchiveTingenDocumentation@{shape: rounded, label: "Archive\nTingen\ndocumentation"}
        ArchiveTingenCommander@{shape: rounded, label: "Archive\nTingen\nCommander"}
        %% Layout
        ArchiveTingenWebService:::R7_ ~~~ ArchiveOutpost31:::R7_ ~~~ ArchiveTingenDocumentation:::R7_ ~~~ ArchiveTingenCommander:::R7_
      end
  end
  %% Layout
  Start --> _Archive:::R5_ --> UpdateComponents:::B7a_ --> Development:::B7a_ --> Release:::B7a_
  _ArchiveRepositories:::R6_   
  %% Styles
  classDef R5_ stroke:#641e16,stroke-width:3px,fill:#f9ebea,color:#641e16
  classDef R6_ stroke:#641e16,stroke-width:3px,fill:#E6B0AA,color:#641e16
  classDef R7_ stroke:#641e16,stroke-width:3px,fill:#CD6155,color:#f9ebea
  classDef B7a_ stroke:#7b7d7d,stroke-width:3px,fill:#000000,color:#7b7d7d,font-size: 10pt
  classDef Hidden display: none;
```

</div>

## Archive repositories

### Development branches

Use the *development* branch of the following repositories to create a `RYY.DD` branch:

* tingen-web-service
* outpost31

### Main branches

Use the *main* branch of the following repositories to create a `RYY.DD` branch:

* tingen-documentation-project

<br>

***

<br>

<!-- UPDATE COMPONENTS -->

## UPDATE COMPONENTS

<div align="center">

```mermaid
flowchart TB 
  %% Components
  Start@{shape: sm-circ, label: "Start the workflow\n[sm-circ]"}
  Archive@{shape: rounded, label: "Archive"}
  Development@{shape: rounded, label: "Development"}
  Release@{shape: rounded, label: "Release"}
  %% Subgraphs
  subgraph _UpdateComponents ["Update Components"]
    direction LR
    %% Components
    UpdateAutoHotKey@{shape: rounded, label: "Update\nAutoHotKey script"}
    UpdateSandCastleProfiles@{shape: rounded, label: "Update\nSandcastle profiles"}
    UpdateAutoHotKey:::P6_ ~~~ UpdateSandCastleProfiles:::P6_ ~~~ _UpdateSourceCode:::P6_ ~~~ _UpdateDocumentation:::P6_
  end
  subgraph _UpdateSourceCode ["Update source code"]
    direction TB
    %% Components
    UpdateAssemblyInfo@{shape: rounded, label: "Update\nAssemblyInfo.cs"}
    UpdateClassHeaders@{shape: rounded, label: "Update\nclass headers"}
    UpdateTngnBuild@{shape: rounded, label: "Update\nTngnBuild value"}
    UpdateAssemblyInfo:::P7_ ~~~ UpdateClassHeaders:::P7_ ~~~ UpdateTngnBuild:::P7_
  end
  subgraph _UpdateDocumentation ["Update documentation"]
    direction TB
    %% Components
    UpdateTingenManual@{shape: docs, label: "Update\nTingen Manual"}
    UpdateAPIDocumentation@{shape: docs, label: "Update\nAPI documentation"}
    UpdateDevelopmentDocumentation@{shape: docs, label: "Update\nDevelopment documentation"}
    UpdateTingenManual:::P7_ ~~~ UpdateAPIDocumentation:::P7_ ~~~ UpdateDevelopmentDocumentation:::P7_
  end
  %% Layout
  Start --> Archive:::B7a_ --> _UpdateComponents:::P5_ --> Development:::B7a_ --> Release:::B7a_
  %% Styles
  classDef P5_ stroke:#512e5f,stroke-width:3px,fill:#f5eef8,color:#512e5f
  classDef P5a_ stroke:#512e5f,stroke-width:3px,fill:#f5eef8,color:#512e5f,font-size:8p
  classDef P6_ stroke:#512e5f,stroke-width:3px,fill:#d7bde2,color:#512e5f
  classDef P7_ stroke:#512e5f,stroke-width:3px,fill:#af7ac5,color:#f5eef8
  classDef B7a_ stroke:#7b7d7d,stroke-width:3px,fill:#000000,color:#7b7d7d,font-size: 10pt
  classDef Hidden display: none;
```

</div>

### Update the AutoHotKey script

Update the following components of the AutoHotkey script:

* ALT+CTRL+SHIFT+Y
  
### Update Sandcastle profiles

Update the Sandcastle "Help file version" in the following Sandcastle profiles:

* Tingen-WebService
* Outpost31
* Tingen-Commander

### Update the source code

#### AssemblyInfo.cs

Update the following `AssemblyInfo.cs` files with the current version number:

* Tingen-WebService/Properties/AssemblyInfo.cs
* Outpost31/Properties/AssemblyInfo.cs
* Tingen-Commander/Properties/AssemblyInfo.cs
  
#### Class file headers

Update the file headers for the following files:

* TingenWebService.ProjectInfo.cs
* Outpost31.ProjectInfo.cs
* TingenCommander.MainWindow.xaml.cs

<!-- DEPRECIATED

#### The `tnBuild` value

Update `tnBuild` value in `Core.ConfigRuntime.New()` to the current `YYMMDD` value.

For example:

```text
.
.
TngnWbsvBuild = "250430",
.
.
```

-->

### Update the documentation

Search for the following string in the documentation...

```markdown
![Release](https://img.shields.io/badge/release-VERSION-teal)
```

...where `VERSION` is the version/release for the current documentation.

Replace the value of `VERSION` with the current version/release.

<br>

***

<br>



## New functionality

## Updating existing functionality

## Bug fixes

## Refactoring

## Other

## Deploying to UAT

## Testing

## Updating XML documentation

## Updating the Tingen Manual

## Updating the API documentation

## Updating the Development documentation

<!-- RELEASE -->

# RELEASE

<div align="center">

```mermaid
flowchart TB 
  %% Components
  Start@{shape: sm-circ, label: "Start the workflow\n[sm-circ]"}
  Archive@{shape: rounded, label: "Archive"}
  UpdateComponents@{shape: rounded, label: "Update\ncomponents"}
  Development@{shape: rounded, label: "Development"}
  %% Subgraphs
  subgraph _Release ["Release"]
    direction TB
      ReleaseCandidate@{shape: rounded, label: "Release\ncandidate"}
      StableRelease@{shape: rounded, label: "Stable\release"}
      CommunityRelease@{shape: rounded, label: "Community\nrelease"}
      ReleaseCandidate:::G7_
      StableRelease:::G7_
      CommunityRelease:::G7_
    end
  %% Layout
  Start --> Archive:::B7a_ --> UpdateComponents:::B7a_ --> Development:::B7a_ --> _Release:::G5_
  %% Styles
  classDef G5_ stroke:#145a32,stroke-width:3px,fill:#eaf2f8,color:#154360
  classDef G6_ stroke:#145a32,stroke-width:3px,fill:#a9dfbf,color:#145a32
  classDef G7_ stroke:#145a32,stroke-width:3px,fill:#52be80,color:#e9f7ef
  classDef B7a_ stroke:#7b7d7d,stroke-width:3px,fill:#000000,color:#7b7d7d,font-size: 10pt
  classDef Hidden display: none;
```

</div>

## Release candidate

## Stable

## Community

* December 20: Abatab WinterYY
* March 20: Abatab SpringYY
* June 20: Abatab SummerYY
* September 20: Abatab AutumnYY

For example: `Abatab Autumn23`



<!-- unused

<div align="center">

```mermaid
flowchart TB 
  %% Components
  Start@{shape: sm-circ, label: "Start the workflow\n[sm-circ]"}
  Archive@{shape: rounded, label: "Archive"}
  UpdateComponents@{shape: rounded, label: "Update\ncomponents"}
  Release@{shape: rounded, label: "Release"}
  %% Subgraphs
  subgraph _Development ["Development"]
    direction LR
      DeployToUat@{shape: rounded, label: "Deploy To UAT"}
      Test@{shape: diamond, label: "Test"}
      subgraph _SourceCodeModifications ["Source code modifications"]
        direction TB
        %% Components
        NewFunctionality@{shape: rounded, label: "New\nfunctionality"}
        UpdateExistingFunctionality@{shape: rounded, label: "Update existing\nfunctionality"}
        BugFixes@{shape: rounded, label: "Bug fixes"}
        Refactoring@{shape: rounded, label: "Refactoring"}
        Other@{shape: rounded, label: "Other"}
        NewFunctionality:::U7_
        UpdateExistingFunctionality:::U7_
        BugFixes:::U7_
        Refactoring:::U7_
        Other:::U7_
      end
      subgraph _Documentation ["Documentation"]
        direction TB
        %% Components
        XmlDocumentation@{shape: docs, label: "XML documentation"}
        TingenManual@{shape: docs, label: "Tingen Manual"}
        APIDocumentation@{shape: docs, label: "API documentation"}
        DevelopmentDocumentation@{shape: docs, label: "Development documentation"}
        XmlDocumentation:::U7_ ~~~ TingenManual:::U7_ ~~~ APIDocumentation:::U7_ ~~~ DevelopmentDocumentation:::U7_
      end
      _SourceCodeModifications:::U6_ --> DeployToUat:::U6_ --> Test:::U6_  
  end
  %% Layout
  Start --> Archive:::B7a_ --> UpdateComponents:::B7a_ --> _Development:::U5_ --> Release:::B7a_
  Test -- Fail --> _SourceCodeModifications
  Test -- Success --> _Documentation:::U6_
  _Documentation --> _SourceCodeModifications
  %% Styles
  classDef U5_ stroke:#154360,stroke-width:3px,fill:#eaf2f8,color:#154360
  classDef U6_ stroke:#154360,stroke-width:3px,fill:#a9cce3,color:#154360
  classDef U7_ stroke:#154360,stroke-width:3px,fill:#5499c7,color:#eaf2f8
  classDef B7a_ stroke:#7b7d7d,stroke-width:3px,fill:#000000,color:#7b7d7d,font-size: 10pt
  classDef Hidden display: none;
  linkStyle 3,4,11 stroke:#000000,stroke-width:2px
  linkStyle 9 stroke:#A93226,stroke-width:2px, color: #E6B0AA
  linkStyle 10 stroke:#1d8348,stroke-width:2px, color: #a9dfbf
```

</div>

-->