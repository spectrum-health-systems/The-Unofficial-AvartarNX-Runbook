# Testing

## Admin

### Admin-Service-Mode-Update

1. Verify TingenMode = Enabled
2. Execute Tingen
3. Verify "CURRENTLY ENABLED" file is written

4. Verify TingenMode = Disabled
5. Execute Tingen
6. Verify "CURRENTLY DISABLED" file is written

7. Verify TingenMode = ""
8. Execute Tingen
9. Verify "CURRENTLY UNKNOWN STATE" file is written
10. 