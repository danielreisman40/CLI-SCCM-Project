#  SCCM CLI Project

## Goals:

To create a simple CLI tool to connect to SCCM in order to:
- To better automate and run CMPivot reports and convert to CSVs
- Automate the creation of Device Collections
- Collect Device information in a more streamlined fasion (JSON, CSV, etc.)

## Languages

- PowerShell?
- C# (Probably prefeiied)

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

$> Reports -Help

COMMAND: Reports

Paramerters:
- DeviceColletion (Optional iff device specified : mandatory)
- Device (Optional iff devic collection specified : mandatory) 
- Query (Mandatory)

$> Report -DeviceCollection <STRING> -Device  <STRING> -Query <STRING>

```
