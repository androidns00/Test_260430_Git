using UnityEngine;

public class MouseWorld : MonoBehaviour
{
    public GameObject cube;
    public LayerMask gamePlaneMask;
    public GetPosition positionProvider;

    void Update()
    {
        if (cube == null || positionProvider == null)
        {
            return;
        }

        cube.transform.position = positionProvider.GetMouseWorldPosition(gamePlaneMask);
    }
}
