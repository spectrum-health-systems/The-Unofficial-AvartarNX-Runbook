> Last updated: May 1, 2025

<div align="center">

  ![logo](/.github/image/logo/TingenDevelopmentDocumentation_logo_320x420.png)

  ![TINGEN_VERSION](https://img.shields.io/badge/TINGEN%2025.6-white?style=for-the-badge)
  
  <h1>Tingen Web Service directory structure</h1>

</div>

<br>

## Solution

* Outpost31
  * Core
    * Avatar
    * Catalog
    * Configuration
    * Framework
    * Logger
    * Runtime - Runtime-related
    * Session - Session-related
    * Utilities
      * Du - Common utilities
  * Module
    * Admin
    * OpenIncident



## Server

C:
+---Tingen_Data
    \---Commander
        \---Logs
    \---DevDeploy
        \---Logs
        \---Staging
    \---Development
        \---Builds
    \---Public
    \---WebService
        \---LIVE
            \...copy of UAT
        \---UAT
            \---Archive
                \---Build
                \---Log
                \---Release
            \---Config
                \---Core
                \---Module
                \---Runtime
            \---Data
                \---Export
                \---Import
            \---Messages
                \---Alert
                \---Error
                \---Warning
            \---Log
                \---Critical
                \---Debug
                \---Debuggler
                \---Primeval
            \---Sessions
            \---Temporary
            \---Templates
                \---OptObjErrorMessage
                \---UserMessage
    
