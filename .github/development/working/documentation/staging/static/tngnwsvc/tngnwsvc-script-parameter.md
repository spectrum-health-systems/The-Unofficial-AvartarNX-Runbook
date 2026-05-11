<!-- u251008 -->

<div align="center">

  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-dark-400x63.png">
    <source media="(prefers-color-scheme: light)" srcset="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
    <img alt="Fallback image description" src="https://github.com/spectrum-health-systems/tingen-projects/blob/main/logos/tngndocs-light-400x63.png">
  </picture>
  <h4>Tingen Web Service</h4>
  <h1>The Script Parameter</h1>

</div>

> [!TIP]
> Tingen projects use the terms *Script Parameter* and *request* interchangeably.

The **Script Parameter** is the **request** that Avatar sends to the Tingen Web Service.

# Details

* The maximum length of a request is 48 characters
* For readability, it is recommended that you use camelCase in the Script Parameter field of an Avatar form (for example: `ThisIsARequest` instead of `thisisarequest`)

# Valid requests

> As of R25.9

* `_VerifyOriginalAuthorIsOpening`
* `_VerifyOriginalAuthorIsSubmitting`
* `TngnWsvcDeploy`
* `TngnWsvcTest`