using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testeCollider : MonoBehaviour
{
    public Collision DEBUG_COLLIDER = null;
    
   void OnCollisionEnter(Collision other)
   {
         DEBUG_COLLIDER = other;
        
    }

}
