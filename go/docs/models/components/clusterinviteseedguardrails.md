# ClusterInviteSeedGuardrails

Whether the organization is enrolled in the gateway's cluster default guardrails when the invitation is accepted. Defaults to enabled. The enrollment is applied before acceptance commits; if it fails, no organization is created and the invitation stays claimable. The cluster default's rules and cluster-wide switch are managed in the gateway.


## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Enabled`          | `bool`             | :heavy_check_mark: | N/A                |