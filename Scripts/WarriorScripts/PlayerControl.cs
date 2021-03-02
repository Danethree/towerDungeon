using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.CrossPlatformInput;


  //This Script is responsable for control Player Inputs

namespace Scripts.WarriorScripts
{
  
    public class PlayerControl : MonoBehaviour,IPlayer
{
 
   Rigidbody2D warrior_rb;
   float dirX;
   float moveSpeed = 10f;
   public PlayerAnimations playerAnimationsScript;
        bool flipX;

   private void Start() {
      
       warrior_rb = GetComponent<Rigidbody2D>();
   } 
   private void Update() {

           // IdlePosition();
           //  PCMovement();

        }

    private void IdlePosition()
        {
            if (warrior_rb.velocity == Vector2.zero)
            {
                playerAnimationsScript.StateMovement(0);
            }

        }
        private void Flip()
        {
            if(flipX)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
        }

   public void MoveUp()
   {
           
            playerAnimationsScript.StateMovement(1);
            Flip();
            transform.position+=Vector3.up*moveSpeed*Time.deltaTime;
   }
    public void MoveDown()
    {
          
            playerAnimationsScript.StateMovement(2);
            Flip();
            transform.position+=Vector3.down*moveSpeed*Time.deltaTime;
    }
    public void MoveLeft()
    {

          transform.localScale = new Vector3(-1,1,1);
            flipX = true;
          playerAnimationsScript.StateMovement(3);
     
         transform.position+=Vector3.left*moveSpeed*Time.deltaTime;
    }
    public void MoveRight()
    {
        
        transform.localScale = new Vector3(1,1,1);
            flipX = false;
             playerAnimationsScript.StateMovement(4);
         transform.position+=Vector3.right*moveSpeed*Time.deltaTime;
    }
    public void SimpleAttack()
    {
            playerAnimationsScript.Attack();
    }

    public void PCMovement()
        {
            IdlePosition();
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SimpleAttack();
            }
            if(Input.GetKey(KeyCode.UpArrow))
            {
              
                MoveUp();
            }
             if (Input.GetKey(KeyCode.DownArrow))
            {
              
                MoveDown();
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {

                MoveLeft();
            }
            if(Input.GetKey(KeyCode.RightArrow))
            {
                MoveRight();
            }
           
        }
        
}

}
