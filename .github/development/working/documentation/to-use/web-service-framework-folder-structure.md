===================
THIS IS DEPRECIATED
===================

<details>
  <summary>[Click here to expand the folder structure diagram]</summary>

    .
    ├── Tingen
    │   ├── Archive
    │   ├── LIVE
    │   │   ├── bin
    │   ├── UAT
    │   │   ├── bin  
    ├── TingenData
    │   ├── Commander
    │   ├── DevDeploy
    │   │   ├── Logs
    │   │   ├── Staging
    │   ├── LIVE
    │   │   ├── Config
    │   │   ├── Exports
    │   │   │   ├── Reports
    │   │   ├── Extensions
    │   │   ├── Imports
    │   │   │   ├── FromAvatar
    │   │   │   ├── Templates
    │   │   ├── Messages
    │   │   │   ├── Alerts
    │   │   │   ├── Errors
    │   │   │   ├── Warnings
    │   │   ├── Security
    │   │   ├── Sessions
    │   │   ├── Support
    │   │   │   ├── Admin
    │   │   │   ├── Archive
    │   │   │   ├── Debugging
    │   │   │   ├── Logs
    │   │   ├── Temporary
    │   ├── Primeval
    │   ├── Public
    │   │   ├── Alerts
    │   │   ├── Errors
    │   │   ├── Errors
    │   │   ├── Reports
    │   │   ├── Warnings
    │   ├── Remote
    │   │   ├── Alerts
    │   │   ├── Errors
    │   │   ├── Errors
    │   │   ├── Reports
    │   │   ├── Sessions
    │   │   ├── Warnings
    │   ├── UAT
    │   │   ├── Config
    │   │   ├── Exports
    │   │   │   ├── Reports
    │   │   ├── Extensions
    │   │   ├── Imports
    │   │   │   ├── FromAvatar
    │   │   │   ├── Templates
    │   │   ├── Messages
    │   │   │   ├── Alerts
    │   │   │   ├── Errors
    │   │   │   ├── Warnings
    │   │   ├── Security
    │   │   ├── Sessions
    │   │   ├── Support
    │   │   │   ├── Admin
    │   │   │   ├── Archive
    │   │   │   ├── Debugging
    │   │   │   ├── Logs
    │   │   ├── Temporary

</details>

> Each of these folders has a `README.md` file with additional details.

# Tingen\\  

* Contains the required Tingen Web service code
* Does not contain any actual data

### Tingen\\Archive\\

Archived snapshots of previous Tingen deployments.

### Tingen\\LIVE\\

The web service that is used by the ***LIVE*** environment.

### Tingen\\UAT\\

The web service that is used by the ***UAT*** environment.

# TingenData\\  

* Contains data required by Tingen (and related projects)
* Contains data created by Tingen (and related projects)
* Data may contain client-specific information
* Should be locked down/hardened

### TingenData\\Commander\\

Tingen Commander data (not currently used)

### TingenData\\DevDeploy\\

Tingen DevDeploy data.

### TingenData\\Lieutenant\\

Tingen Lieutenant data (depreciated)

### TingenData\\LIVE\\

Tingen data created buy the LIVE web service

### TingenData\\Primeval\\

Primeval logs

### TingenData\\Public\\

Public data

### TingenData\\Remote\\

Remote data

### TingenData\\UAT\\

Tingen data created buy the UAT web service

test


```text
.
├── Tingen
│   ├── Archive
│   ├── LIVE
│   │   ├── bin
│   ├── UAT
│   │   ├── bin 
```


2.2 C:\Tingen structure
There are two sub-directories in C\Tingen:
⦁	C:\Tingen\LIVE
Contains the web service for the LIVE environment.

⦁	C:\Tingen\UAT
Contains the web service for the LIVE environment.

For more information about how files get here, please refer to the documentation on Deploying Tingen.

2.3 C:\TingenData structure
The C:\TingenData directory contains a number of sub-directories:
⦁	\Commander
⦁	\DevDeploy
⦁	\Lieutenant
These directories store data for three Tingen-adjacent applications:  TingenCommander (coming soon), Tingen Lieutenant (coming soon), and Tingen DevDeploy. Each of these applications will eventually have their own documentation.

⦁	\LIVE
⦁	\UAT
This location contains all of the data for the System Code instances of Tingen. More information can be found in section X.X.

⦁	\Primeval
Debugging information is stored here.

⦁	\Public
⦁	\Remote
Information that is made available to specific staff is stored here. More information can be found in section X.X.

It is recommended that you map a drive to the “\TingenData” folder.


