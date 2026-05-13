<!-- u251117 -->

[[🏠︎](../../README.md)] ❬ [Development documentation](../README.md)

<div align="center">

  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-dark-400x63.png">
    <source media="(prefers-color-scheme: light)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
    <img alt="Fallback image description" src="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
  </picture>

  <h1>Netsmart Web Services</h1>

</div>

<br/>

#### CONTENT

* [What is a Netsmart web service?](#what-is-a-netsmart-web-service)
* [Netsmart web services and the Tingen Web Service](#netsmart-web-services-and-the-tingen-web-service)

Netsmart web services are web services created by Netsmart.

You can leverage Netsmart web services to increase system usability, efficiency, data accuracy, and compliance.

For example, you can automate data validation tasks such as scoring and scoring results. That way, clinicians can quickly view assessment scores and provide next steps based on the generated score.

For more information about Netsmart web services:

1. Login to [NetsmartConnect](https://netsmartconnect.com)
2. Go to the Resource Center (NRC)
3. Under "My Solutions", choose "myAvatar"
4. Click "Web Services"

# Netsmart web services and the Tingen Web Service

You can add a Netsmart web service to the Tingen Web Service, and then utilize that web service to do cool things.

> [!WARNING]
> The following instructions assume you are using the .NET Framework 4.8.

## 1. Confirm the Netsmart web service URL

Before adding a Netsmart web service to the Tingen Web Service, confirm that the URL you will be adding is valid by:

1. Pasting the WSDL URL into a browser
2. Verifying that the WSDL page is displayed

## 2. Adding the Netsmart web service to the Tingen Web Service

To add a Netsmart Web Service:

1. Right-click on your project
2. Click **Add**
3. Click **Service Reference**
4. Click the **Advanced** button
5. Click the **Add Web Service** button
6. In the *URL* field, put the name of the Web Service you want to add. It should look something like this:

* <ins>LIVE</ins>  
`<https://ORGANIZATIONcsp.netsmartcloud.com/csp/ORGANIZATION/avpm/WEBSVC.UserManagement.CLS?WSDL>`  
  
  Keep in mind that different Avatar Systems will have different URLs:

* <ins>UAT</ins>  
`<https://ORGANIZATIONcsp.netsmartcloud.com/csp/ORGANIZATIONuat/avpm/WEBSVC.UserManagement.CLS?WSDL>`

* <ins>SBOX</ins>  
`<https://ORGANIZATIONcsp.netsmartcloud.com/csp/ORGANIZATIONsbox/avpm/WEBSVC.UserManagement.CLS?WSDL>`

7. Click the arrow icon to the right of the URL. The Web Service should be found.

8. In the *Web reference name* field, give the web service a name that your project will use to reference the Web Service using the following syntax:  
`NtstWscv{AvatarSystem}{NetsmartWebServiceName}`  
  for example:  
`NtstWscvSboxUserManagement`

9. Click **Add Reference**.
