<!--
  This header should be at the top of every Abatab Documentation Project page.
  b240102
-->

<div align="center">

![](/.github/resources/images/logos/abatab-documentation-project-logo.png)

</div>

# Abatab development

This document details various components of Abatab development.

# Development workflow

In general, Abatab development looks like this:

```mermaid
flowchart LR
  Development("Development")-->Testing("Testing")-->Release("Release")-->CommunityRelease("Community release")

  style Development fill:#003366,color:#FFFFFF,stroke:#FFFFFF,stroke-width:2px
  style Testing fill:#006600,color:#FFFFFF,stroke:#FFFFFF,stroke-width:2px
  style Release fill:#660066,color:#FFFFFF,stroke:#FFFFFF,stroke-width:2px
  style CommunityRelease fill:#FF6600,color:#FFFFFF,stroke:#FFFFFF,stroke-width:2px
```

<br>

In more detail:

```mermaid
flowchart LR
  Development("`Development
  (**branch:development**)`")-->MergeWithBranchMain{{"`Merge
  **branch:development**
  with
  **branch:main**`"}}
  MergeWithBranchMain-->Testing("`Testing
  (**branch:main**)`")
  Testing-->MergeWithBranchStable{{"`Merge
  **branch:main**
  with
  **branch:stable**`"}}
  MergeWithBranchStable-->CommunityRelease("Community release")

  style Development fill:#003366,color:#FFFFFF,stroke:#FFFFFF,stroke-width:2px
  style MergeWithBranchMain fill:#009999,color:#FFFFFF,stroke:#FFFFFF,stroke-width:2px
  style Testing fill:#006600,color:#FFFFFF,stroke:#FFFFFF,stroke-width:2px
  style MergeWithBranchStable fill:#660066,color:#FFFFFF,stroke:#FFFFFF,stroke-width:2px
  style CommunityRelease fill:#FF6600,color:#FFFFFF,stroke:#FFFFFF,stroke-width:2px
```

<br>

*Even more* more detail:

```mermaid
flowchart LR
  subgraph DevelopmentBlock ["Development"]
    direction LR
    DevNewFeatures(["New features"])
    DevUpdateFunctionality(["Updated functionality"])
    DevBugFixes(["Bug fixes"])
    DevEtc(["Etc..."])
  end
  subgraph TestingBlock ["Testing"]
    direction LR
    DevelopmentTesting("Development
    testing")-- "Regression testing\n complete" -->RegressionTesting("Regression
    testing")
  end
  DevelopmentBlock-->MergeWithBranchMain{{"`Merge
  **branch:development**
  with
  **branch:main**`"}}
  MergeWithBranchMain-->DevelopmentTesting
  RegressionTesting-->MergeWithBranchStable{{"`Merge
  **branch:main**
  with
  **branch:stable**`"}}
  MergeWithBranchStable-->CommunityRelease("Community release")

  style DevelopmentBlock fill:#003366,color:#FFFFFF,stroke:#FFFFFF,stroke-width:2px
  style DevNewFeatures fill:#336699,color:#FFFFFF,stroke:#FFFFFF,stroke-width:2px
  style DevUpdateFunctionality fill:#336699,color:#FFFFFF,stroke:#FFFFFF,stroke-width:2px
  style DevBugFixes fill:#336699,color:#FFFFFF,stroke:#FFFFFF,stroke-width:2px
  style DevEtc fill:#336699,color:#FFFFFF,stroke:#FFFFFF,stroke-width:2px
  style MergeWithBranchMain fill:#009999,color:#FFFFFF,stroke:#FFFFFF,stroke-width:2px
  style TestingBlock fill:#006600,color:#FFFFFF,stroke:#FFFFFF,stroke-width:2px
  style DevelopmentTesting fill:#009900,color:#FFFFFF,stroke:#FFFFFF,stroke-width:2px
  style RegressionTesting fill:#009900,color:#FFFFFF,stroke:#FFFFFF,stroke-width:2px
  style MergeWithBranchStable fill:#660066,color:#FFFFFF,stroke:#FFFFFF,stroke-width:2px
  style CommunityRelease fill:#FF6600,color:#FFFFFF,stroke:#FFFFFF,stroke-width:2px
```

<!--
  This footer should be at the bottom of every Abatab Documentation Project page.
-->

<br>

***

<div align="center">

This document is part of the
[Abatab Documentation Project](/README.md)<br>
	
<sub>
Last updated: January 2, 2024<br>
</sub>
</div>
