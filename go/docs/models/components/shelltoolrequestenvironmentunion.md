# ShellToolRequestEnvironmentUnion

Container environment configuration. Defaults to container_auto.


## Supported Types

### ShellEnvironmentContainerAuto

```go
shellToolRequestEnvironmentUnion := components.CreateShellToolRequestEnvironmentUnionContainerAuto(components.ShellEnvironmentContainerAuto{/* values here */})
```

### ShellToolRequestEnvironment

```go
shellToolRequestEnvironmentUnion := components.CreateShellToolRequestEnvironmentUnionContainerReference(components.ShellToolRequestEnvironment{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch shellToolRequestEnvironmentUnion.Type {
	case components.ShellToolRequestEnvironmentUnionTypeContainerAuto:
		// shellToolRequestEnvironmentUnion.ShellEnvironmentContainerAuto is populated
	case components.ShellToolRequestEnvironmentUnionTypeContainerReference:
		// shellToolRequestEnvironmentUnion.ShellToolRequestEnvironment is populated
}
```
