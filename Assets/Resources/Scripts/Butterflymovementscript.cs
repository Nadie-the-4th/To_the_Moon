using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Butterflymovementscript : MonoBehaviour
{
    // Start is called before the first frame update
    public float x;

    public float y;

   

    public Transform MyParent;

    public Rigidbody2D myRigidbody;
   
public float movespeed;
    void Start()
    {
        print(transform.position);
       

    }

    // Update is called once per frame
    void Update()
    {

        if(MyParent != null)

        { 
            if (Input.GetKey(KeyCode.D))

            {
                print ("D was pressed!!!");
               x = 3f;
               //y = 0.5f;
           
            }
        }

        if(Input.GetKey(KeyCode.W))
        {
            print ("W was pressed!!!");
             y = 3f;
             //x = 0.5f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            print ("S was pressed!!!");
            y = -3f;
            //x= 0.5f;
    
        }

        if(Input.GetKey(KeyCode.A))
          {
            print ("A was pressed!!!");
           x = -3f;
           //y = -0.5f;
          }
        
       myRigidbody.velocity = new Vector2 (x,y);

    }

    public void OnCollision2DEnter(Collider2D collider2D)
    {

    if (collider2D.gameObject.CompareTag("Player")) 
     {
          Destroy(collider2D.gameObject);

       print ("it fuckin worked!!!");
       
     }

   }
}






//Change velocity then iterate
//then create if statements