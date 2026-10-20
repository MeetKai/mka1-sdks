# AppliedClusterDefaultGuardrails

Cluster default guardrails enforced beneath the organization's own policies. Only cluster admins can change or see their configuration.


## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `Guardrails`                                                                                   | [][components.ClusterDefaultRuleSummary](../../models/components/clusterdefaultrulesummary.md) | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `UpdatedAt`                                                                                    | [*time.Time](https://pkg.go.dev/time#Time)                                                     | :heavy_check_mark:                                                                             | When the operator last changed the cluster default; null while the built-in default applies    |