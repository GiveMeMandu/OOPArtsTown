using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OT_SpawnPositions : MonoBehaviour
{
    [SerializeField]
    private Transform[] positions;

    private int index;

    public Vector3 GetSpawnPosition()
    {
        Vector3 pos = positions[index].position;
        return pos;
    }
}
