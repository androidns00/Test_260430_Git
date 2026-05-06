using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Unit : MonoBehaviour
{
    
    Vector3 targetPosition;
    float stopDistance = 0.1f;
    [Header ("Movement")]
    [SerializeField] private float movespeed = 1f;
    [SerializeField] private LayerMask gamePlaneMask;
    [SerializeField] private GetPosition positionProvider;

    void Start()
    {
        ///Move(new Vector3(10,0,0));  
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,targetPosition)>stopDistance)
        {
            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            transform.position = transform.position + moveDirection * movespeed * Time.deltaTime;
            
        }
        if(Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector3 mouseWorldPosition = positionProvider.GetMouseWorldPosition(gamePlaneMask);
            Move(mouseWorldPosition);
        }
    }

    public void Move(Vector3 position)
    {
        targetPosition = position;
    }
}
