using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.WarriorScripts;
namespace Scripts
{
    public class Buttons : MonoBehaviour
{
   public PlayerControl playerControl_script;
   float dirX;
   float moveSpeed = 5f;
   public GameObject warrior_go;
   private bool moveUp,moveDown,moveLeft,moveRight;
   
    // Start is called before the first frame update
    void Start()
    {
           playerControl_script = GameObject.FindWithTag("Player").GetComponent<PlayerControl>();
          InitializeBooleanDirections();
    }
   
  
    private void Update() 
    {
        PlayerMovement();
    }

   void InitializeBooleanDirections()
   {
          moveUp = false;
          moveDown = false;
          moveLeft = false;
          moveRight = false;
   }

    public void PlayerMovement()
    {
          if(moveUp)
        {
            playerControl_script.MoveUp();
        }
        if(moveDown)
        {
            playerControl_script.MoveDown();
        }
        if(moveLeft)
        {
            playerControl_script.MoveLeft();
        }
        if(moveRight)
        {
            playerControl_script.MoveRight();
        }
    }
        

   //INPUT BUTTONS
   public void UnclickMoveUp()
   {
       moveUp = false;
   }
   public void ClickMoveUp()
   {
       moveUp = true;
   }
   public void ClickMoveDown()
   {
       moveDown = true;
   }
   public void UnclickMoveDown()
   {
       moveDown = false;
   }
   public void CLickMoveLeft()
   {
       moveLeft = true;
   }
   public void UnclickMoveLeft()
   {
       moveLeft = false;
   }
   public void ClickMoveRight()
   {
       moveRight = true;
   }
   public void UnclickMoveRight()
   {
       moveRight = false;
   }
   public void AttackBtn()
        {
            playerControl_script.SimpleAttack();
        }
}
}

