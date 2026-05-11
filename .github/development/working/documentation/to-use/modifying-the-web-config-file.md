# Modifying the Web.config file

* [Opening the `Web.config` file](#modifying-the-avtrsys-setting)
* [Modifying the `AvtrSys` setting](#)
* [Modifying the `TngnWsvcMode` setting](#)
* [Modifying the `AdminMode` setting](#)

## Opening the Web.config file

1. Go to the host location of the Tingen Web Service
2. Open the `Web.config` file in a text editor
3. Locate the `<applicationSettings>` section, which should look something like this:

```xml
<applicationSettings>
  <TingenWebService.Properties.Settings>
    <setting name="AvtrSys" serializeAs="String">
      <value>UAT</value>
    </setting>
    <setting name="TngnWsvcMode" serializeAs="String">
      <value>disabled</value>
    </setting>
    <setting name="AdminMode" serializeAs="String">
      <value>disabled</value>
    </setting>
  </TingenWebService.Properties.Settings>
</applicationSettings>
```

# Modifying the `AvtrSys` setting

The `AvtrSys` setting determines what Avatar System the Tingen Web Service will interface with.

Examples of Avatar Systems are `UAT` and `LIVE`.

To modify the `AvtrSys` setting:

1. [Open the Web.config file](#opening-the-webconfig-file)
2. Find the key named `AvtrSys` setting, which looks like this when interfacing with your `UAT` environment:

```xml
<setting name="AvtrSys" serializeAs="String">
  <value>UAT</value>
</setting>
```

3. Change the `value` to the Avatar System you want the Tingen Web Service to interface with.  
For example, to interface with your `LIVE` environment:

```xml
<setting name="AvtrSys" serializeAs="String">
  <value>LIVE</value>
</setting>
```

# Modifying the `TngnWsvcMode` setting

The `TngnWsvcMode` setting determines what *mode* the Tingen Web Service will work in, which in turn determines what functionality is available.

The following modes are available:

<!-- TODO: Descriptions, and maybe in a table -->
* **Enabled**
* **Disabled**
* **Passthrough**

To modify the `TngnWsvcMode` setting:

1. [Open the Web.config file](#opening-the-webconfig-file)
2. Find the key named `TngnWsvcMode` setting, which looks like this when *enabled*:

```xml
      <setting name="TngnWsvcMode" serializeAs="String">
        <value>Enabled</value>
      </setting>
```

3. Change the `value` to the mode you want the Tingen Web Service to use.  
For example, to *disable* the Tingen Web Service:

```xml
<setting name="AvtrSys" serializeAs="String">
  <value>Disabled</value>
</setting>
```

# Modifying the `AdminMode` setting

The `AdminMode` setting enables various administrative processes, including:

<!-- TODO: Descriptions, and maybe in a table -->
* **RegressionTest**
* **RefreshAppData**
* **InitializeDeployment**

> Do not use `AdminMode` unless you know what you are doing! 

To modify the `AdminMode` setting:

1. [Open the Web.config file](#opening-the-webconfig-file)
2. Find the key named `AdminMode` setting, which looks like this by default:

```xml
      <setting name="AdminMode" serializeAs="String">
        <value>Disabled</value>
      </setting>
```

3. Change the `value` to the mode you want the AdminMode you want to use.  
For example, to perform regression testing:

```xml
<setting name="AdminMode" serializeAs="String">
  <value>RegressionTest</value>
</setting>
```