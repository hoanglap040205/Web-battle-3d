using System;
using UnityEngine;

public class GraplingGun : MonoBehaviour
{
    public bool isGrapling;
    public Vector3 _grappPoint;
    [SerializeField] private float grappleDistance;
    public Transform firePoint;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartGrapple();
        }

        if (Input.GetMouseButton(0))
        {
            if (isGrapling)
            {
                
            }
        }
    }

    private void StartGrapple()
    {
        if(isGrapling) return;
        RaycastHit hit;
        if (Physics.Raycast(firePoint.transform.position, firePoint.transform.forward, out hit, grappleDistance))
        {
            _grappPoint = hit.point;
            isGrapling = true;
        }
    }
}