2.4 System Code directory structure
The C:\TingenData directory contains two sub-directories, one for each System Code instance of the Tingen web service:
⦁	\LIVE
⦁	\UAT
Both System Code instances have the same structure:
⦁	\Config
All Tingen web service configuration files are stored here, including all Module configurations.

⦁	\Exports
Data that Tingen exports.

⦁	\Reports
Placeholder for future functionality.

⦁	\Extensions
Placeholder for future functionality.

⦁	\Imports
Data that Tingen imports is stored here.

⦁	\FromAvatar
Data that is exported from avatar to be imported by 

⦁	\Templates
Placeholder for future functionality.

⦁	\Messages
When a user receives a message popup, a copy is stored here.

⦁	\Alerts
⦁	\Errors
⦁	\Warnings
These are the different messages users will receive.	

⦁	\Security
Placeholder for future functionality.


⦁	\Sessions
Session data is stored here.

⦁	\YYMMDD (ex: 240618)
All session data for the specific day, all users.

⦁	\AvatarUserId (ex: JSMITH)
All session data for a specific Avatar staff

⦁	\HHMMSS-%TingenRequest% (ex: 124255-Check-Dose-Amount)
All information for individual sessions, including log files, session information, etc.

⦁	\Support
Development/debugging information is stored here.

⦁	\Temporary
Temporary data is stored here.

2.5 \Public and \Remote directory structure
Copies of important/useful information is stored in these two directories, available to users that have been granted permission to the directories themselves.
The \Public directory is intended for elevated staff/managers that should be aware of any alerts or warnings.
The \Remote directory is intended for users that should have more behind-the-scenes data/information about Tingen.
Both \Public and \Remote have the following directories:
⦁	\Alerts
Alert messages generated by Tingen.

⦁	\Errors
Error messages generated by Tingen.

⦁	\Reports
Exported reports.

⦁	\Warnings
Warnings messages generated by Tingen.
In addition to the directories above, the \Remote directory also contains the following:
⦁	\Exports
Exported data.

⦁	Current-Tingen-LIVE-Settings.md
⦁	Current-Tingen-UAT-Settings.md
Documents detailing the current Tingen settings.

⦁	TINGEN LIVE IS CURRENTLY %TingenMode%
⦁	TINGEN UAT IS CURRENTLY %TingenMode%
The status of each Tingen instance.





These are the different messages users will receive.
 






***


<!-- u240925 -->

<div align="center">

  ![logo](../../.github/image/logos/TingenDevelopmentDocumentation_logo_320x420.png)

  <h1>
    Tingen Web Service Framework
  </h1>

