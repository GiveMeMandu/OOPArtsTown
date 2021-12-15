using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CharacterMover : NetworkBehaviour
{
    [SyncVar] public float _speed = 2f;
    public bool isMoveable;

    //Animator _animator;
    private MeshRenderer meshRenderer;

    [SyncVar(hook = nameof(SetPlayerColor_Hook))]
    public EPlayerColor playerColor;
    public void SetPlayerColor_Hook(EPlayerColor oldColor, EPlayerColor newColor)
    {
        if(meshRenderer == null)
        {
            meshRenderer = GetComponent<MeshRenderer>();
        }
        meshRenderer.material.SetColor("_PlayerColor", OT_PlayerColor.GetColor(newColor));
        Debug.Log("New Player Color");
    }

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.SetColor("_PlayerColor", OT_PlayerColor.GetColor(playerColor));
        
    }
    private void FixedUpdate()
    {
        //if(!isLocalPlayer)return;
        Move();
    }
    public void Move()
    {
        if(hasAuthority && isMoveable)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontal, 0f, vertical);
            transform.Translate(movement * _speed * Time.deltaTime, Space.World);
            //_animator.SetBool("Run", movement.magnitude > 0);
        }
    }
}
