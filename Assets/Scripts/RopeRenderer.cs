using System;
using UnityEngine;

public class RopeRenderer : MonoBehaviour
{
   private LineRenderer line;
   private GraplingGun grapplingGun;

   private void Start()
   {
      line = GetComponent<LineRenderer>();
      grapplingGun = GetComponentInParent<GraplingGun>();
   }

   private void Update()
   {
      if (grapplingGun.isGrapling)
      {
         if (!line.enabled)
         {
            line.enabled = true;
         }
         line.SetPosition(0, transform.position);
         line.SetPosition(1,grapplingGun._grappPoint);
      }
      else
      {
         line.enabled = false;
      }
   }
}
