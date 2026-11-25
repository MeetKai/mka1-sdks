# ShellPublicInternetNetworkPolicy

Any public hostname on ports 80 and 443, through the sandbox's audited egress proxy. IP addresses, private and cluster networks and other ports stay blocked, and tenant allowlists still narrow it. Refused unless the cluster enables it.


## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Type`             | `string`           | :heavy_check_mark: | N/A                |