# ShellNetworkPolicy


## Supported Types

### ShellAllowlistNetworkPolicy

```go
shellNetworkPolicy := components.CreateShellNetworkPolicyAllowlist(components.ShellAllowlistNetworkPolicy{/* values here */})
```

### ShellPublicInternetNetworkPolicy

```go
shellNetworkPolicy := components.CreateShellNetworkPolicyPublicInternet(components.ShellPublicInternetNetworkPolicy{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch shellNetworkPolicy.Type {
	case components.ShellNetworkPolicyTypeAllowlist:
		// shellNetworkPolicy.ShellAllowlistNetworkPolicy is populated
	case components.ShellNetworkPolicyTypePublicInternet:
		// shellNetworkPolicy.ShellPublicInternetNetworkPolicy is populated
	default:
		// Unknown type - use shellNetworkPolicy.GetUnknownRaw() for raw JSON
}
```
