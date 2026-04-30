using UnityEngine;

public class MouseWorld : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            // 从摄像机发射一条射线，指向鼠标点击的方向
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // 如果射线碰到了任何带有 Collider（碰撞体）的物体
            if (Physics.Raycast(ray, out hit))
            {
                // hit.point 就是碰撞点的世界坐标
                Vector3 targetPoint = hit.point;
                Debug.Log("3D 撞击位置: " + targetPoint);
                
                // 你甚至可以获取撞到了什么
                Debug.Log("撞到了: " + hit.collider.name);
            }
        } 
    }
}
