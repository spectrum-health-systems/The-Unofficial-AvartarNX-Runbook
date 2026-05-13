<!-- u241205 -->

# Tingen Roadmap

- Currently a bunch of stuff is refreshed when Tingen is disabled, but those things need to be manually refreshed when it's enabled again. Is there an efficient way to check to see if there is a change back to enabled, and refresh things.

## Tingen Commander

- Desktop app for Tingen.
- Updates Tingen
- Killswitches

## Lieutenant

- Runs various processes after hours (log maintenance, etc.)

## DevDeploy

- Move data to it's own folder.

## Deploy to LIVE

- Automate (via Commander)?
- Auto backups of previous/current versions

## Tingen/Outpost31

### Framework

* Update Sandcastle
* Move Tingen_development to Tingen
* Move to .NET 8
* Update nuget security vulnerabilities
* Standardize all images (e.g., no "_README.png")
* Move to RarelySimple
* Remove c:\TingenData\Lieutenant
* Update README.md on server to point to online documentation whenever possible
* Add folder structure stuff to online documentation

### General

* Formatting is off in settings export file

### Module: Admin

* Command to verify framework
* Command to reset framework
* Command to reset config

### Module: Open Incident Form

* Test modopeninc enable/disable

## Current settings file

## Testing form

* Form load does all the checks, then displays a popup with info
* Checkboxes to:
  * Rebuild built-in templates
   
## Docs

* Verify the script paramter examples in Common_doc.xml are accurate

