using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{   
    GameObject Package, Customer;
    public bool PackageSit;
    public float steering_speed = 200;
    public float move_speed = 5;
    public bool DeliverySit ;
 void OnTriggerEnter2D(Collider2D other) 
    {   

        if(other.tag == "GoldenPackage" && PackageSit == false)
        {
            
            Debug.Log("Player Picked up the GoldenPackage");
            PackageSit = true;
            DeliverySit= false;
            Destroy(other.gameObject);
            
        }
    

        if(other.tag == "Customer" && DeliverySit == false && PackageSit == true )
        {
            Debug.Log("GoldenPackage is delivered");
            DeliverySit = true;
            PackageSit = false;
                        
        }
    
    
    }
 
   
    void FixedUpdate()
    {
       float steer_amount = Input.GetAxis("Horizontal") * Time.deltaTime;
       float move_amount = Input.GetAxis("Vertical") * Time.deltaTime;
       transform.Rotate(0, 0, -steer_amount * steering_speed);
       transform.Translate(0, move_speed * move_amount,0); 
    }
}
