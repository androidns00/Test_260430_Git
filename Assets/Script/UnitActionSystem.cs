using UnityEngine;
using UnityEngine.InputSystem;
public class UnitActionSystem : MonoBehaviour
{
    [SerializeField] private LayerMask gamePlaneMask;
    [SerializeField] private GetPosition positionProvider;

    private Unit selectedUnit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            if(TryhandUnitSelection()) return;
            if (selectedUnit == null) return;  
            selectedUnit.Move(positionProvider.GetMouseWorldPosition(gamePlaneMask));
        }
    }
    private bool TryhandUnitSelection()
    {
        Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        if(Physics.Raycast(ray,out RaycastHit hit,Mathf.Infinity,LayerMask.GetMask("Unit")))   
        {
            selectedUnit = hit.transform.GetComponent<Unit>();
            if(selectedUnit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        return false;
    }
}
