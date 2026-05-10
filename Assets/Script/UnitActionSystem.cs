using UnityEngine;
using UnityEngine.InputSystem;
public class UnitActionSystem : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Unit selectedUnit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector3 mouseWorldPosition = selectedUnit.positionProvider.GetMouseWorldPosition(selectedUnit.gamePlaneMask);
            selectedUnit.Move(mouseWorldPosition);
        }
    }
}
