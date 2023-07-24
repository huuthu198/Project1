using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float moveSpeed = 5f;
     float horizontal;
     float vertical;
    //Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleMouseDown();
        }

    }

    private void HandleMouseDown()
    {
        throw new NotImplementedException();
    }

    void MyInput()
    {
   
        Vector3 moveDirection = new Vector3(horizontal, 0f, vertical).normalized;
        Vector3 moveAmount = moveDirection * moveSpeed * Time.deltaTime;
        transform.Translate(moveAmount, Space.World);
    }

}



   

    