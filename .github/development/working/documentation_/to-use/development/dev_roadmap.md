<!-- u250925 -->

<div align="center">

  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngnproj-dark-400x63.png">
    <source media="(prefers-color-scheme: light)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngnproj-light-400x63.png">
    <img alt="Fallback image description" src="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngnproj-light-400x63.png">
  </picture>
  <h1>
    ROADMAPS
  </h1>

</div>

> This is also the roadmap for the [Tingen Web Service](https://github.com/spectrum-health-systems/tingen-web-service.).

***

* [Release](#release)
* [IIS](#iis)
* [Documentation](#documentation)

# Next release

<!-- QUEUE

- [ ] Get the TraceLogLimit next to ExeAsm to make the calls shorter.

- [ ] Move tngnwsvc debug logs to development/tngnwsvc/debug

- [ ] Update Project.xml so it is relevent
- [ ] FormId tranlation table gets a .translation extension
- [ ] Query for form ids, don't use a translation table

- [ ] Session Maintenance
  - [ ] Verify that the current session folder exists

- [ ] Daily Maintenance
  - [ ] Verification process
  - [ ] Refreshment process

- [ ] Monthly Maintenance
  - [ ] Archive all session logs

- [ ] Verification process 
  - [ ] Verify the .history file exists 
  - [ ] Verify all required folders exist (.history records)

- [ ] Refreshment process
  - [ ] Verify all blueprints exist and are up-to-date (.history records) 
  - [ ] Verify all Translation Tables exist are and up-to-date (.history records)

- [ ] Reset process
  - [ ] Reset everything to default states


- [ ] If an OptionId is not found in the translation table, fallback to a database query.
- [ ] exported optobj pretty .json
- [ ] Session log set limit
- [ ] Special chars in names (e.g., "O'Brien") break log files
- [ ] UserId translation table only has active users
- [ ] UserId translation tables by user role
- [ ] Use the UserId translation tables directly (again)
- [ ] Fix admin module (deploy, etc.)
- [ ] Fix session log missing data
- [ ] Point changelog/roadmap to release notes
- [ ] Make R25.9 release notes look like R25.10 release notes
- [ ] Rename .trans ->.translation/.trantable/.trtb
- [ ] OptionObject message titles?
- [ ] Setup custom messages for OptObj error messages
- [ ] Session logs can be simple or verbose
- [ ] Make all session stuff internal (?)
- [ ] Verify classes/methods are public/private/internal
- [ ] Verify that the automated reports are being updated
- [ ] Verify deploy is non-destructive-isg
- [ ] Very simple test return (?)
- [ ] Functionality: Dosing
- [ ] Functionality: Form access
- [ ] Functionality: TeleHealth
- [ ] Whitelists
- [ ] Greylists
- [ ] Blacklists
- [ ] Autmatically create status logs every day
- [ ] Re-enable trace logs for each method
- [ ] Build a trace log package for easier trace logging
- [ ] Limit passed parameters to methods
- [ ] Verify automated reports are being updated
- [ ] Mode terminology Should "disable" work? Or just "disabled", specifically?
- [ ] Performance considerations - Runaway processes - Out of disk space - IIS worker threads
- [ ] Email functionality
- [ ] Fix issue with deploying taking multiple deployments
- [ ] New critical error: the Avatar Systems don't match
- [ ] Email critical errors
- [ ] Trace logs where they need to be
- [ ] Auto-generated data copied from deployment folder
- [ ] Fallback for name conversion (Sebastian's idea)
- [ ] Disable Scripts For Error (what is this?)

-->

<!-- PREVIOUS RELEASES

## R25.10



-->

## R25.9

- [X] Move trace logs to Sessions
- [X] Test to see what happens when a blueprint is deleted, does it show up when the service execute
- [X] Web service appdata -> root NOTE: Don't do this.
- [X] Test looped debugs to make sure they are created with a 1ms delay
- [X] Parameters that start with "_" use the calling form to parse requests.
- [X] Update blueprints to match documentation



# IIS

- [ ] Remove the ISS site from Tingen_www, and add two sites to:
  - Tingen_www\UAT
  - Tingen_www\LIVE
  - Tingen_www\SBOX

# Documentation

- [ ] Document what white/grey/blacklists are for
