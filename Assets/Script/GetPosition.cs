using UnityEngine;
using UnityEngine.InputSystem;

public class GetPosition : MonoBehaviour
{
    public Vector3 GetMouseWorldPosition(LayerMask layerMask)
    {
        Camera mainCamera = Camera.main;
        if (mainCamera == null || Mouse.current == null)
        {
            return Vector3.zero;
        }

        Ray ray = mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
        
        if (Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, layerMask))
        {
            return hit.point;
        }

        return Vector3.zero;
    }
}