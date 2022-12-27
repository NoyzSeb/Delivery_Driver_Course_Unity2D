using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{   
    public GameObject Package;
    bool packagesit;
    public bool DeliverySit ;
    void OnTriggerEnter2D(Collider2D other) 
    {   
         Package = GameObject.FindGameObjectWithTag("GoldenPackage");
         packagesit = Package.GetComponent<PackageCollison>().PackageSit;  

        if(other.tag == "Player" && DeliverySit == false && packagesit == true )
        {
            Debug.Log("GoldenPackage is delivered");
            DeliverySit = true;
            Debug.Log(packagesit);
        }
    
    }
}
