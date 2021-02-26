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

   private void Start() {
      
       warrior_rb = GetComponent<Rigidbody2D>();
   } 
   private void Update() {
     //  dirX = CrossPlatformInputManager.GetAxis("Horizontal")*moveSpeed;
       //rb.velocity = new Vector2(dirX,0f);
   }

   public void MoveUp()
   {
       transform.position+=Vector3.up*moveSpeed*Time.deltaTime;
   }
    public void MoveDown()
    {
         transform.position+=Vector3.down*moveSpeed*Time.deltaTime;
    }
    public void MoveLeft()
    {
         transform.position+=Vector3.left*moveSpeed*Time.deltaTime;
    }
    public void MoveRight()
    {
         transform.position+=Vector3.right*moveSpeed*Time.deltaTime;
    }
    public void SimpleAttack()
    {

    }
}

}
