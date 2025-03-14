using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walljump : MonoBehaviour
{
       
       public Rigidbody rb;
       
       void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("wall1") && Input.GetKey("space")){
            rb.AddRelativeForce(0, 100, 0);
        }
       }
    void Update()
    {
        
    }
}