![TINGEN_VERSION](https://img.shields.io/badge/BASED%20ON%20Tingen%2024.10-white?style=for-the-badge)

</div>

# Folder structure

<!--
  Since the folder structure diagram is pretty long, we'll start it minimized
  and allow readers to expand it.

  Leave this as-is, it doesn't need backticks to show code.
-->

<details>
  <summary>[Click here to expand the folder structure diagram]</summary>

    .
    ├── Tingen
    │   ├── Archive
    │   ├── LIVE
    │   │   ├── bin
    │   ├── UAT
    │   │   ├── bin  
    ├── TingenData
    │   ├── Commander
    │   ├── DevDeploy
    │   │   ├── Logs
    │   │   ├── Staging
    │   ├── LIVE
    │   │   ├── Config
    │   │   ├── Exports
    │   │   │   ├── Reports
    │   │   ├── Extensions
    │   │   ├── Imports
    │   │   │   ├── FromAvatar
    │   │   │   ├── Templates
    │   │   ├── Messages
    │   │   │   ├── Alerts
    │   │   │   ├── Errors
    │   │   │   ├── Warnings
    │   │   ├── Security
    │   │   ├── Sessions
    │   │   ├── Support
    │   │   │   ├── Admin
    │   │   │   ├── Archive
    │   │   │   ├── Debugging
    │   │   │   ├── Logs
    │   │   ├── Temporary
    │   ├── Primeval
    │   ├── Public
    │   │   ├── Alerts
    │   │   ├── Errors
    │   │   ├── Errors
    │   │   ├── Reports
    │   │   ├── Warnings
    │   ├── Remote
    │   │   ├── Alerts
    │   │   ├── Errors
    │   │   ├── Errors
    │   │   ├── Reports
    │   │   ├── Sessions
    │   │   ├── Warnings
    │   ├── UAT
    │   │   ├── Config
    │   │   ├── Exports
    │   │   │   ├── Reports
    │   │   ├── Extensions
    │   │   ├── Imports
    │   │   │   ├── FromAvatar
    │   │   │   ├── Templates
    │   │   ├── Messages
    │   │   │   ├── Alerts
    │   │   │   ├── Errors
    │   │   │   ├── Warnings
    │   │   ├── Security
    │   │   ├── Sessions
    │   │   ├── Support
    │   │   │   ├── Admin
    │   │   │   ├── Archive
    │   │   │   ├── Debugging
    │   │   │   ├── Logs
    │   │   ├── Temporary

</details>

## Tingen\\  
  This directory contains the actual Tingen Web service code, which is called from a ScriptLink event in Avatar.
  
  This directory does not contain any actual data, it’s just the code that runs the web service.

### Tingen\\Archive\\


## TingenData\\  
  This directory contains the data that Tingen needs/uses to do what it does.


## Tingen\

### Tingen\Archive

test


```text
.
├── Tingen
│   ├── Archive
│   ├── LIVE
│   │   ├── bin
│   ├── UAT
│   │   ├── bin 
```

# C:\TingenData










  * Configuration files
  * Import data that Tingen needs to function
  * Messages (alerts/errors/warnings)
  * Debugging information


The web service (C:\Tingen) and the data (C:\TingenData) are separated for security reasons. Aside from a handful of specific files that Tingen imports, the Tingen web service does not read data from C:\TingenData, it only writes data.









2.2 C:\Tingen structure
There are two sub-directories in C\Tingen:
⦁	C:\Tingen\LIVE
Contains the web service for the LIVE environment.

⦁	C:\Tingen\UAT
Contains the web service for the LIVE environment.

For more information about how files get here, please refer to the documentation on Deploying Tingen.

2.3 C:\TingenData structure
The C:\TingenData directory contains a number of sub-directories:
⦁	\Commander
⦁	\DevDeploy
⦁	\Lieutenant
These directories store data for three Tingen-adjacent applications:  TingenCommander (coming soon), Tingen Lieutenant (coming soon), and Tingen DevDeploy. Each of these applications will eventually have their own documentation.

⦁	\LIVE
⦁	\UAT
This location contains all of the data for the System Code instances of Tingen. More information can be found in section X.X.

⦁	\Primeval
Debugging information is stored here.

⦁	\Public
⦁	\Remote
Information that is made available to specific staff is stored here. More information can be found in section X.X.

It is recommended that you map a drive to the “\TingenData” folder.


2.4 System Code directory structure
The C:\TingenData directory contains two sub-directories, one for each System Code instance of the Tingen web service:
⦁	\LIVE
⦁	\UAT
Both System Code instances have the same structure:
⦁	\Config
All Tingen web service configuration files are stored here, including all Module configurations.

⦁	\Exports
Data that Tingen exports.

⦁	\Reports
Placeholder for future functionality.

⦁	\Extensions
Placeholder for future functionality.

⦁	\Imports
Data that Tingen imports is stored here.

⦁	\FromAvatar
Data that is exported from avatar to be imported by 

⦁	\Templates
Placeholder for future functionality.

⦁	\Messages
When a user receives a message popup, a copy is stored here.

⦁	\Alerts
⦁	\Errors
⦁	\Warnings
These are the different messages users will receive.	

⦁	\Security
Placeholder for future functionality.


⦁	\Sessions
Session data is stored here.

⦁	\YYMMDD (ex: 240618)
All session data for the specific day, all users.

⦁	\AvatarUserId (ex: JSMITH)
All session data for a specific Avatar staff

⦁	\HHMMSS-%TingenRequest% (ex: 124255-Check-Dose-Amount)
All information for individual sessions, including log files, session information, etc.

⦁	\Support
Development/debugging information is stored here.

⦁	\Temporary
Temporary data is stored here.

2.5 \Public and \Remote directory structure
Copies of important/useful information is stored in these two directories, available to users that have been granted permission to the directories themselves.
The \Public directory is intended for elevated staff/managers that should be aware of any alerts or warnings.
The \Remote directory is intended for users that should have more behind-the-scenes data/information about Tingen.
Both \Public and \Remote have the following directories:
⦁	\Alerts
Alert messages generated by Tingen.

⦁	\Errors
Error messages generated by Tingen.

⦁	\Reports
Exported reports.

⦁	\Warnings
Warnings messages generated by Tingen.
In addition to the directories above, the \Remote directory also contains the following:
⦁	\Exports
Exported data.

⦁	Current-Tingen-LIVE-Settings.md
⦁	Current-Tingen-UAT-Settings.md
Documents detailing the current Tingen settings.

⦁	TINGEN LIVE IS CURRENTLY %TingenMode%
⦁	TINGEN UAT IS CURRENTLY %TingenMode%
The status of each Tingen instance.





These are the different messages users will receive.
 
