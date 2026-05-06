using UnityEngine;
using UnityEngine.InputSystem;

public class MouseWorld : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject cube;
    public LayerMask gamePlaneMask;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
      
        Physics.Raycast(ray, out RaycastHit hit,float.MaxValue, gamePlaneMask);
        cube.transform.position = hit.point;
    }
}
