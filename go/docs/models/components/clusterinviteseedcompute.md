# ClusterInviteSeedCompute

Compute policy to apply when the invitation is accepted. All fields are required when seedCompute is supplied. A null limit is unlimited and zero blocks new resources.


## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Enabled`          | `bool`             | :heavy_check_mark: | N/A                |
| `MaxLiveJobs`      | `*int64`           | :heavy_check_mark: | N/A                |
| `MaxLiveServices`  | `*int64`           | :heavy_check_mark: | N/A                |