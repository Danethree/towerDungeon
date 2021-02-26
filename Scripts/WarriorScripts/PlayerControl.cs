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

   private void Start() {
      
       warrior_rb = GetComponent<Rigidbody2D>();
   } 
   private void Update() {
            PCMovement();
     
   }

   public void MoveUp()
   {
     playerAnimationsScript.StateMovement(1);
       transform.position+=Vector3.up*moveSpeed*Time.deltaTime;
   }
    public void MoveDown()
    {
         playerAnimationsScript.StateMovement(2);
         transform.position+=Vector3.down*moveSpeed*Time.deltaTime;
    }
    public void MoveLeft()
    {
          transform.localScale = new Vector3(-1,1,1);
          playerAnimationsScript.StateMovement(3);
     
         transform.position+=Vector3.left*moveSpeed*Time.deltaTime;
    }
    public void MoveRight()
    {
        transform.localScale = new Vector3(1,1,1);
             playerAnimationsScript.StateMovement(4);
         transform.position+=Vector3.right*moveSpeed*Time.deltaTime;
    }
    public void SimpleAttack()
    {

    }

    public void PCMovement()
        {
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
            else
            {
                     playerAnimationsScript.StateMovement(0);
            }
        }
        
}

}
