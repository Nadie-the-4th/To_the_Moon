using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idk : MonoBehaviour
{
   

    // Update is called once per frame
   public void OnTrigger2DEnter(Collider2D collider2D)
    {
        if (collider2D.gameObject.CompareTag("Objects"))
        {
        Destroy (collider2D.gameObject);
        print ("Object DESTROYED (finalscriptupdate)");
        }
    }


}
