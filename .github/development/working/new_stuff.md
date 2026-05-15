        ///     <note type="tip" title="How-To Modify the AvatarSystem setting">
        ///     <h3>To modify the AvatarSystem that the Tingen Web Service will interface with :</h3>
        ///         <list type="number">
        ///             <item>Open the <c>Web.Config</c> file located in the root directory of the Tingen Web Service.</item>
        ///             <item>Locate the <c>AvatarSystem</c> setting within the <c>applicationSettings</c> section.</item>
        ///             <item>Change the value of <c>AvatarSystem</c> setting to the desired value.</item>
        ///             <item>Save the changes to the <c>Web.Config</c> file.</item>
        ///         </list>
        ///         For example, to set the Avatar System to `LIVE`:
        ///         <code>
        ///             &lt; setting name="AvatarSystem" serializeAs="String"&gt;
        ///             &lt;value&gt;LIVE&lt;/value&gt;
        ///             &lt;/setting&gt;
        ///         </code>
        ///         Changes to the <c>AvatarSystem</c> setting will be applied the next time the Tingen Web Service is executed.
        ///     </note>