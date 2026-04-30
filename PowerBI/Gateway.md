<sub>[The Unofficial AvatarNX Runbook](../README.md) ❬ PowerBI ❬ **Setting up a PowerBI Gateway**</sub>

<div align="center">

  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="../.github/repository/logo/TheUnofficialAvatarNxRunbook-Logo-162x152.png">
    <source media="(prefers-color-scheme: light)" srcset="../.github/repository/logo/TheUnofficialAvatarNxRunbook-Logo-162x152.png">
    <img alt="Fallback image description" src="../.github/repository/logo/TheUnofficialAvatarNxRunbook-Logo-162x152.png">
  </picture>

  <br>

  <h1>Setting up the Microsoft PowerBI On-Premises Gateway</h1>

</div>

## Introduction

According to [Microsoft’s Power BI Gateway page](https://powerbi.microsoft.com/en-us/gateway/):
> With the on-premises gateways, you can keep your data fresh by connecting to your on-premises  
> data sources without the need to move the data. Query large datasets and benefit from your  
> existing investments. The gateways provide the flexibility you need to meet individual needs,  
> and the needs of your organization.

## Get the Gateway

Download the [Microsoft PowerBI On-Premises Gateway](https://powerbi.microsoft.com/en-us/gateway/)

## Install the Gateway

1. Install the Microsoft PowerBI On-Premises Gateway
2. Click **Next**
3. Choose **On-premises data gateway (recommended)**, then click **Next**
4. You’ll then see a window letting you know that the gateway is about to be installed, followed by a window asking you to confirm the installation path. Accept the terms of use, then click **Install**.             
5. You will need to provide an email address to use with the Gateway. This can be any address at your organization. Then, click **Sign in**.
6. Make sure **Register a new gateway on this computer** is selected, then click **Next**.
7. Name the gateway, and provide a recovery key. Then, click **Configure**.
8. Click **Close**.

## Install and setup the ODBC driver

Please see: [Setup the InterSystems IRIS ODBC driver](../ODBC/IrisDriverSetup.md) documentation.
















2.	Set the PowerBI gateway up:
a.	using the recommended mode, not “personal mode”
b.	using your email. For production, we will want to use another email
c.	named it “PowerBiTestGateway”. For production, we’ll need a better name (duh)
d.	set the recovery key to “petepete”
e.	did not add the gateway to a gateway cluster
3.	Setup an ODBC connection on my VM (the same machine that the gateway is installed):
a.	Installed the 64-bit version of the CACHE ODBC driver. The PowerBi gateway is only compatible w/64-bit. The driver is on the IT share.
b.	Created a new System DNS with the following:
i.	Name: LIVETESTS
ii.	Description: LIVETESTS
iii.	Host: Spectrum.ecp.netsmartcloud.com
iv.	Port: 1972
v.	Namespace: AVPM
vi.	Authentication Method: Password
vii.	User Name: SYSADM
viii.	Password: *******
4.	Tested the connection in the Data Source Setup, it worked.
5.	Clicked “OK”

ON MY LAPTOP
1.	Went to the PowerBi Executive Dashboard.
2.	Clicked the Settings gear
3.	Chose “Manage Gateways”
4.	Created a new data source called “PowerBiTestGateway”
a.	Data Source Name: LIVETESTS
b.	Data Source Type: ODBC
c.	Connection string: DRIVER={InterSystems ODBC};SERVER=Spectrum.ecp.netsmartcloud.com;PORT=1972;DATABASE=AVPM;
d.	Authentication: Basic
e.	Username: SYSADM
f.	Password: *********

> <sub>Last updated: April 30, 2026</sub>

<sub>[The Unofficial AvatarNX Runbook](../README.md) ❬ PowerBI ❬ **Setting up a PowerBI Gateway**</sub>