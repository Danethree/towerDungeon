using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Scripts.WarriorScripts.PlayerArrow
{
public class Arrow : MonoBehaviour
{
    

    private Rigidbody2D arrowRb;
    float speed = 5;

    Vector2 direction;
    void Start()
    {
    
       arrowRb = GetComponent<Rigidbody2D>();
        
    }

    void FixedUpdate()
   {
     arrowRb.velocity = direction*speed;
   }
    // Update is called once per frame

   
    void Update()
    {
       
       
      
        
    }

   public void VerifyArrowPosition(Vector2 _direction)
    {
        direction = _direction;
    }


}
}