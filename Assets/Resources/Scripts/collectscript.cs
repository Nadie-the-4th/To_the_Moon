using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class collectscript : MonoBehaviour
{
   

     private void OnTrigger2DEnter(Collider2D collider2D)

    {

    if (collider2D.gameObject.CompareTag("Objects")) 
     {
          Destroy(collider2D.gameObject);

       print ("it worked!!!");
       
     }

     if (collider2D.gameObject.layer == 6)

     {
        
       print ("it worked!!!");
       
        Destroy(collider2D.gameObject);
       
     }
    }

      void OnCollision2DEnter(Collision2D collision2D)

     {

     if (collision2D.gameObject.CompareTag("Objects")) 
     {
          Destroy(collision2D.gameObject);

       print ("it worked!!!");
       
     }

     }

   }

