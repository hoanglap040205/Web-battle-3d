using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerInput : MonoBehaviour
{
    private Camera main;
    private Vector3 anchor;
    private float angle;
    private Vector3 finger;
    private Vector3 point;

    public Vector2 Direction => finger - anchor;
    

    private void Start()
    {
        if (Camera.main != null)
        {
            main = Camera.main;
        }
    }


    private void Update()
    {
        HandleInput();
        if (Input.GetMouseButtonDown(0))
        {
            anchor = point;
        }else if (Input.GetMouseButton(0))
        {
            finger = point;
            UpdateAngle(finger - anchor,Vector2.up);

        }else if (Input.GetMouseButtonUp(0))
        {
            finger = point;
            UpdateAngle(finger - anchor,Vector2.up); 
            //Debug.Log("Final Angle " + angle);
        }
    }


    private void UpdateAngle(Vector2 a, Vector2 b)
    {
        angle = (int)Vector2.Angle(a, b);
        Debug.Log("Angle " + angle);
        float crossProduct = a.x * b.y - a.y * b.x;
        if (crossProduct > 0)
        {
            angle = 360 - angle;
        }
    }

    private void HandleInput()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 0f;
        point = mousePos;
        
    }
    
}
