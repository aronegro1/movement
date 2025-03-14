
using UnityEngine;

public class playermoves : MonoBehaviour
{
    
    public Rigidbody rb;
    public bool isGrounded;
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("ground")){
            isGrounded = true;
        }
    }
      
      
       void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = false;
        }
    }
      
      
      void Update()
    {
        
        
        
        
        
        
        
        
        
        
    if( Input.GetKey("d") && isGrounded ==true){
        rb.AddRelativeForce(1500 * Time.deltaTime,0,0);
        
    }
    if( Input.GetKey("a") && isGrounded == true){
        rb.AddRelativeForce(-1500 * Time.deltaTime,0,0);
    }
    
    
    
    if( Input.GetKey("w") && isGrounded == true){
    rb.AddRelativeForce(0,0,3000 * Time.deltaTime);
     }
    
     if (Input.GetKey("space") && isGrounded == true)
    {
        rb.AddRelativeForce(0, 12000 * Time.deltaTime, 0);
    }
   
   if (Input.GetKey("s") && isGrounded == true){
    rb.AddRelativeForce(0,0,-1500 * Time.deltaTime);
   }
   
    










if( Input.GetKey("d") && isGrounded == false){
        rb.AddRelativeForce(150 * Time.deltaTime,0,0);
        
    }
    if( Input.GetKey("a") && isGrounded == false){
        rb.AddRelativeForce(-150 * Time.deltaTime,0,0);
    }
    
    
    
     if(Input.GetKey("w") && isGrounded == false){
    rb.AddRelativeForce(0,0,300 * Time.deltaTime);
     }
    
     if (Input.GetKey("space") && isGrounded == false)
    {
        rb.AddRelativeForce(0, 0 * Time.deltaTime, 0);
    }
   
   if (Input.GetKey("s") && isGrounded == false){
    rb.AddRelativeForce(0,0,-150 * Time.deltaTime);
   }
   
}




void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("wall1")){
            isGrounded = true;
        }
    }

























}