<!-- u251118 -->

[[🏠︎](../README.md)]

<div align="center">

  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-dark-400x63.png">
    <source media="(prefers-color-scheme: light)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
    <img alt="Fallback image description" src="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
  </picture>
  <h1>
    Development cycle
  </h1>

</div>

# Overview

New versions of the Tingen Web Service are called **Releases**.

The release naming convention is: `RYY.MM`, where `YY` is the *year* of release (e.g., `26`) and `MM` is the *month* of release (e.g., `1`, `2`...`11`, `12`).

In general, releases are made available the first Monday of every month. For example, `R26.6` will be released on 



```mermaid
flowchart LR
    %% Components
    R26.1@{shape: rounded, label: "R26.1"}
    R26.2@{shape: rounded, label: "R26.2"}
    R26.3@{shape: rounded, label: "R26.3"}
    %% Layout
    R26.1:::U2_ --> R26.2:::U2_ --> R26.3:::U2_ -.-> HiddenA:::Hidden
    %% Styles
    classDef Hidden display: none;
    classDef U2_ stroke:#eaf2f8,stroke-width:2px,fill:#5499c7,color:#eaf2f8
```

```mermaid
flowchart LR
    %% Components
    R25.1@{shape: rounded, label: "R25.1"}
    R25.2@{shape: rounded, label: "R25.2"}
    R25.3@{shape: rounded, label: "R25.3"}

    subgraph WeeklyRelease [" "]
        direction LR
        %% Components
        Jed@{shape: rounded, label: "Jed"}
        Bennings@{shape: rounded, label: "Bennings"}
        Norris@{shape: rounded, label: "Norris"}
        Palmer@{shape: rounded, label: "Palmer"}
        Blair@{shape: rounded, label: "Blair"}
        %% Layout
        Jed:::f10_ --> Bennings:::f10_ --> Norris:::f10_ --> Palmer:::f10_ --> Blair:::f10_
        %% Styles
        
    end

    %% Layout
    R25.1 --> WeeklyRelease --> R25.2 --> R25.3
    %% Styles

    classDef f10_ font-size:10pt
```


flowchart LR
    %% Components
    A@{shape: rounded, label: "-.->"}
    B@{shape: rounded, label: "--->"}
    C@{shape: rounded, label: "===>"}
    HiddenA@{shape: rounded}
    E@{shape: rounded, label: "--o>"}
    F@{shape: rounded, label: "==o"}
    HiddenB@{shape: rounded}
    H@{shape: rounded, label: "--x>"}
    I@{shape: rounded, label: "==x>"}
    HiddenC@{shape: rounded}
    J@{shape: rounded, label: ["~ ~ ~"]}
    K@{shape: rounded, label: "Invisible!"}
    L@{shape: rounded, label: "Red line"}
    M@{shape: rounded, label: "Blue line, red text"}
    N@{shape: rounded, label: " "}
    HiddenD@{shape: rounded}
    %% Layout
    A -.-> B --> C ==> HiddenA
    E --o F ==o HiddenB
    H --x I ==x HiddenC
    J ~~~ K
    L --> M -- Text --> N
    %% Styles
    classDef Hidden display: none;
    class HiddenA,HiddenB,HiddenC,HiddenD Hidden
    linkStyle 8 stroke:#e74c3c,stroke-width:4px,color:red;
    linkStyle 9 stroke:#3498db ,stroke-width:4px,color:red;





