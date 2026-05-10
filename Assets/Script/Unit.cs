using System;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Unit : MonoBehaviour
{
    
    Vector3 targetPosition;
    float stopDistance = 0.1f;
    [Header ("旋转和停顿")]
    [SerializeField] private float rotationSpeed = 0.5f;
    [Header ("Movement")]
    [SerializeField] private float movespeed = 1f;
    public LayerMask gamePlaneMask;
    public GetPosition positionProvider;
    [Header ("Animation")]
    public Animator animator; 
    
    private void Awake()
    {
        targetPosition = transform.position;
    }  


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
            transform.forward = Vector3.Lerp(transform.forward, moveDirection, rotationSpeed * Time.deltaTime );
            animator.SetBool("isWalking",true);
        }
        else
        {
            animator.SetBool("isWalking",false);
        }
        
    }

    public void Move(Vector3 position)
    {
        targetPosition = position;
    }
}
