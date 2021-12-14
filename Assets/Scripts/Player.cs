using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
    [SerializeField] public GameObject CameraMountPoint;
    [SyncVar] public float _speed = 1f;

    Animator _animator;

    private void Start() {
        if(hasAuthority)
        {
            Transform cameraTransform = Camera.main.gameObject.transform;
            cameraTransform.parent = CameraMountPoint.transform;
            cameraTransform.position = CameraMountPoint.transform.position;
            cameraTransform.rotation = CameraMountPoint.transform.rotation;
        }
    }
    private void FixedUpdate() {
        if(!isLocalPlayer)return;
        Move();
    }
    public void Move()
    {
        if(hasAuthority)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontal, 0f, vertical);
            transform.Translate(movement * _speed * Time.deltaTime, Space.World);
            //_animator.SetBool("Run", movement.magnitude > 0);
        }
    }
}

    
