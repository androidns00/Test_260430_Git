using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Unit : MonoBehaviour
{
    Vector3 targetPosition;
    float stopDistance = 0.1f;
    public float movespeed = 1f;
    void Start()
    {
        Move(new Vector3(10,0,0));  
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,targetPosition)>stopDistance)
        {
            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            transform.position = transform.position + moveDirection * movespeed * Time.deltaTime;
            
        }
    }

    public void Move(Vector3 position)
    {
        targetPosition = position;
    }
}
