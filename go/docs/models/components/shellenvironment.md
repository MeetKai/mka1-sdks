# ShellEnvironment


## Supported Types

### ShellEnvironmentContainerAuto

```go
shellEnvironment := components.CreateShellEnvironmentContainerAuto(components.ShellEnvironmentContainerAuto{/* values here */})
```

### ShellEnvironmentContainerReference

```go
shellEnvironment := components.CreateShellEnvironmentContainerReference(components.ShellEnvironmentContainerReference{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch shellEnvironment.Type {
	case components.ShellEnvironmentTypeContainerAuto:
		// shellEnvironment.ShellEnvironmentContainerAuto is populated
	case components.ShellEnvironmentTypeContainerReference:
		// shellEnvironment.ShellEnvironmentContainerReference is populated
	default:
		// Unknown type - use shellEnvironment.GetUnknownRaw() for raw JSON
}
```
