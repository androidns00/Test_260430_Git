using UnityEngine;

public class MouseWorld : MonoBehaviour
{
    public GameObject cube;
    public LayerMask gamePlaneMask;
    public GetPosition positionProvider;

    void Update()
    {
       
        cube.transform.position = positionProvider.GetMouseWorldPosition(gamePlaneMask);
    }
}
