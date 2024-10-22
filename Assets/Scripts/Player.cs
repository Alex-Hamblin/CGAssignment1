using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    Rigidbody rb;
    private Vector3 smoothedMoveDir;
    private Vector3 smoothedMoveVelo;
    private Vector3 moveDir;
    Camera playerCam;
    private Transform CamTransform;


    // Start is called before the first frame update
    void Start()
    {
        playerCam = gameObject.GetComponentInChildren<Camera>();
        rb = GetComponent<Rigidbody>();
        InputManager.Init(this);
        InputManager.EnableInGame();
        CamTransform = Camera.main.transform;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        smoothedMoveDir = Vector3.SmoothDamp(smoothedMoveDir, moveDir, ref smoothedMoveVelo, 0.1f);
        smoothedMoveDir = CamTransform.forward * moveDir.z + CamTransform.right * moveDir.x;


        rb.velocity = new Vector3(smoothedMoveDir.x * moveSpeed, -3, smoothedMoveDir.z * moveSpeed);
    }
    internal void SetMoveDirection(Vector3 newDir)
    {
        moveDir = newDir;
    }
}
