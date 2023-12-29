# Configuration and connection string example for connecting to the read-only side of an Alwayson configured SQL Server.

## Preparetion
ALTER AVAILABILITY GROUP [YourAvailabilityGroupName]
MODIFY REPLICA ON 'YourPrimaryReplicaServerName'
WITH (READ_ONLY_ROUTING_URL = 'TCP://YourReadableSecondaryServer:Port');

## Check
SELECT ar.replica_server_name, ar.read_only_routing_url
FROM sys.availability_replicas AS ar
WHERE ar.replica_server_name = 'YourPrimaryReplicaServerName';
