# PowerShell SCCM CLI Project

## Goals:

To create a simple CLI tool in PowerShell to connect to SCCM to do:
- To run CMPivot reports and convert to CSVs
- See Device Collections
- Collect Device information in a more streamlined fasion

## Features

- Want it to be an interactive shell that closes upon "exit"
- Commands:
    - Help
    - Reports
    - Device
    - Device Collections
    - Echo
    - Exit
- Auto-tab completion
- Save and write to files (Will need to look more into this)
- Manual Pages (For Shell and SCCM commands)

## Examples

```

$> Help

Commands: [Reports, Device Collection, Device, Echo, Exit, Help]

----- Reports ------

Parameters:
- DeviceColletion (Optional iff device specified : mandatory)
- Device (Optional iff devic collection specified : mandatory) 
- Query (Mandatory)

$> Reports

$"Reports"> "Administrators" -DeviceCollection "*Device Collection*"

$Reports> "*Query*" -DeviceCollection "*Device Collection*"

$> Report -DeviceCollection "" -Device "" -Query ""



---- Device -----

$> Device


```