```mermaid
flowchart LR
    %% Components
    January@{shape: rounded, label: "RYY.1"}
    February@{shape: rounded, label: "RYY.2"}
    March@{shape: rounded, label: "RYY.3"}
    April@{shape: rounded, label: "RYY.4"}
    May@{shape: rounded, label: "RYY.5"}
    June@{shape: rounded, label: "RYY.6"}
    July@{shape: rounded, label: "RYY.7"}
    August@{shape: rounded, label: "RYY.8"}
    September@{shape: rounded, label: "RYY.9"}
    October@{shape: rounded, label: "RYY.10"}
    November@{shape: rounded, label: "RYY.11"}
    December@{shape: rounded, label: "RYY.12"}
    %% Layout
    January:::aa_ --> February --> March --> April --> May --> June --> July --> August --> September --> October --> November --> December
    %% Styles
    classDef aa_ font-size:10pt
    classDef Y8_ stroke:#7d6608,stroke-width:3px,fill:#d4ac0d,color:#fef9e7
    classDef U3_ stroke:#eaf2f8,stroke-width:3px,fill:#2471a3,color:#eaf2f8
    classDef P3_ stroke:#f5eef8,stroke-width:3px,fill:#884ea0,color:#f5eef8
    classDef G3_ stroke:#e9f7ef,stroke-width:3px,fill:#1d8348,color:#e9f7ef
    classDef B8_ stroke:#626567,stroke-width:3px,fill:#000000,color:#626567
```


# Weekly

```mermaid
flowchart LR
    %% Components
    Jed@{shape: rounded, label: "RYY.MM-Jed"}
    Bennings@{shape: rounded, label: "RYY.MM-Bennings"}
    Norris@{shape: rounded, label: "RYY.MM-Norris"}
    Palmer@{shape: rounded, label: "RYY.MM-Palmer"}
    Blair@{shape: rounded, label: "RYY.MM-Blair"}
    Release@{shape: rounded, label: "RYY.MM"}
    %% Layout
    Jed:::E8_ --> Bennings:::Y8_ --> Norris:::U3_ --> Palmer:::P3_ -.-> Blair:::B8_ --> Release:::G3_
    %% Styles
    classDef E8_ stroke:#784212,stroke-width:3px,fill:#ca6f1e,color:#fdf2e9
    classDef Y8_ stroke:#7d6608,stroke-width:3px,fill:#d4ac0d,color:#fef9e7
    classDef U3_ stroke:#eaf2f8,stroke-width:3px,fill:#2471a3,color:#eaf2f8
    classDef P3_ stroke:#f5eef8,stroke-width:3px,fill:#884ea0,color:#f5eef8
    classDef G3_ stroke:#e9f7ef,stroke-width:3px,fill:#1d8348,color:#e9f7ef
    classDef B8_ stroke:#626567,stroke-width:3px,fill:#000000,color:#626567 
```



```mermaid
timeline
    title Tingen Web Service releases
    section 2025
        25.11: Jed (11/7)
             : Bennings (11/14)
             : Norris (11/21)
             : Palmer (11/28)
        25.12: Jed (12/5)
             : Bennings (12/12)
             : Norris (12/19)
             : Palmer (12/26)
    section 2026
        26.1: Jed (1/9)
            : Bennings (1/16)
            : Norris (1/23)
            : Palmer (1/30)
        26.2: Jed (2/6)
            : Bennings (2/13)
            : Norris (2/20)
            : Palmer (2/27)
        26.3: Jed (3/6)
            : Bennings (3/13)
            : Norris (3/20)
            : Palmer (3/27)
        26.4: Jed (4/3)
            : Bennings (4/10)
            : Norris (4/17)
            : Palmer (4/24)
        26.5: Jed (5/8)
            : Bennings (11/15)
            : Norris (5/22)
            : Palmer (5/29)
        26.6: Jed (6/5)
            : Bennings (6/12)
            : Norris (6/19)
            : Palmer (6/26)
```

```mermaid
---
config:
  gitGraph:
    showBranches: true
    showCommitLabel: true
    mainBranchName: 'R25.1'
---
gitGraph
        commit id:"Jed"
        commit id:"Bennings"
        commit id:"Norris"
        commit id:"Palmer"
        commit type: HIGHLIGHT id:"R25.1" tag:"25.1"
        branch R25.2
        commit id:"LosAngeles"
        commit id:"Chicago"
        commit id:"Houston"
```




***

[[🏠︎](../README.md)]


Jed
Bennings
Norris
Palmer
Blair
