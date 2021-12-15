using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Mirror;

public class OT_Player : NetworkBehaviour
{
    [SerializeField] private OT_Player playerCharacter;
    [SyncVar] public EPlayerColor playerColor;
    
    private Transform cameraTransform;
    private Vector3 camPos;
    private Vector3 camRot;
    [SerializeField] public float camDelayTime;
    
    private void Start()
    {
        if(isServer)
        {
            Debug.Log("Comfirm Server");
            //SpawnOOPArtsTownPlayerCharacter();
            InitialColorCharacter();
        }
        if(hasAuthority)
        {
            cameraTransform = Camera.main.gameObject.transform;
            camPos = PlayerCameras.GetCamPosition(ECamType.OT);
            camRot = PlayerCameras.GetCamRotation(ECamType.OT);
        }
     
        //OOPArtsTownUIManager.Instance.UpdateNumPlayer();
    }
    /*
    private void OnDestroy() {
        if(OOPArtsTownUIManager.Instance != null)
        {
            OOPArtsTownUIManager.Instance.UpdateNumPlayer();
        }
    }
    */
    private void FixedUpdate()
    {    
        MoveCam();
    }

    /*
    private void SpawnOOPArtsTownPlayerCharacter()
    {
        playerColor = EPlayerColor.Red;
        Vector3 spawnPos = FindObjectOfType<OOPArtsTownSpawnPositions>().GetSpawnPosition();

        var playerCharacter = Instantiate(OOPArtsTownNetworkManager.singleton.spawnPrefabs[0], spawnPos, Quaternion.identity).GetComponent<CharacterMover>();
        NetworkServer.Spawn(playerCharacter.gameObject, connectionToClient);
        playerCharacter.playerColor = playerColor;
        Debug.Log("Spawned OT_Player");
    }
    */
    private void InitialColorCharacter()
    {
        playerColor = EPlayerColor.Blue;
        playerCharacter.playerColor = playerColor;
        Debug.Log("Color Changed");
    }
    public void MoveCam()
    {
        Vector3 FixedPos =
            new Vector3(
            playerCharacter.transform.position.x + camPos.x,
            playerCharacter.transform.position.y + camPos.y,
            playerCharacter.transform.position.z + camPos.z);
        cameraTransform.position = Vector3.Lerp(cameraTransform.position, FixedPos, Time.deltaTime * camDelayTime);
        cameraTransform.rotation = Quaternion.Euler(camRot);
    }
}

    
