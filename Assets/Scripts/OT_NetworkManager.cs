using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class OT_NetworkManager : NetworkManager
{
    [SerializeField] public float spawnRadius = 5f;
    [SerializeField] public float spawnCollisionCheckRadius = 1f;
    public override void OnServerConnect(NetworkConnection conn)
    {
        base.OnServerConnect(conn);

        Vector3 spawnPos = FindObjectOfType<OT_SpawnPositions>().GetSpawnPosition();
        while(Physics.CheckSphere(spawnPos, spawnCollisionCheckRadius))
        {
            spawnPos = spawnPos + Random.insideUnitSphere * spawnRadius;
            spawnPos.y = 0f;
        }
        var playerCharacter = Instantiate(OT_NetworkManager.singleton.spawnPrefabs[0], spawnPos, Quaternion.identity).GetComponent<OT_Player>();
        NetworkServer.Spawn(playerCharacter.gameObject, conn);
        
        Debug.Log("Spawned OT_Player");
    }

    public override void OnServerDisconnect(NetworkConnection conn)
    {
        base.OnServerDisconnect(conn);
    }
}
