using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageCollison : MonoBehaviour
{    
    public bool PackageSit ;
    public GameObject Package;
    


    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other) 
    {   

        if(other.tag == "Player" && PackageSit == false)
        {
            
            Debug.Log("Player Picked up the GoldenPackage");
            PackageSit = true;
            
        }
    
        if(other.tag == "Customer" && PackageSit == true)
        {
            Debug.Log("GoldenPackage is delivered");
            PackageSit = false;
        }
    
    }
}
